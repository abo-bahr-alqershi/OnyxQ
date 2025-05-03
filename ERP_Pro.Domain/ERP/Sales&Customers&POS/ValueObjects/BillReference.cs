using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Sales&Customers.ValueObjects
{
    public class BillReference : ValueObject
    {
        public long? BillNo { get; private set; }
        public long? BillSer { get; private set; }
        public int? CashierNo { get; private set; }
        public long? CashBankNo { get; private set; }
        public long? ChequeNo { get; private set; }
        public string? NoteNo { get; private set; }

        private BillReference() { }

        public static BillReference Create(
            long? billNo = null,
            long? billSer = null,
            int? cashierNo = null,
            long? cashBankNo = null,
            long? chequeNo = null,
            string? noteNo = null)
        {
            return new BillReference
            {
                BillNo = billNo,
                BillSer = billSer,
                CashierNo = cashierNo,
                CashBankNo = cashBankNo,
                ChequeNo = chequeNo,
                NoteNo = noteNo
            };
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return BillNo ?? 0;
            yield return BillSer ?? 0;
            yield return CashierNo ?? 0;
            yield return CashBankNo ?? 0;
            yield return ChequeNo ?? 0;
            yield return NoteNo ?? string.Empty;
        }
    }
} 