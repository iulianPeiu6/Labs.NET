using INET.Lab4.Enums;
using System.IO.Ports;

namespace INET.Lab4.Abstracts
{
    public abstract class DeviceFinder
    {
        public abstract string FindDevice(DeviceModel model);

        protected string Find(SerialPort port)
        {
            string[] names = SerialPort.GetPortNames();
            foreach (string name in names)
            {
                port.Write("special code");
                if (port.ReadByte() == 0)
                    return name;
            }
            return null;
        }
    }
}
