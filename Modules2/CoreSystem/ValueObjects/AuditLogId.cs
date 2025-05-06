using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
    /// <summary>
    /// AuditLog Identifier Value Object
    /// </summary>
    public sealed class AuditLogId : ValueObject
    {
        /// <summary>
        /// The unique identifier for the AuditLog
        /// </summary>
        public Guid Value { get; }

        /// <summary>
        /// Creates a new AuditLogId instance
        /// </summary>
        public AuditLogId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a new AuditLogId with a new GUID
        /// </summary>
        public static AuditLogId CreateUnique()
        {
            return new AuditLogId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();

        public static implicit operator string(AuditLogId id) => id.Value.ToString();
        public static implicit operator Guid(AuditLogId id) => id.Value;
    }
}
