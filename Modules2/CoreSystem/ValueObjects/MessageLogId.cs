using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
    /// <summary>
    /// MessageLog Identifier Value Object
    /// </summary>
    public sealed class MessageLogId : ValueObject
    {
        /// <summary>
        /// The unique identifier for the MessageLog
        /// </summary>
        public Guid Value { get; }

        /// <summary>
        /// Creates a new MessageLogId instance
        /// </summary>
        public MessageLogId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a new MessageLogId with a new GUID
        /// </summary>
        public static MessageLogId CreateUnique()
        {
            return new MessageLogId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();

        public static implicit operator string(MessageLogId id) => id.Value.ToString();
        public static implicit operator Guid(MessageLogId id) => id.Value;
    }
}
