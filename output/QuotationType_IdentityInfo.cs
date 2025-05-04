using System;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.ValueObjects
{
    public record IdentityInfo
    {
    public int RequestSide { get; }
    public int AccountsPayablePurchaseRequestSerial { get; }
    public string ArQuotationSerial { get; }
    public int ArRequestAdditionalDiscountSerial { get; }
    public int IdentifyChequeNumber { get; }
    public DateTime QuotationExpireDate { get; }

        private IdentityInfo()
        {
            // Required by EF Core
        }

        private IdentityInfo(int requestside, int accountspayablepurchaserequestserial, string arquotationserial, int arrequestadditionaldiscountserial, int identifychequenumber, DateTime quotationexpiredate)
        {
        RequestSide = requestside;
        AccountsPayablePurchaseRequestSerial = accountspayablepurchaserequestserial;
        ArQuotationSerial = arquotationserial;
        ArRequestAdditionalDiscountSerial = arrequestadditionaldiscountserial;
        IdentifyChequeNumber = identifychequenumber;
        QuotationExpireDate = quotationexpiredate;
        }

        public static IdentityInfo Create(int requestside, int accountspayablepurchaserequestserial, string arquotationserial, int arrequestadditionaldiscountserial, int identifychequenumber, DateTime quotationexpiredate)
        {
            // Add validation logic here
            return new IdentityInfo(requestside, accountspayablepurchaserequestserial, arquotationserial, arrequestadditionaldiscountserial, identifychequenumber, quotationexpiredate);
        }
    }
}