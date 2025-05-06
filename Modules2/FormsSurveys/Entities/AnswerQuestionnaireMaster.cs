using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects;
namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// AnswerQuestionnaireMaster Entity
/// </summary>
public class AnswerQuestionnaireMaster : Entity<AnswerQuestionnaireMasterId>
{

    private AnswerQuestionnaireMaster() { }

    public AnswerQuestionnaireMaster(AnswerQuestionnaireMasterId id, decimal? modelNumber)
    {
        Id = id;
        ModelNumber = modelNumber;
    }

    /// <summary>
    /// The unique identifier for the AnswerQuestionnaireMaster
    /// المعرف الفريد لـ AnswerQuestionnaireMaster
    /// </summary>
    public AnswerQuestionnaireMasterId Id { get; private set; }

    /// <summary>
    /// ModelNumber of the AnswerQuestionnaireMaster
    /// ModelNumber الخاص بـ AnswerQuestionnaireMaster
    /// </summary>
    public decimal? ModelNumber { get; private set; }

    /// <summary>
    /// ModelLastName of the AnswerQuestionnaireMaster
    /// ModelLastName الخاص بـ AnswerQuestionnaireMaster
    /// </summary>
    public string ModelLastName { get; private set; }

    /// <summary>
    /// ModelFirstName of the AnswerQuestionnaireMaster
    /// ModelFirstName الخاص بـ AnswerQuestionnaireMaster
    /// </summary>
    public string ModelFirstName { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

