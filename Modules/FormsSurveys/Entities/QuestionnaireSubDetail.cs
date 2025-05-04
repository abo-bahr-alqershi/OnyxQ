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
    private QuestionnaireSubDetail() { }

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
    /// DocSer of the QuestionnaireSubDetail
    /// DocSer الخاص بـ QuestionnaireSubDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// RecordNumber of the QuestionnaireSubDetail
    /// RecordNumber الخاص بـ QuestionnaireSubDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemCode of the QuestionnaireSubDetail
    /// ItemCode الخاص بـ QuestionnaireSubDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// QuestionnaireNumber of the QuestionnaireSubDetail
    /// QuestionnaireNumber الخاص بـ QuestionnaireSubDetail
    /// </summary>
    public decimal? QuestionnaireNumber { get; private set; }

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
    /// BranchNumber of the QuestionnaireSubDetail
    /// BranchNumber الخاص بـ QuestionnaireSubDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

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

    /// <summary>
    /// ModelNumber of the QuestionnaireSubDetail
    /// ModelNumber الخاص بـ QuestionnaireSubDetail
    /// </summary>
    public decimal? ModelNumber { get; private set; }

    /// <summary>
    /// AnswerNumber of the QuestionnaireSubDetail
    /// AnswerNumber الخاص بـ QuestionnaireSubDetail
    /// </summary>
    public decimal? AnswerNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Branch
    /// </summary>
    public Branch Branch { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AnswerQuestionnaireDetail
    /// </summary>
    public AnswerQuestionnaireDetail AnswerQuestionnaireDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to QuestionnaireDetail
    /// </summary>
    public QuestionnaireDetail QuestionnaireDetail { get; private set; }
    #endregion
}
}
