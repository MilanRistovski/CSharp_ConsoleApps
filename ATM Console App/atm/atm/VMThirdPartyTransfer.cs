using System;
using System.Collections.Generic;
using System.Text;

namespace atm
{
    public class VMThirdPartyTransfer
    {
        public decimal TransferAmount { get; set; }
        public Int64 RecipientBankAccountNumber { get; set; }

        public string RecipientBankAccountName { get; set; }
    }
}
