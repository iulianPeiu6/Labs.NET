using INET.Lab4.Enums;
using System.IO.Ports;

namespace INET.Lab4
{
    public class DeviceFinder
    {
        public string FindDevice(DeviceModel model)
        {
            SerialPortFactory factory = new SerialPortFactory();
            try
            {
                var port = factory.CreateSerialPort(model);
                return Find(port);
            }
            catch
            {
                throw;
            }
        }

        private string Find(SerialPort port)
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
