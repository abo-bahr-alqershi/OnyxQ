using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// AssociationTransaction Entity
/// الكلاس يمثل معاملة الجمعية ويحتوي على جميع خصائص معاملات الجمعيات
/// </summary>
public class AssociationTransaction : Entity<AssociationTransactionId>
{

    private AssociationTransaction() { }

    public AssociationTransaction(AssociationTransactionId id, decimal? assessmentNumber)
    {
        Id = id;
        AssessmentNumber = assessmentNumber;
    }

    /// <summary>
    /// The unique identifier for the AssociationTransaction
    /// المعرف الفريد لـ AssociationTransaction
    /// معرف فريد لمعاملة الجمعية
    /// </summary>
    public AssociationTransactionId Id { get; private set; }

    /// <summary>
    /// BillNumber of the AssociationTransaction
    /// BillNumber الخاص بـ AssociationTransaction
    /// رقم الفاتورة
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// AssessmentNumber of the AssociationTransaction
    /// AssessmentNumber الخاص بـ AssociationTransaction
    /// رقم التقييم
    /// </summary>
    public decimal? AssessmentNumber { get; private set; }

    /// <summary>
    /// AccountCode of the AssociationTransaction
    /// AccountCode الخاص بـ AssociationTransaction
    /// كود الحساب
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AssociationTransaction
    /// AccountDetailCode الخاص بـ AssociationTransaction
    /// كود تفاصيل الحساب
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AssociationTransaction
    /// AccountDetailType الخاص بـ AssociationTransaction
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AssessmentAmount of the AssociationTransaction
    /// AssessmentAmount الخاص بـ AssociationTransaction
    /// مبلغ التقييم
    /// </summary>
    public decimal? AssessmentAmount { get; private set; }

    /// <summary>
    /// CostCenterCode of the AssociationTransaction
    /// CostCenterCode الخاص بـ AssociationTransaction
    /// كود مركز التكلفة
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AssociationTransaction
    /// ProjectNumber الخاص بـ AssociationTransaction
    /// رقم المشروع
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AssociationTransaction
    /// ActivityNumber الخاص بـ AssociationTransaction
    /// رقم النشاط
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// BillDate of the AssociationTransaction
    /// BillDate الخاص بـ AssociationTransaction
    /// تاريخ الفاتورة
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the AssociationTransaction
    /// ExternalPostFlag الخاص بـ AssociationTransaction
    /// علم الترحيل الخارجي
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AssociationTransaction
    /// CompanyNumberShort الخاص بـ AssociationTransaction
    /// رقم الشركة المختصر
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AssociationTransaction
    /// BranchNumber الخاص بـ AssociationTransaction
    /// رقم الفرع
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AssociationTransaction
    /// BranchYear الخاص بـ AssociationTransaction
    /// سنة الفرع
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AssociationTransaction
    /// BranchUser الخاص بـ AssociationTransaction
    /// مستخدم الفرع
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// علاقة مرجعية مع فاتورة الجمعية (متعدد إلى واحد)
    /// </summary>
    public BillMaster BillMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
