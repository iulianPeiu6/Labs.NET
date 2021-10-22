using System.IO.Ports;

namespace INET.Lab4.Models.Ports
{
    public class PortForBillDispenserEcdm : SerialPort
    {
        public PortForBillDispenserEcdm()
        {
            BaudRate = 4800;
            Parity = Parity.Mark;
            Handshake = Handshake.RequestToSendXOnXOff;
        }
    }
}
