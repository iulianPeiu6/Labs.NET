using System.IO.Ports;

namespace INET.Lab4.Models.Ports
{
    public class PortForBillAccepterCashCode : SerialPort
    {
        public PortForBillAccepterCashCode()
        {
            BaudRate = 9600;
            Parity = Parity.Even;
            Handshake = Handshake.RequestToSend;
        }
    }
}
