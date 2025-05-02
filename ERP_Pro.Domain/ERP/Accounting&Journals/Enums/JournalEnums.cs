namespace ERP_Pro.Domain.ERP.Accounting&Journals.Enums
{
    /// <summary> نوع الحساب </summary>
    public enum AccountType
    {
        /// <summary> ميزانية </summary>
        Balance = 1,
        /// <summary> دخل </summary>
        Income = 2,
        /// <summary> مصروف </summary>
        Expense = 3,
        /// <summary> خارج الميزانية </summary>
        OffBalance = 4
    }

    /// <summary> تصنيف الحساب </summary>
    public enum AccountClassification
    {
        /// <summary> أصول </summary>
        Assets = 1,
        /// <summary> خصوم </summary>
        Liabilities = 2,
        /// <summary> حقوق ملكية </summary>
        Equity = 3,
        /// <summary> إيرادات </summary>
        Revenue = 4,
        /// <summary> مصروفات </summary>
        Expenses = 5,
        /// <summary> خارج الميزانية </summary>
        OffBalance = 6
    }

    /// <summary> نوع التقرير </summary>
    public enum AccountReportType
    {
        /// <summary> ميزانية عمومية </summary>
        BalanceSheet = 1,
        /// <summary> قائمة دخل </summary>
        IncomeStatement = 2,
        /// <summary> قائمة تدفقات نقدية </summary>
        CashFlow = 3,
        /// <summary> خارج الميزانية </summary>
        OffBalance = 4
    }

    /// <summary> نوع المصروف </summary>
    public enum AccountExpenseType
    {
        /// <summary> مصروف تشغيلي </summary>
        Operating = 1,
        /// <summary> مصروف إداري </summary>
        Administrative = 2,
        /// <summary> مصروف تسويقي </summary>
        Marketing = 3,
        /// <summary> مصروف تمويلي </summary>
        Financial = 4,
        /// <summary> مصروف آخر </summary>
        Other = 5
    }

    /// <summary> نوع التحليل </summary>
    public enum AccountAnalysis
    {
        /// <summary> عميل </summary>
        Customer = 1,
        /// <summary> مورد </summary>
        Vendor = 2,
        /// <summary> موظف </summary>
        Employee = 3,
        /// <summary> مشروع </summary>
        Project = 4,
        /// <summary> مركز تكلفة </summary>
        CostCenter = 5,
        /// <summary> فرع </summary>
        Branch = 6,
        /// <summary> قسم </summary>
        Department = 7,
        /// <summary> آخر </summary>
        Other = 8
    }

    /// <summary> نوع الحساب التفصيلي </summary>
    public enum AccountDetailType
    {
        /// <summary> عميل </summary>
        Customer = 1,
        /// <summary> مورد </summary>
        Vendor = 2,
        /// <summary> موظف </summary>
        Employee = 3,
        /// <summary> مشروع </summary>
        Project = 4,
        /// <summary> مركز تكلفة </summary>
        CostCenter = 5,
        /// <summary> فرع </summary>
        Branch = 6,
        /// <summary> قسم </summary>
        Department = 7,
        /// <summary> آخر </summary>
        Other = 8
    }

    /// <summary> نوع القيد </summary>
    public enum JournalType
    {
        /// <summary> قيد عادي </summary>
        Normal = 1,
        /// <summary> قيد افتتاحي </summary>
        Opening = 2,
        /// <summary> قيد إقفال </summary>
        Closing = 3,
        /// <summary> قيد تسوية </summary>
        Adjustment = 4,
        /// <summary> قيد عكسي </summary>
        Reversal = 5,
        /// <summary> قيد دوري </summary>
        Periodic = 6,
        /// <summary> قيد تلقائي </summary>
        Automatic = 7,
        /// <summary> قيد يدوي </summary>
        Manual = 8,
        /// <summary> قيد تحويل </summary>
        Transfer = 9,
        /// <summary> قيد تصحيح </summary>
        Correction = 10
    }

    /// <summary> نوع المستند </summary>
    public enum DocumentType
    {
        /// <summary> فاتورة مبيعات </summary>
        SalesInvoice = 1,
        /// <summary> فاتورة مشتريات </summary>
        PurchaseInvoice = 2,
        /// <summary> سند قبض </summary>
        ReceiptVoucher = 3,
        /// <summary> سند صرف </summary>
        PaymentVoucher = 4,
        /// <summary> سند قيد </summary>
        JournalVoucher = 5,
        /// <summary> سند تحويل </summary>
        TransferVoucher = 6,
        /// <summary> سند تسوية </summary>
        AdjustmentVoucher = 7,
        /// <summary> سند افتتاحي </summary>
        OpeningVoucher = 8,
        /// <summary> سند إقفال </summary>
        ClosingVoucher = 9,
        /// <summary> سند عكسي </summary>
        ReversalVoucher = 10
    }
} 