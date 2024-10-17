using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BankTransfer : ITransfer
    {
        public void ExecuteTransfer(int amount)
        {
            Console.WriteLine($"Выполнен перевод в банк на сумму: {amount}");
        }
    }
}
