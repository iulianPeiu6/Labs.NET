using INET.Lab4.Abstracts;
using INET.Lab4.Enums;
using INET.Lab4.Models.Ports;

namespace INET.Lab4
{
    public class DeviceFinderForCoinDispenserCube4 : DeviceFinder
    {
        public override string FindDevice(DeviceModel model)
        {
            var port = new PortForCoinDispenserCube4();
            return Find(port);
        }
    }
}
