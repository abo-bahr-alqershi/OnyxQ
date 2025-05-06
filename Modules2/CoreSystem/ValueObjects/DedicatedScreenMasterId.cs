using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
    /// <summary>
    /// DedicatedScreenMaster Identifier Value Object
    /// </summary>
    public sealed class DedicatedScreenMasterId : ValueObject
    {
        /// <summary>
        /// The unique identifier for the DedicatedScreenMaster
        /// </summary>
        public Guid Value { get; }

        /// <summary>
        /// Creates a new DedicatedScreenMasterId instance
        /// </summary>
        public DedicatedScreenMasterId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a new DedicatedScreenMasterId with a new GUID
        /// </summary>
        public static DedicatedScreenMasterId CreateUnique()
        {
            return new DedicatedScreenMasterId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();

        public static implicit operator string(DedicatedScreenMasterId id) => id.Value.ToString();
        public static implicit operator Guid(DedicatedScreenMasterId id) => id.Value;
    }
}
