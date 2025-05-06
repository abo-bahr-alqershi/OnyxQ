using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

using ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects;
namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// QuestionnaireDetail Entity
/// </summary>
public class QuestionnaireDetail : Entity<QuestionnaireDetailId>
{

    private QuestionnaireDetail() { }

    public QuestionnaireDetail(QuestionnaireDetailId id, decimal? questionnaireNumber)
    {
        Id = id;
        QuestionnaireNumber = questionnaireNumber;
    }

    /// <summary>
    /// The unique identifier for the QuestionnaireDetail
    /// المعرف الفريد لـ QuestionnaireDetail
    /// </summary>
    public QuestionnaireDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the QuestionnaireDetail
    /// DocNo الخاص بـ QuestionnaireDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// RecordNumber of the QuestionnaireDetail
    /// RecordNumber الخاص بـ QuestionnaireDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// QuestionnaireNumber of the QuestionnaireDetail
    /// QuestionnaireNumber الخاص بـ QuestionnaireDetail
    /// </summary>
    public decimal? QuestionnaireNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the QuestionnaireDetail
    /// CompanyNumberShort الخاص بـ QuestionnaireDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchYear of the QuestionnaireDetail
    /// BranchYear الخاص بـ QuestionnaireDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the QuestionnaireDetail
    /// BranchUser الخاص بـ QuestionnaireDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Branch Branch { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public QuestionnaireMaster QuestionnaireMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

