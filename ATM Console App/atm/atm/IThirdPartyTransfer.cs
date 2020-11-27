using System;
using System.Collections.Generic;
using System.Text;

namespace atm
{
    public interface IThirdPartyTransfer
    {
        void PerformThirdPartyTransfer(BankAccount bankAccount, VMThirdPartyTransfer vmThirdPartyTransfer);
    }
}
