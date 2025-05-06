using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكيان يمثل النقدية في البنك للفرع ويحتوي على جميع خصائص النقدية في البنوك للفروع
/// </summary>
public class CashAtBankBranch : Entity<CashAtBankBranchId>
{

    private CashAtBankBranch() { }

    public CashAtBankBranch(CashAtBankBranchId id, decimal? branchBankNumber)
    {
        Id = id;
        BranchBankNumber = branchBankNumber;
    }

    /// <summary>
    /// المعرف الفريد للنقدية في البنك للفرع
    /// </summary>
    public CashAtBankBranchId Id { get; private set; }

    /// <summary>
    /// رقم البنك للفرع
    /// </summary>
    public decimal? BranchBankNumber { get; private set; }

    /// <summary>
    /// كود الحساب
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// الرصيد الافتتاحي بالعملة المحلية
    /// </summary>
    public decimal? OpenBalanceLocal { get; private set; }

    /// <summary>
    /// الرصيد الافتتاحي بالعملة الأجنبية
    /// </summary>
    public decimal? OpenBalanceForeign { get; private set; }

    /// <summary>
    /// الرصيد الحالي بالعملة المحلية
    /// </summary>
    public decimal? CurrBalL { get; private set; }

    /// <summary>
    /// الرصيد الحالي بالعملة الأجنبية
    /// </summary>
    public decimal? CurrBalF { get; private set; }

    /// <summary>
    /// علم التعطيل
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// تاريخ التعطيل
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع البنك النقدي (متعدد إلى واحد)
    /// </summary>
    public BankCash BankCash { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

