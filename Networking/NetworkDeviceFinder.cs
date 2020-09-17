using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace DevicesOnNetwork
{
    public static class NetworkDeviceFinder
    {
        public static List<NetworkDevice> KnownDevices { get; private set; }
        private static List<IPAddress> filteredAddresses = null;

        private static IPAddress GetIPFromArpLine(string line)
        {
            string[] segments = line.Split('.');
            List<Byte> ipbits = new List<Byte>();

            foreach (string s in segments)
            {
                byte output = 1;
                bool result = false;

                if(s.Length > 3)
                {
                    result = byte.TryParse(s.Substring(0, 3), out output);

                    if (!result)
                    {
                        result |= byte.TryParse(s, out output);
                    }

                    if (result)
                    {
                        ipbits.Add(output);
                    }

                }
                else
                {
                    byte.TryParse(s, out output);
                    ipbits.Add(output);
                }
                
            }

            return new IPAddress(ipbits.ToArray());
        }

        private static List<IPAddress> GetIPsFromArpLines(List<string> arpLines)
        {
            List<IPAddress> addresses = new List<IPAddress>();

            for (int i = 0; i < arpLines.Count; i++)
            {
                if (arpLines.ElementAt(i).Length <= 1)
                {

                    arpLines.RemoveAt(i--);

                }
                else
                {
                    string temp = arpLines.ElementAt(i).Trim();

                    if (temp.StartsWith("I"))
                    {
                        arpLines.RemoveAt(i--);
                    }
                    else
                    {
                        IPAddress ip = GetIPFromArpLine(temp);

                        addresses.Add(ip);
                    }

                }
            }

            return addresses;
        }

        public static List<NetworkDevice> Find()
        {
            if(KnownDevices == null)
            {
                KnownDevices = new List<NetworkDevice>();                
                filteredAddresses = new List<IPAddress>();
            }

            List<NetworkDevice> foundDevices = new List<NetworkDevice>();

            System.Diagnostics.Process Process = new System.Diagnostics.Process();
            Process.StartInfo.FileName = "arp";
            Process.StartInfo.Arguments = "-a ";
            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.CreateNoWindow = true;
            Process.Start();
            string strOutput = Process.StandardOutput.ReadToEnd();

            string[] lines = strOutput.Split('\n');

            List<string> linesList = lines.ToList<string>();
            List<IPAddress> addresses = GetIPsFromArpLines(linesList);

            foreach(IPAddress ip in addresses)
            {
                if (!filteredAddresses.Contains(ip))
                {
                    filteredAddresses.Add(ip);

                    foundDevices.Add(new NetworkDevice(ip));
                }
            }

            KnownDevices.AddRange(foundDevices);
            KnownDevices.Sort(new NetworkDeviceIPComparer());

            return foundDevices;

        }

    }
}


