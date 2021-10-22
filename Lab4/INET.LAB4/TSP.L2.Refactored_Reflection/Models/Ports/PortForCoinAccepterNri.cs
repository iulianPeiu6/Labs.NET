using System.IO.Ports;

namespace INET.Lab4.Models.Ports
{
    public class PortForCoinAccepterNri : SerialPort
    {
        public PortForCoinAccepterNri()
        {
            BaudRate = 9600;
            Parity = Parity.Space;
            Handshake = Handshake.None;
        }
    }
}
