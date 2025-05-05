namespace ERP_Pro.Shared.Exceptions.Base;

public abstract class ApplicationException : Exception
{
    public string Title { get; }
    public string[] Errors { get; }

    protected ApplicationException(string title, string message)
        : base(message)
    {
        Title = title;
        Errors = new[] { message };
    }

    protected ApplicationException(string title, string message, Exception innerException)
        : base(message, innerException)
    {
        Title = title;
        Errors = new[] { message };
    }

    protected ApplicationException(string title, string[] errors)
        : base(string.Join(Environment.NewLine, errors))
    {
        Title = title;
        Errors = errors;
    }
} 