using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects
{
/// <summary>
/// QuestionnaireMaster Identifier Value Object
/// </summary>
public sealed class QuestionnaireMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the QuestionnaireMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new QuestionnaireMasterId instance
    /// </summary>
    public QuestionnaireMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new QuestionnaireMasterId with a new GUID
    /// </summary>
    public static QuestionnaireMasterId CreateUnique()
    {
        return new QuestionnaireMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(QuestionnaireMasterId id) => id.Value.ToString();
    public static implicit operator Guid(QuestionnaireMasterId id) => id.Value;
}
}
