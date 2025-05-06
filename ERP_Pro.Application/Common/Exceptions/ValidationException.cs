using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;

namespace ERP_Pro.Application.Common.Exceptions
{
    /// <summary>
    /// استثناء التحقق من صحة البيانات
    /// </summary>
    public class ValidationException : Exception
    {
        public ValidationException()
            : base("حدث خطأ واحد أو أكثر أثناء التحقق من صحة البيانات")
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(IEnumerable<ValidationFailure> failures)
            : this()
        {
            Errors = failures
                .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
                .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
        }

        public IDictionary<string, string[]> Errors { get; }
    }
} 