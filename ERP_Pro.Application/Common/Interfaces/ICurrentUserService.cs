namespace ERP_Pro.Application.Common.Interfaces
{
    /// <summary>
    /// واجهة خدمة المستخدم الحالي
    /// </summary>
    public interface ICurrentUserService
    {
        string UserId { get; }
        string UserName { get; }
        bool IsAuthenticated { get; }
    }
} 