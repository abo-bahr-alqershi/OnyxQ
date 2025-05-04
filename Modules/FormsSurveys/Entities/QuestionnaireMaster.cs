using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// QuestionnaireMaster Entity
/// </summary>
public class QuestionnaireMaster : Entity<QuestionnaireMasterId>
{
    private QuestionnaireMaster() { }

    /// <summary>
    /// The unique identifier for the QuestionnaireMaster
    /// المعرف الفريد لـ QuestionnaireMaster
    /// </summary>
    public QuestionnaireMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the QuestionnaireMaster
    /// DocNo الخاص بـ QuestionnaireMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the QuestionnaireMaster
    /// DocSer الخاص بـ QuestionnaireMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the QuestionnaireMaster
    /// DocDate الخاص بـ QuestionnaireMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the QuestionnaireMaster
    /// ReferenceNumber الخاص بـ QuestionnaireMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// RepCode of the QuestionnaireMaster
    /// RepCode الخاص بـ QuestionnaireMaster
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// DocDsc of the QuestionnaireMaster
    /// DocDsc الخاص بـ QuestionnaireMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// CCode of the QuestionnaireMaster
    /// CCode الخاص بـ QuestionnaireMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the QuestionnaireMaster
    /// ExternalPostFlag الخاص بـ QuestionnaireMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CName of the QuestionnaireMaster
    /// CName الخاص بـ QuestionnaireMaster
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// DocNoRef of the QuestionnaireMaster
    /// DocNoRef الخاص بـ QuestionnaireMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerExtrnl of the QuestionnaireMaster
    /// DocSerExtrnl الخاص بـ QuestionnaireMaster
    /// </summary>
    public string DocSerExtrnl { get; private set; }

    /// <summary>
    /// Field1 of the QuestionnaireMaster
    /// Field1 الخاص بـ QuestionnaireMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the QuestionnaireMaster
    /// Field2 الخاص بـ QuestionnaireMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the QuestionnaireMaster
    /// Field3 الخاص بـ QuestionnaireMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the QuestionnaireMaster
    /// Field4 الخاص بـ QuestionnaireMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the QuestionnaireMaster
    /// Field5 الخاص بـ QuestionnaireMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the QuestionnaireMaster
    /// Field6 الخاص بـ QuestionnaireMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the QuestionnaireMaster
    /// Field7 الخاص بـ QuestionnaireMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the QuestionnaireMaster
    /// Field8 الخاص بـ QuestionnaireMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the QuestionnaireMaster
    /// Field9 الخاص بـ QuestionnaireMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the QuestionnaireMaster
    /// Field10 الخاص بـ QuestionnaireMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the QuestionnaireMaster
    /// CompanyNumberShort الخاص بـ QuestionnaireMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the QuestionnaireMaster
    /// BranchNumber الخاص بـ QuestionnaireMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the QuestionnaireMaster
    /// BranchYear الخاص بـ QuestionnaireMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the QuestionnaireMaster
    /// BranchUser الخاص بـ QuestionnaireMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: QuestionnaireMaster to QuestionnaireDetail
    /// </summary>
    public IReadOnlyCollection<QuestionnaireDetail> QuestionnaireDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Branch
    /// </summary>
    public Branch Branch { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Salesman
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion
}
}
