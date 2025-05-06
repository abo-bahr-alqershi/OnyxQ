using System;

namespace ERP_Pro.Application.Common.Exceptions;

/// <summary>
/// استثناء عدم العثور على الكيان
/// </summary>
public class NotFoundException : Exception
{
    public NotFoundException()
        : base()
    {
    }

    public NotFoundException(string message)
        : base(message)
    {
    }

    public NotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public NotFoundException(string name, object key)
        : base($"الكيان \"{name}\" ({key}) غير موجود.")
    {
    }
} 