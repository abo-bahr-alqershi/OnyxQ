using System;

namespace ERP_Pro.Domain.ERP.Sales & Customers.ValueObjects
{
    public record IdentityInfo
    {
    public int UseDiscountCardSale { get; }
    public int WebServiceUuid { get; }
    public int ReceiveInvoiceUserId { get; }
    public int NotAllowDeleteDocumentConnectedSerialNumber { get; }
    public int PaidDocumentNumber { get; }
    public int PaidDocumentSerial { get; }
    public int PaidDocumentType { get; }
    public int ApprovalReceivedUserId { get; }
    public int AccountsReceivableAdditionalDiscountSerial { get; }
    public string ArReceiptDocumentSerial { get; }
    public int ArRequestAdditionalDiscountSerial { get; }
    public int CalcPaidMethod { get; }
    public int CreditCardDocumentNumberReference { get; }
    public int CreditCardDocumentNumberReferenceSecond { get; }
    public int CreditCardDocumentNumberReferenceThird { get; }
    public string CreditCardDescriptionSecond { get; }
    public string CreditCardDescriptionThird { get; }
    public int CalculateAllSlides { get; }
    public string CardSecondAddress { get; }
    public int SalesInvoiceHideDiscountPercent { get; }

        private IdentityInfo()
        {
            // Required by EF Core
        }

        private IdentityInfo(int usediscountcardsale, int webserviceuuid, int receiveinvoiceuserid, int notallowdeletedocumentconnectedserialnumber, int paiddocumentnumber, int paiddocumentserial, int paiddocumenttype, int approvalreceiveduserid, int accountsreceivableadditionaldiscountserial, string arreceiptdocumentserial, int arrequestadditionaldiscountserial, int calcpaidmethod, int creditcarddocumentnumberreference, int creditcarddocumentnumberreferencesecond, int creditcarddocumentnumberreferencethird, string creditcarddescriptionsecond, string creditcarddescriptionthird, int calculateallslides, string cardsecondaddress, int salesinvoicehidediscountpercent)
        {
        UseDiscountCardSale = usediscountcardsale;
        WebServiceUuid = webserviceuuid;
        ReceiveInvoiceUserId = receiveinvoiceuserid;
        NotAllowDeleteDocumentConnectedSerialNumber = notallowdeletedocumentconnectedserialnumber;
        PaidDocumentNumber = paiddocumentnumber;
        PaidDocumentSerial = paiddocumentserial;
        PaidDocumentType = paiddocumenttype;
        ApprovalReceivedUserId = approvalreceiveduserid;
        AccountsReceivableAdditionalDiscountSerial = accountsreceivableadditionaldiscountserial;
        ArReceiptDocumentSerial = arreceiptdocumentserial;
        ArRequestAdditionalDiscountSerial = arrequestadditionaldiscountserial;
        CalcPaidMethod = calcpaidmethod;
        CreditCardDocumentNumberReference = creditcarddocumentnumberreference;
        CreditCardDocumentNumberReferenceSecond = creditcarddocumentnumberreferencesecond;
        CreditCardDocumentNumberReferenceThird = creditcarddocumentnumberreferencethird;
        CreditCardDescriptionSecond = creditcarddescriptionsecond;
        CreditCardDescriptionThird = creditcarddescriptionthird;
        CalculateAllSlides = calculateallslides;
        CardSecondAddress = cardsecondaddress;
        SalesInvoiceHideDiscountPercent = salesinvoicehidediscountpercent;
        }

        public static IdentityInfo Create(int usediscountcardsale, int webserviceuuid, int receiveinvoiceuserid, int notallowdeletedocumentconnectedserialnumber, int paiddocumentnumber, int paiddocumentserial, int paiddocumenttype, int approvalreceiveduserid, int accountsreceivableadditionaldiscountserial, string arreceiptdocumentserial, int arrequestadditionaldiscountserial, int calcpaidmethod, int creditcarddocumentnumberreference, int creditcarddocumentnumberreferencesecond, int creditcarddocumentnumberreferencethird, string creditcarddescriptionsecond, string creditcarddescriptionthird, int calculateallslides, string cardsecondaddress, int salesinvoicehidediscountpercent)
        {
            // Add validation logic here
            return new IdentityInfo(usediscountcardsale, webserviceuuid, receiveinvoiceuserid, notallowdeletedocumentconnectedserialnumber, paiddocumentnumber, paiddocumentserial, paiddocumenttype, approvalreceiveduserid, accountsreceivableadditionaldiscountserial, arreceiptdocumentserial, arrequestadditionaldiscountserial, calcpaidmethod, creditcarddocumentnumberreference, creditcarddocumentnumberreferencesecond, creditcarddocumentnumberreferencethird, creditcarddescriptionsecond, creditcarddescriptionthird, calculateallslides, cardsecondaddress, salesinvoicehidediscountpercent);
        }
    }
}