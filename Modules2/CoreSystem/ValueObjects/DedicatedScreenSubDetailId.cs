using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
    /// <summary>
    /// DedicatedScreenSubDetail Identifier Value Object
    /// </summary>
    public sealed class DedicatedScreenSubDetailId : ValueObject
    {
        /// <summary>
        /// The unique identifier for the DedicatedScreenSubDetail
        /// </summary>
        public Guid Value { get; }

        /// <summary>
        /// Creates a new DedicatedScreenSubDetailId instance
        /// </summary>
        public DedicatedScreenSubDetailId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a new DedicatedScreenSubDetailId with a new GUID
        /// </summary>
        public static DedicatedScreenSubDetailId CreateUnique()
        {
            return new DedicatedScreenSubDetailId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();

        public static implicit operator string(DedicatedScreenSubDetailId id) => id.Value.ToString();
        public static implicit operator Guid(DedicatedScreenSubDetailId id) => id.Value;
    }
}
