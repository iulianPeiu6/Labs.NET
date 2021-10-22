using INET.Lab4.Abstracts;
using INET.Lab4.Enums;
using INET.Lab4.Models.Ports;

namespace INET.Lab4
{
    class DeviceFinderCoinDispsenerSch2 : DeviceFinder
    {
        public override string FindDevice(DeviceModel model)
        {
            var port = new PortForCoinDispsenerSch2();
            return Find(port);
        }
    }
}
