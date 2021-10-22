using INET.Lab4.Enums;
using INET.Lab4.Models;
using System;
using System.Collections.Generic;

namespace INET.Lab4
{
    public class BankTerminalFactory
    {
        private IDictionary<BankTerminalModel, IBankTerminal> bankTerminalMapper;

        public BankTerminalFactory()
        {
            bankTerminalMapper.Add(BankTerminalModel.Brp, new BrpTerminal());
            bankTerminalMapper.Add(BankTerminalModel.Dcp, new DcpTerminal());
        }

        public IBankTerminal CreateBankTerminal(BankTerminalModel model)
        {
            try
            {
                return bankTerminalMapper[model];
            }
            catch (KeyNotFoundException)
            {
                throw new ArgumentException("Unknown model");
            }
        }
    }
}