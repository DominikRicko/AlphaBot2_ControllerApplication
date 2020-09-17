using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace DevicesOnNetwork
{
    class IPComparer : Comparer<IPAddress>
    {
        public override int Compare(IPAddress x, IPAddress y)
        {

            byte[] xBytes = x.GetAddressBytes();
            byte[] yBytes = y.GetAddressBytes();

            uint totalX = (uint)xBytes[0] * 16777216 + (uint)xBytes[1] * 65536 + (uint)xBytes[2] * 256 + (uint)xBytes[3];
            uint totalY = (uint)yBytes[0] * 16777216 + (uint)yBytes[1] * 65536 + (uint)yBytes[2] * 256 + (uint)yBytes[3];

            if (totalX < totalY)
            {
                return -1;
            }
            else if (totalX > totalY)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
