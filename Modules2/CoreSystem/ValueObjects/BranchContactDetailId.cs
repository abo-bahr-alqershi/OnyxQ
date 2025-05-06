using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
    /// <summary>
    /// BranchContactDetail Identifier Value Object
    /// </summary>
    public sealed class BranchContactDetailId : ValueObject
    {
        /// <summary>
        /// The unique identifier for the BranchContactDetail
        /// </summary>
        public Guid Value { get; }

        /// <summary>
        /// Creates a new BranchContactDetailId instance
        /// </summary>
        public BranchContactDetailId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a new BranchContactDetailId with a new GUID
        /// </summary>
        public static BranchContactDetailId CreateUnique()
        {
            return new BranchContactDetailId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();

        public static implicit operator string(BranchContactDetailId id) => id.Value.ToString();
        public static implicit operator Guid(BranchContactDetailId id) => id.Value;
    }
}
