using System;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.ValueObjects
{
    public record Money
    {
    public decimal UseRequestModifyPrice { get; }
    public decimal RequestAmount { get; }
    public string ReturnRequestCurrency { get; }
    public decimal ReturnRequestRate { get; }
    public decimal QuotationAmount { get; }

        private Money()
        {
            // Required by EF Core
        }

        private Money(decimal userequestmodifyprice, decimal requestamount, string returnrequestcurrency, decimal returnrequestrate, decimal quotationamount)
        {
        UseRequestModifyPrice = userequestmodifyprice;
        RequestAmount = requestamount;
        ReturnRequestCurrency = returnrequestcurrency;
        ReturnRequestRate = returnrequestrate;
        QuotationAmount = quotationamount;
        }

        public static Money Create(decimal userequestmodifyprice, decimal requestamount, string returnrequestcurrency, decimal returnrequestrate, decimal quotationamount)
        {
            // Add validation logic here
            return new Money(userequestmodifyprice, requestamount, returnrequestcurrency, returnrequestrate, quotationamount);
        }
    }
}