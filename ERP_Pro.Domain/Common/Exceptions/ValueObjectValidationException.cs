using System;
using ERP_Pro.Shared.Exceptions.Base;

namespace ERP_Pro.Domain.Common.Exceptions
{
    /// <summary>
    /// Exception thrown when a value object validation fails
    /// </summary>
    public class ValueObjectValidationException : DomainException
    {
        /// <summary>
        /// Creates a new value object validation exception
        /// </summary>
        public ValueObjectValidationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates a new value object validation exception with inner exception
        /// </summary>
        public ValueObjectValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
} 