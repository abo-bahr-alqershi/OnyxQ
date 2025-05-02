using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects
{
    public class BankDocumentInfo : ValueObject
    {
        public string? BankImage { get; private set; }
        public string? ReceiptLetter { get; private set; }
        public string? PaymentLetter { get; private set; }
        public string? CheckPaymentInterimAccount { get; private set; }
        public int? ReportSample { get; private set; }
        public long? OutgoingCheckAutoSerial { get; private set; }
        public int? BankCode { get; private set; }

        private BankDocumentInfo() { }

        public static BankDocumentInfo Create(
            string? bankImage = null,
            string? receiptLetter = null,
            string? paymentLetter = null,
            string? checkPaymentInterimAccount = null,
            int? reportSample = null,
            long? outgoingCheckAutoSerial = null,
            int? bankCode = null)
        {
            return new BankDocumentInfo
            {
                BankImage = bankImage,
                ReceiptLetter = receiptLetter,
                PaymentLetter = paymentLetter,
                CheckPaymentInterimAccount = checkPaymentInterimAccount,
                ReportSample = reportSample,
                OutgoingCheckAutoSerial = outgoingCheckAutoSerial,
                BankCode = bankCode
            };
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return BankImage ?? string.Empty;
            yield return ReceiptLetter ?? string.Empty;
            yield return PaymentLetter ?? string.Empty;
            yield return CheckPaymentInterimAccount ?? string.Empty;
            yield return ReportSample ?? 0;
            yield return OutgoingCheckAutoSerial ?? 0;
            yield return BankCode ?? 0;
        }
    }
} 