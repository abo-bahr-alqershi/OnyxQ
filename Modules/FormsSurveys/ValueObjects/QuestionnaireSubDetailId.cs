using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// QuestionnaireSubDetail Identifier Value Object
/// </summary>
public sealed class QuestionnaireSubDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the QuestionnaireSubDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new QuestionnaireSubDetailId instance
    /// </summary>
    public QuestionnaireSubDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new QuestionnaireSubDetailId with a new GUID
    /// </summary>
    public static QuestionnaireSubDetailId CreateUnique()
    {
        return new QuestionnaireSubDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(QuestionnaireSubDetailId id) => id.Value.ToString();
    public static implicit operator Guid(QuestionnaireSubDetailId id) => id.Value;
}
}
