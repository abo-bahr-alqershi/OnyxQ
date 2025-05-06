using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
    /// <summary>
    /// ContactType Identifier Value Object
    /// </summary>
    public sealed class ContactTypeId : ValueObject
    {
        /// <summary>
        /// The unique identifier for the ContactType
        /// </summary>
        public Guid Value { get; }

        /// <summary>
        /// Creates a new ContactTypeId instance
        /// </summary>
        public ContactTypeId(Guid value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a new ContactTypeId with a new GUID
        /// </summary>
        public static ContactTypeId CreateUnique()
        {
            return new ContactTypeId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value.ToString();

        public static implicit operator string(ContactTypeId id) => id.Value.ToString();
        public static implicit operator Guid(ContactTypeId id) => id.Value;
    }
}
