using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
    /// <summary>
    /// CompanyContactDetail Identifier Value Object
    /// </summary>
    public sealed class CompanyContactDetailId : ValueObject
    {
        /// <summary>
        /// The unique identifier for the CompanyContactDetail
        /// </summary>
        public Guid Value { get; }

        /// <summary>
        /// Creates a new CompanyContactDetailId instance
        /// </summary>
        public CompanyContactDetailId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a new CompanyContactDetailId with a new GUID
        /// </summary>
        public static CompanyContactDetailId CreateUnique()
        {
            return new CompanyContactDetailId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();

        public static implicit operator string(CompanyContactDetailId id) => id.Value.ToString();
        public static implicit operator Guid(CompanyContactDetailId id) => id.Value;
    }
}
