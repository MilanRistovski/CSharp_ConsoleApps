using System;
using System.Collections.Generic;
using System.Text;

namespace atm
{
    public interface IDeposit
    {
        void PlaceDeposit(BankAccount bankAccount);
    }
}
