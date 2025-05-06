using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تفاصيل نوع قيد اليومية ويحتوي على جميع خصائص تفاصيل أنواع قيود اليومية
/// </summary>
public class JournalVoucherTypeDetail : Entity<JournalVoucherTypeDetailId>
{

    private JournalVoucherTypeDetail() { }

    public JournalVoucherTypeDetail(JournalVoucherTypeDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// معرف فريد لتفاصيل نوع قيد اليومية
    /// </summary>
    public JournalVoucherTypeDetailId Id { get; private set; }

    /// <summary>
    /// علم إضافي
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// علم العرض
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع المستخدم (متعدد إلى واحد)
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع نوع قيد اليومية (متعدد إلى واحد)
    /// </summary>
    public JournalVoucherType JournalVoucherType { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

