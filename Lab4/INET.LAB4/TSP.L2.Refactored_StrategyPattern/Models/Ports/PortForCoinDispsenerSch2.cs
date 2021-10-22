using System.IO.Ports;

namespace INET.Lab4.Models.Ports
{
    public class PortForCoinDispsenerSch2 : SerialPort
    {
        public PortForCoinDispsenerSch2()
        {
            BaudRate = 4800;
            Parity = Parity.Even;
            Handshake = Handshake.None;
        }
    }
}
