using System;

namespace ERP_Pro.Shared.Exceptions.Base
{
    /// <summary>
    /// Base exception for domain-related errors
    /// </summary>
    public abstract class DomainException : Exception
    {
        /// <summary>
        /// Creates a new domain exception with the specified message
        /// </summary>
        protected DomainException(string message) : base(message)
        {
        }

        /// <summary>
        /// Creates a new domain exception with the specified message and inner exception
        /// </summary>
        protected DomainException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
} 