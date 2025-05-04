using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// AnswerQuestionnaireDetail Identifier Value Object
/// </summary>
public sealed class AnswerQuestionnaireDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AnswerQuestionnaireDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AnswerQuestionnaireDetailId instance
    /// </summary>
    public AnswerQuestionnaireDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AnswerQuestionnaireDetailId with a new GUID
    /// </summary>
    public static AnswerQuestionnaireDetailId CreateUnique()
    {
        return new AnswerQuestionnaireDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AnswerQuestionnaireDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AnswerQuestionnaireDetailId id) => id.Value;
}
}
