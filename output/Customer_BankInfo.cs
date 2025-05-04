using System;

namespace ERP_Pro.Domain.ERP.Sales & Customers.ValueObjects
{
    public record BankInfo
    {
    public int UseBankDepositAccountIntermediate { get; }
    public int AccountBankCode { get; }
    public int BankAccountCode { get; }
    public int BankAccountType { get; }

        private BankInfo()
        {
            // Required by EF Core
        }

        private BankInfo(int usebankdepositaccountintermediate, int accountbankcode, int bankaccountcode, int bankaccounttype)
        {
        UseBankDepositAccountIntermediate = usebankdepositaccountintermediate;
        AccountBankCode = accountbankcode;
        BankAccountCode = bankaccountcode;
        BankAccountType = bankaccounttype;
        }

        public static BankInfo Create(int usebankdepositaccountintermediate, int accountbankcode, int bankaccountcode, int bankaccounttype)
        {
            // Add validation logic here
            return new BankInfo(usebankdepositaccountintermediate, accountbankcode, bankaccountcode, bankaccounttype);
        }
    }
}