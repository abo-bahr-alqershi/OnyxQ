using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// QuestionnaireSubDetail Entity
/// </summary>
public class QuestionnaireSubDetail : Entity<QuestionnaireSubDetailId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<Branch> _branch = new List<Branch>();
    private readonly List<AnswerQuestionnaireDetail> _answerQuestionnaireDetail = new List<AnswerQuestionnaireDetail>();
    private readonly List<QuestionnaireDetail> _questionnaireDetail = new List<QuestionnaireDetail>();

    private QuestionnaireSubDetail() { }

    public QuestionnaireSubDetail(QuestionnaireSubDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the QuestionnaireSubDetail
    /// المعرف الفريد لـ QuestionnaireSubDetail
    /// </summary>
    public QuestionnaireSubDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the QuestionnaireSubDetail
    /// DocNo الخاص بـ QuestionnaireSubDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// RecordNumber of the QuestionnaireSubDetail
    /// RecordNumber الخاص بـ QuestionnaireSubDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// QuestionNumber of the QuestionnaireSubDetail
    /// QuestionNumber الخاص بـ QuestionnaireSubDetail
    /// </summary>
    public decimal? QuestionNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the QuestionnaireSubDetail
    /// CompanyNumberShort الخاص بـ QuestionnaireSubDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchYear of the QuestionnaireSubDetail
    /// BranchYear الخاص بـ QuestionnaireSubDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the QuestionnaireSubDetail
    /// BranchUser الخاص بـ QuestionnaireSubDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Branch> Branch => _branch;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<AnswerQuestionnaireDetail> AnswerQuestionnaireDetail => _answerQuestionnaireDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<QuestionnaireDetail> QuestionnaireDetail => _questionnaireDetail;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
