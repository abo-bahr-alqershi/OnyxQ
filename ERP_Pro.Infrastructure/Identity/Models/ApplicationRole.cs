using Microsoft.AspNetCore.Identity;

namespace ERP_Pro.Infrastructure.Identity.Models;

public class ApplicationRole : IdentityRole
{
    public string? Description { get; set; }
    public DateTime CreatedOn { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? LastModifiedOn { get; set; }
    public string? LastModifiedBy { get; set; }
    
    public ApplicationRole() : base()
    {
    }

    public ApplicationRole(string roleName) : base(roleName)
    {
    }
} 