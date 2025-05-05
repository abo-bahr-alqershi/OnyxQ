using Microsoft.AspNetCore.Identity;

namespace ERP_Pro.Infrastructure.Identity.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiryTime { get; set; }
    public bool IsActive { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public string? TenantId { get; set; }
    public DateTime CreatedOn { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? LastModifiedOn { get; set; }
    public string? LastModifiedBy { get; set; }
    
    public string FullName => $"{FirstName} {LastName}";
} 