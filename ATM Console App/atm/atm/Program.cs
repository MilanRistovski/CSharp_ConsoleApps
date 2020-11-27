using System;

namespace atm
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyBankATM atm = new MoneyBankATM();
            atm.Initialization();
            atm.Execute();
        }
    }
}
