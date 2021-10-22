using System.IO.Ports;

namespace INET.Lab4.Models.Ports
{
    public class PortForCoinDispenserCube4 : SerialPort
    {
        public PortForCoinDispenserCube4()
        {
            BaudRate = 19200;
            Parity = Parity.Odd;
            Handshake = Handshake.XOnXOff;
        }
    }
}
