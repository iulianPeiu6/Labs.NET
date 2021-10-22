using INET.Lab4.Abstracts;
using INET.Lab4.Enums;
using INET.Lab4.Models.Ports;

namespace INET.Lab4
{
    public class DeviceFinderForBillAccepterCash : DeviceFinder
    {
        public override string FindDevice(DeviceModel model)
        {
            var port = new PortForBillAccepterCashCode();
            return Find(port);
        }
    }
}
