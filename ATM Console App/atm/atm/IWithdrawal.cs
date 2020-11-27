using System;
using System.Collections.Generic;
using System.Text;

namespace atm
{
    public interface IWithdrawal
    {
        void MakeWithdrawal(BankAccount bankAccount);
    }
}
