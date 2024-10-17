namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var bank = new Client(new BankTransferFactory());
            bank.MakeTransfer(100);

            var qiwi = new Client(new QIWITransferFactory());
            qiwi.MakeTransfer(150);
        }
    }
}
