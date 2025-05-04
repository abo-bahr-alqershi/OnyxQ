using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// QuestionnaireDetail Identifier Value Object
/// </summary>
public sealed class QuestionnaireDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the QuestionnaireDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new QuestionnaireDetailId instance
    /// </summary>
    public QuestionnaireDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new QuestionnaireDetailId with a new GUID
    /// </summary>
    public static QuestionnaireDetailId CreateUnique()
    {
        return new QuestionnaireDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(QuestionnaireDetailId id) => id.Value.ToString();
    public static implicit operator Guid(QuestionnaireDetailId id) => id.Value;
}
}
