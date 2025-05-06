using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
    /// <summary>
    /// ConnectionType Identifier Value Object
    /// </summary>
    public sealed class ConnectionTypeId : ValueObject
    {
        /// <summary>
        /// The unique identifier for the ConnectionType
        /// </summary>
        public Guid Value { get; }

        /// <summary>
        /// Creates a new ConnectionTypeId instance
        /// </summary>
        public ConnectionTypeId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a new ConnectionTypeId with a new GUID
        /// </summary>
        public static ConnectionTypeId CreateUnique()
        {
            return new ConnectionTypeId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();

        public static implicit operator string(ConnectionTypeId id) => id.Value.ToString();
        public static implicit operator Guid(ConnectionTypeId id) => id.Value;
    }
}
