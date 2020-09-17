using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;

namespace DevicesOnNetwork
{
    public class NetworkDevice
    {
        public string Name { get; set; }
        public IPAddress IP { get; private set; }

        private BackgroundWorker hostEntryResolver;

        private EventHandler onNameChanged;

        public event EventHandler NameResolved
        {
            add
            {
                onNameChanged += value;
            }
            remove
            {
                onNameChanged -= value;
            }
        }
        protected virtual void OnNameResolved(EventArgs e)
        {
            onNameChanged?.Invoke(this, e);
        }

        private void worker_Resolve(object sender, DoWorkEventArgs e)
        {
            IPAddress ip = (IPAddress)e.Argument;

            try
            {

                IPHostEntry hostEntry = Dns.GetHostEntry(ip);
                if (hostEntry != null)
                {
                    Name = hostEntry.HostName;
                    OnNameResolved(new EventArgs());
                }

            }
            catch (SocketException) { }
        }

        public NetworkDevice(IPAddress deviceip)
        {
            IP = deviceip;
            Name = "Unknown";
        }

        public void ResolveName()
        {
            hostEntryResolver = new BackgroundWorker();
            hostEntryResolver.DoWork += worker_Resolve;
            hostEntryResolver.RunWorkerAsync(IP);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
    
            sb.Append(IP.ToString())
                .Append("\t\t")
                .Append(Name.ToString());

            return sb.ToString();
        }
    }
}