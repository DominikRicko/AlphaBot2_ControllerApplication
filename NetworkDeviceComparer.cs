using System.Collections.Generic;
using System.Net;

namespace DevicesOnNetwork
{
    class NetworkDeviceIPComparer : Comparer<NetworkDevice>
    {

        Comparer<IPAddress> comparer;
        public NetworkDeviceIPComparer()
        {
            comparer = new IPComparer();
        }

        public override int Compare(NetworkDevice x, NetworkDevice y)
        {
            return comparer.Compare(x.IP, y.IP);
        }
    }
}
