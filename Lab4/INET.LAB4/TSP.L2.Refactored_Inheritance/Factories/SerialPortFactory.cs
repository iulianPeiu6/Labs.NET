using INET.Lab4.Enums;
using INET.Lab4.Models.Ports;
using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace INET.Lab4
{
    public class SerialPortFactory
    {
        private IDictionary<DeviceModel, SerialPort> serialPortMapper;

        public SerialPortFactory()
        {
            serialPortMapper = new Dictionary<DeviceModel, SerialPort>();
            serialPortMapper.Add(DeviceModel.BillAccepterCashCode, new PortForBillAccepterCashCode());
            serialPortMapper.Add(DeviceModel.BillDispenserEcdm, new PortForBillDispenserEcdm());
            serialPortMapper.Add(DeviceModel.CoinDispenserCube4, new PortForCoinDispenserCube4());
            serialPortMapper.Add(DeviceModel.CoinAccepterNri, new PortForCoinAccepterNri());
            serialPortMapper.Add(DeviceModel.CoinDispsenerSch2, new PortForCoinDispsenerSch2());
        }

        public SerialPort CreateSerialPort(DeviceModel model)
        {
            try
            {
                return serialPortMapper[model];
            }
            catch (KeyNotFoundException)
            {
                throw new ArgumentException($"Unknown model: {model}.");
            }
        }
    }
}
