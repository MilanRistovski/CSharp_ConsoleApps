using System;
using System.Collections.Generic;
using System.Text;

namespace atm
{
    public interface IBalance
    {
        void CheckBalance(BankAccount bankAccount);
    }
}
