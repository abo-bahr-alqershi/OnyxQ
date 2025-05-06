using ERP_Pro.Shared.Exceptions.Base;

namespace ERP_Pro.Shared.Exceptions.Domain;

public class EntityNotFoundException : ERP_Pro.Shared.Exceptions.Base.ApplicationException
{
    public EntityNotFoundException(string entityName, object key)
        : base($"{entityName} Not Found", $"{entityName} with identifier {key} was not found.")
    {
    }

    public EntityNotFoundException(string entityName, string message)
        : base($"{entityName} Not Found", message)
    {
    }
} 