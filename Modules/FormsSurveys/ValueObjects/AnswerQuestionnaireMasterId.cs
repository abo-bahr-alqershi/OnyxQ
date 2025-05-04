using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// AnswerQuestionnaireMaster Identifier Value Object
/// </summary>
public sealed class AnswerQuestionnaireMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AnswerQuestionnaireMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AnswerQuestionnaireMasterId instance
    /// </summary>
    public AnswerQuestionnaireMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AnswerQuestionnaireMasterId with a new GUID
    /// </summary>
    public static AnswerQuestionnaireMasterId CreateUnique()
    {
        return new AnswerQuestionnaireMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AnswerQuestionnaireMasterId id) => id.Value.ToString();
    public static implicit operator Guid(AnswerQuestionnaireMasterId id) => id.Value;
}
}
