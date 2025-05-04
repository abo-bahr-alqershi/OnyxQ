using System;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.ValueObjects
{
    public record IdentityInfo
    {
    public int RequestSide { get; }
    public int AccountsPayablePurchaseRequestSerial { get; }
    public string ArSerial { get; }
    public int ArRequestAdditionalDiscountSerial { get; }
    public int IdentifyChequeNumber { get; }
    public DateTime ExpireDate { get; }

        private IdentityInfo()
        {
            // Required by EF Core
        }

        private IdentityInfo(int requestside, int accountspayablepurchaserequestserial, string arserial, int arrequestadditionaldiscountserial, int identifychequenumber, DateTime expiredate)
        {
        RequestSide = requestside;
        AccountsPayablePurchaseRequestSerial = accountspayablepurchaserequestserial;
        ArSerial = arserial;
        ArRequestAdditionalDiscountSerial = arrequestadditionaldiscountserial;
        IdentifyChequeNumber = identifychequenumber;
        ExpireDate = expiredate;
        }

        public static IdentityInfo Create(int requestside, int accountspayablepurchaserequestserial, string arserial, int arrequestadditionaldiscountserial, int identifychequenumber, DateTime expiredate)
        {
            // Add validation logic here
            return new IdentityInfo(requestside, accountspayablepurchaserequestserial, arserial, arrequestadditionaldiscountserial, identifychequenumber, expiredate);
        }
    }
}