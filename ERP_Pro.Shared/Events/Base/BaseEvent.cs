namespace ERP_Pro.Shared.Events.Base;

public abstract class BaseEvent
{
    public DateTime Timestamp { get; private set; }
    public string EventType => GetType().Name;

    protected BaseEvent()
    {
        Timestamp = DateTime.UtcNow;
    }
} 