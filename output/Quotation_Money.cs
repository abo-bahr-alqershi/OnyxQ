using System;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.ValueObjects
{
    public record Money
    {
    public decimal UseRequestModifyPrice { get; }
    public decimal RequestAmount { get; }
    public string ReturnRequestCurrency { get; }
    public decimal ReturnRequestRate { get; }
    public decimal Amount { get; }

        private Money()
        {
            // Required by EF Core
        }

        private Money(decimal userequestmodifyprice, decimal requestamount, string returnrequestcurrency, decimal returnrequestrate, decimal amount)
        {
        UseRequestModifyPrice = userequestmodifyprice;
        RequestAmount = requestamount;
        ReturnRequestCurrency = returnrequestcurrency;
        ReturnRequestRate = returnrequestrate;
        Amount = amount;
        }

        public static Money Create(decimal userequestmodifyprice, decimal requestamount, string returnrequestcurrency, decimal returnrequestrate, decimal amount)
        {
            // Add validation logic here
            return new Money(userequestmodifyprice, requestamount, returnrequestcurrency, returnrequestrate, amount);
        }
    }
}