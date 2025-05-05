using ERP_Pro.Application.Common.Models;

namespace ERP_Pro.Infrastructure.Identity.Services;

public interface IIdentityService
{
    Task<Result<string>> RegisterAsync(string userName, string email, string password, string firstName, string lastName);
    Task<Result<(string Token, string RefreshToken)>> LoginAsync(string userName, string password);
    Task<Result> LogoutAsync(string userId);
} 