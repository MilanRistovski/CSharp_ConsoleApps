using System;
using System.Collections.Generic;
using System.Text;

namespace atm
{
    interface ITransaction
    {
        void InsertTransaction(BankAccount bankAccount, Transaction transaction);
        void ViewTransaction(BankAccount bankAccount);
    }
}