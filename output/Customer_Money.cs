using System;

namespace ERP_Pro.Domain.ERP.Sales & Customers.ValueObjects
{
    public record Money
    {
    public decimal UseCalculateColumnAmount { get; }
    public decimal UseCalculateCommissionLevelPriceFlag { get; }
    public int UseCalculateTaxFreeQuantity { get; }
    public int UsePurchaseInvoiceCalculateTaxFreeQuantity { get; }
    public decimal UsePriceWarehouseTransferReceiveCost { get; }
    public int VatAmountDiscountMaster { get; }
    public int WeightCalculateQuantityByIncludePrice { get; }
    public decimal WeightPriceForceLength { get; }
    public decimal SaleRateForeignIncomeDegree { get; }
    public decimal SocialClassNoPanAmount { get; }
    public decimal SocialClassPanAmount { get; }
    public int ServiceAccountRate { get; }
    public decimal ServiceAmount { get; }
    public int ShowStockCostInQuantityDiscountFreeQuantity { get; }
    public int ShowAmountQuantityStaticArabicReport { get; }
    public decimal LoadAmountLocalLimit { get; }
    public string MethodVatCalculationItemUsed { get; }
    public decimal NetIncomeAmount { get; }
    public int AccountCurrencyAmount { get; }
    public int AccountInvoiceCurrencyAmount { get; }
    public int AccountAmount { get; }
    public int AccountAmountForeign { get; }
    public int AccountRate { get; }
    public int AdditionalDiscountAmountDetail { get; }
    public int AdditionalDiscountAmountMaster { get; }
    public int AdditionalDiscountAmountMasterPrevious { get; }
    public decimal AllowChangeDeliveryServiceAmount { get; }
    public int AmountForeignDiscountMovement { get; }
    public int AmountLocalDiscountMovement { get; }
    public int AccountsPayableItemChargeCalculationAmountType { get; }
    public decimal CalcInsuranceLoadAmountMethod { get; }
    public string CalcTaxAdvancePayment { get; }
    public int CalcTaxDiscount2 { get; }
    public int CalcTaxDiscount3 { get; }
    public int CalcTaxFreeQuantityFlag { get; }
    public bool CalcTaxInsuranceCompanyFlag { get; }
    public string CalcTaxType { get; }
    public int CalcTypeNumberTax { get; }
    public decimal CalcVatPriceType { get; }
    public decimal IncomeAmount { get; }
    public decimal IncomeCost { get; }
    public decimal IncomeNetAmount { get; }
    public decimal InsuranceLimitAmountLocalDocument { get; }
    public int ItemDiscountAmount { get; }
    public decimal ItemLastIncomePrice { get; }
    public decimal LetterCreditAmount { get; }
    public int LetterCreditCostTypeNumber { get; }
    public decimal LetterCreditCreditAmount { get; }
    public decimal LetterCreditExpenseAmount { get; }
    public decimal LetterCreditExpenseAmountForeign { get; }
    public decimal LetterCreditExpenseRate { get; }
    public decimal LetterCreditOpenAmount { get; }
    public decimal LetterCreditRate { get; }
    public decimal LetterCreditRotateAmount { get; }
    public decimal LimitAmountLocalChronicDocument { get; }
    public decimal LimitAmountLocalNetDocument { get; }
    public decimal LimitAmountLocalOutNetDocument { get; }
    public decimal LimitAmountNetLocalYear { get; }
    public int BillAccountAmount { get; }
    public decimal BalanceAmount { get; }
    public decimal BalanceAmountManual { get; }
    public decimal CalculateMeasurePrice { get; }
    public decimal CalculateVatAmountType { get; }
    public int CalculateVatAmountTypeAccountsPayable { get; }
    public int CheckLimitPriceMinusDiscountSalesInvoice { get; }
    public decimal PointAmountCalculationType { get; }
    public decimal PointReplaceAmount { get; }
    public int PostTaxDueAccountCode { get; }
    public decimal PriceIncludeVatServiceItem { get; }
    public int ForceDifferenceDiscountAfterVatAccount { get; }
    public decimal SourceIncomeRate { get; }
    public int StockAccountRate { get; }
    public decimal TotalNetIncomeAmount { get; }
    public decimal TransactionNotReceivedAmount { get; }

        private Money()
        {
            // Required by EF Core
        }

        private Money(decimal usecalculatecolumnamount, decimal usecalculatecommissionlevelpriceflag, int usecalculatetaxfreequantity, int usepurchaseinvoicecalculatetaxfreequantity, decimal usepricewarehousetransferreceivecost, int vatamountdiscountmaster, int weightcalculatequantitybyincludeprice, decimal weightpriceforcelength, decimal salerateforeignincomedegree, decimal socialclassnopanamount, decimal socialclasspanamount, int serviceaccountrate, decimal serviceamount, int showstockcostinquantitydiscountfreequantity, int showamountquantitystaticarabicreport, decimal loadamountlocallimit, string methodvatcalculationitemused, decimal netincomeamount, int accountcurrencyamount, int accountinvoicecurrencyamount, int accountamount, int accountamountforeign, int accountrate, int additionaldiscountamountdetail, int additionaldiscountamountmaster, int additionaldiscountamountmasterprevious, decimal allowchangedeliveryserviceamount, int amountforeigndiscountmovement, int amountlocaldiscountmovement, int accountspayableitemchargecalculationamounttype, decimal calcinsuranceloadamountmethod, string calctaxadvancepayment, int calctaxdiscount2, int calctaxdiscount3, int calctaxfreequantityflag, bool calctaxinsurancecompanyflag, string calctaxtype, int calctypenumbertax, decimal calcvatpricetype, decimal incomeamount, decimal incomecost, decimal incomenetamount, decimal insurancelimitamountlocaldocument, int itemdiscountamount, decimal itemlastincomeprice, decimal lettercreditamount, int lettercreditcosttypenumber, decimal lettercreditcreditamount, decimal lettercreditexpenseamount, decimal lettercreditexpenseamountforeign, decimal lettercreditexpenserate, decimal lettercreditopenamount, decimal lettercreditrate, decimal lettercreditrotateamount, decimal limitamountlocalchronicdocument, decimal limitamountlocalnetdocument, decimal limitamountlocaloutnetdocument, decimal limitamountnetlocalyear, int billaccountamount, decimal balanceamount, decimal balanceamountmanual, decimal calculatemeasureprice, decimal calculatevatamounttype, int calculatevatamounttypeaccountspayable, int checklimitpriceminusdiscountsalesinvoice, decimal pointamountcalculationtype, decimal pointreplaceamount, int posttaxdueaccountcode, decimal priceincludevatserviceitem, int forcedifferencediscountaftervataccount, decimal sourceincomerate, int stockaccountrate, decimal totalnetincomeamount, decimal transactionnotreceivedamount)
        {
        UseCalculateColumnAmount = usecalculatecolumnamount;
        UseCalculateCommissionLevelPriceFlag = usecalculatecommissionlevelpriceflag;
        UseCalculateTaxFreeQuantity = usecalculatetaxfreequantity;
        UsePurchaseInvoiceCalculateTaxFreeQuantity = usepurchaseinvoicecalculatetaxfreequantity;
        UsePriceWarehouseTransferReceiveCost = usepricewarehousetransferreceivecost;
        VatAmountDiscountMaster = vatamountdiscountmaster;
        WeightCalculateQuantityByIncludePrice = weightcalculatequantitybyincludeprice;
        WeightPriceForceLength = weightpriceforcelength;
        SaleRateForeignIncomeDegree = salerateforeignincomedegree;
        SocialClassNoPanAmount = socialclassnopanamount;
        SocialClassPanAmount = socialclasspanamount;
        ServiceAccountRate = serviceaccountrate;
        ServiceAmount = serviceamount;
        ShowStockCostInQuantityDiscountFreeQuantity = showstockcostinquantitydiscountfreequantity;
        ShowAmountQuantityStaticArabicReport = showamountquantitystaticarabicreport;
        LoadAmountLocalLimit = loadamountlocallimit;
        MethodVatCalculationItemUsed = methodvatcalculationitemused;
        NetIncomeAmount = netincomeamount;
        AccountCurrencyAmount = accountcurrencyamount;
        AccountInvoiceCurrencyAmount = accountinvoicecurrencyamount;
        AccountAmount = accountamount;
        AccountAmountForeign = accountamountforeign;
        AccountRate = accountrate;
        AdditionalDiscountAmountDetail = additionaldiscountamountdetail;
        AdditionalDiscountAmountMaster = additionaldiscountamountmaster;
        AdditionalDiscountAmountMasterPrevious = additionaldiscountamountmasterprevious;
        AllowChangeDeliveryServiceAmount = allowchangedeliveryserviceamount;
        AmountForeignDiscountMovement = amountforeigndiscountmovement;
        AmountLocalDiscountMovement = amountlocaldiscountmovement;
        AccountsPayableItemChargeCalculationAmountType = accountspayableitemchargecalculationamounttype;
        CalcInsuranceLoadAmountMethod = calcinsuranceloadamountmethod;
        CalcTaxAdvancePayment = calctaxadvancepayment;
        CalcTaxDiscount2 = calctaxdiscount2;
        CalcTaxDiscount3 = calctaxdiscount3;
        CalcTaxFreeQuantityFlag = calctaxfreequantityflag;
        CalcTaxInsuranceCompanyFlag = calctaxinsurancecompanyflag;
        CalcTaxType = calctaxtype;
        CalcTypeNumberTax = calctypenumbertax;
        CalcVatPriceType = calcvatpricetype;
        IncomeAmount = incomeamount;
        IncomeCost = incomecost;
        IncomeNetAmount = incomenetamount;
        InsuranceLimitAmountLocalDocument = insurancelimitamountlocaldocument;
        ItemDiscountAmount = itemdiscountamount;
        ItemLastIncomePrice = itemlastincomeprice;
        LetterCreditAmount = lettercreditamount;
        LetterCreditCostTypeNumber = lettercreditcosttypenumber;
        LetterCreditCreditAmount = lettercreditcreditamount;
        LetterCreditExpenseAmount = lettercreditexpenseamount;
        LetterCreditExpenseAmountForeign = lettercreditexpenseamountforeign;
        LetterCreditExpenseRate = lettercreditexpenserate;
        LetterCreditOpenAmount = lettercreditopenamount;
        LetterCreditRate = lettercreditrate;
        LetterCreditRotateAmount = lettercreditrotateamount;
        LimitAmountLocalChronicDocument = limitamountlocalchronicdocument;
        LimitAmountLocalNetDocument = limitamountlocalnetdocument;
        LimitAmountLocalOutNetDocument = limitamountlocaloutnetdocument;
        LimitAmountNetLocalYear = limitamountnetlocalyear;
        BillAccountAmount = billaccountamount;
        BalanceAmount = balanceamount;
        BalanceAmountManual = balanceamountmanual;
        CalculateMeasurePrice = calculatemeasureprice;
        CalculateVatAmountType = calculatevatamounttype;
        CalculateVatAmountTypeAccountsPayable = calculatevatamounttypeaccountspayable;
        CheckLimitPriceMinusDiscountSalesInvoice = checklimitpriceminusdiscountsalesinvoice;
        PointAmountCalculationType = pointamountcalculationtype;
        PointReplaceAmount = pointreplaceamount;
        PostTaxDueAccountCode = posttaxdueaccountcode;
        PriceIncludeVatServiceItem = priceincludevatserviceitem;
        ForceDifferenceDiscountAfterVatAccount = forcedifferencediscountaftervataccount;
        SourceIncomeRate = sourceincomerate;
        StockAccountRate = stockaccountrate;
        TotalNetIncomeAmount = totalnetincomeamount;
        TransactionNotReceivedAmount = transactionnotreceivedamount;
        }

        public static Money Create(decimal usecalculatecolumnamount, decimal usecalculatecommissionlevelpriceflag, int usecalculatetaxfreequantity, int usepurchaseinvoicecalculatetaxfreequantity, decimal usepricewarehousetransferreceivecost, int vatamountdiscountmaster, int weightcalculatequantitybyincludeprice, decimal weightpriceforcelength, decimal salerateforeignincomedegree, decimal socialclassnopanamount, decimal socialclasspanamount, int serviceaccountrate, decimal serviceamount, int showstockcostinquantitydiscountfreequantity, int showamountquantitystaticarabicreport, decimal loadamountlocallimit, string methodvatcalculationitemused, decimal netincomeamount, int accountcurrencyamount, int accountinvoicecurrencyamount, int accountamount, int accountamountforeign, int accountrate, int additionaldiscountamountdetail, int additionaldiscountamountmaster, int additionaldiscountamountmasterprevious, decimal allowchangedeliveryserviceamount, int amountforeigndiscountmovement, int amountlocaldiscountmovement, int accountspayableitemchargecalculationamounttype, decimal calcinsuranceloadamountmethod, string calctaxadvancepayment, int calctaxdiscount2, int calctaxdiscount3, int calctaxfreequantityflag, bool calctaxinsurancecompanyflag, string calctaxtype, int calctypenumbertax, decimal calcvatpricetype, decimal incomeamount, decimal incomecost, decimal incomenetamount, decimal insurancelimitamountlocaldocument, int itemdiscountamount, decimal itemlastincomeprice, decimal lettercreditamount, int lettercreditcosttypenumber, decimal lettercreditcreditamount, decimal lettercreditexpenseamount, decimal lettercreditexpenseamountforeign, decimal lettercreditexpenserate, decimal lettercreditopenamount, decimal lettercreditrate, decimal lettercreditrotateamount, decimal limitamountlocalchronicdocument, decimal limitamountlocalnetdocument, decimal limitamountlocaloutnetdocument, decimal limitamountnetlocalyear, int billaccountamount, decimal balanceamount, decimal balanceamountmanual, decimal calculatemeasureprice, decimal calculatevatamounttype, int calculatevatamounttypeaccountspayable, int checklimitpriceminusdiscountsalesinvoice, decimal pointamountcalculationtype, decimal pointreplaceamount, int posttaxdueaccountcode, decimal priceincludevatserviceitem, int forcedifferencediscountaftervataccount, decimal sourceincomerate, int stockaccountrate, decimal totalnetincomeamount, decimal transactionnotreceivedamount)
        {
            // Add validation logic here
            return new Money(usecalculatecolumnamount, usecalculatecommissionlevelpriceflag, usecalculatetaxfreequantity, usepurchaseinvoicecalculatetaxfreequantity, usepricewarehousetransferreceivecost, vatamountdiscountmaster, weightcalculatequantitybyincludeprice, weightpriceforcelength, salerateforeignincomedegree, socialclassnopanamount, socialclasspanamount, serviceaccountrate, serviceamount, showstockcostinquantitydiscountfreequantity, showamountquantitystaticarabicreport, loadamountlocallimit, methodvatcalculationitemused, netincomeamount, accountcurrencyamount, accountinvoicecurrencyamount, accountamount, accountamountforeign, accountrate, additionaldiscountamountdetail, additionaldiscountamountmaster, additionaldiscountamountmasterprevious, allowchangedeliveryserviceamount, amountforeigndiscountmovement, amountlocaldiscountmovement, accountspayableitemchargecalculationamounttype, calcinsuranceloadamountmethod, calctaxadvancepayment, calctaxdiscount2, calctaxdiscount3, calctaxfreequantityflag, calctaxinsurancecompanyflag, calctaxtype, calctypenumbertax, calcvatpricetype, incomeamount, incomecost, incomenetamount, insurancelimitamountlocaldocument, itemdiscountamount, itemlastincomeprice, lettercreditamount, lettercreditcosttypenumber, lettercreditcreditamount, lettercreditexpenseamount, lettercreditexpenseamountforeign, lettercreditexpenserate, lettercreditopenamount, lettercreditrate, lettercreditrotateamount, limitamountlocalchronicdocument, limitamountlocalnetdocument, limitamountlocaloutnetdocument, limitamountnetlocalyear, billaccountamount, balanceamount, balanceamountmanual, calculatemeasureprice, calculatevatamounttype, calculatevatamounttypeaccountspayable, checklimitpriceminusdiscountsalesinvoice, pointamountcalculationtype, pointreplaceamount, posttaxdueaccountcode, priceincludevatserviceitem, forcedifferencediscountaftervataccount, sourceincomerate, stockaccountrate, totalnetincomeamount, transactionnotreceivedamount);
        }
    }
}