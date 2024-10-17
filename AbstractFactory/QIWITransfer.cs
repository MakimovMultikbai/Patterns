using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class QIWITransfer : ITransfer
    {
        public void ExecuteTransfer(int amount)
        {
            Console.WriteLine($"Выполнен перевод на QIWI на сумму: {amount}");
        }
    }
}
