using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// QuestionQuestionnaire Identifier Value Object
/// </summary>
public sealed class QuestionQuestionnaireId : ValueObject
{
    /// <summary>
    /// The unique identifier for the QuestionQuestionnaire
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new QuestionQuestionnaireId instance
    /// </summary>
    public QuestionQuestionnaireId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new QuestionQuestionnaireId with a new GUID
    /// </summary>
    public static QuestionQuestionnaireId CreateUnique()
    {
        return new QuestionQuestionnaireId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(QuestionQuestionnaireId id) => id.Value.ToString();
    public static implicit operator Guid(QuestionQuestionnaireId id) => id.Value;
}
}
