using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
    /// <summary>
    /// ContactDetail Identifier Value Object
    /// </summary>
    public sealed class ContactDetailId : ValueObject
    {
        /// <summary>
        /// The unique identifier for the ContactDetail
        /// </summary>
        public Guid Value { get; }

        /// <summary>
        /// Creates a new ContactDetailId instance
        /// </summary>
        public ContactDetailId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a new ContactDetailId with a new GUID
        /// </summary>
        public static ContactDetailId CreateUnique()
        {
            return new ContactDetailId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();

        public static implicit operator string(ContactDetailId id) => id.Value.ToString();
        public static implicit operator Guid(ContactDetailId id) => id.Value;
    }
}
