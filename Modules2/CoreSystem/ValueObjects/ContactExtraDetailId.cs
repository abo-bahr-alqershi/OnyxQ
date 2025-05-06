using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
    /// <summary>
    /// ContactExtraDetail Identifier Value Object
    /// </summary>
    public sealed class ContactExtraDetailId : ValueObject
    {
        /// <summary>
        /// The unique identifier for the ContactExtraDetail
        /// </summary>
        public Guid Value { get; }

        /// <summary>
        /// Creates a new ContactExtraDetailId instance
        /// </summary>
        public ContactExtraDetailId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a new ContactExtraDetailId with a new GUID
        /// </summary>
        public static ContactExtraDetailId CreateUnique()
        {
            return new ContactExtraDetailId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();

        public static implicit operator string(ContactExtraDetailId id) => id.Value.ToString();
        public static implicit operator Guid(ContactExtraDetailId id) => id.Value;
    }
}
