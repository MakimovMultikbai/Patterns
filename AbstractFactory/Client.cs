using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Client
    {
        private ITransferFactory _transferFactory;

        public Client(ITransferFactory transferFactory)
        {
            _transferFactory = transferFactory;
        }

        public void MakeTransfer(int amount)
        {
            var transfer = _transferFactory.CreateTransfer();
            transfer.ExecuteTransfer(amount);
        }
    }
}
