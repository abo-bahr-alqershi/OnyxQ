using System.Reflection;
using ERP_Pro.Application.Abstractions.Base;
using ERP_Pro.Infrastructure.Data.Common;
using ERP_Pro.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ERP_Pro.Infrastructure.Data.Context;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    private readonly ICurrentUserService? _currentUserService;
    private readonly IDateTime? _dateTime;

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
        ICurrentUserService? currentUserService = null,
        IDateTime? dateTime = null)
        : base(options)
    {
        _currentUserService = currentUserService;
        _dateTime = dateTime;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<IAuditableEntity<string>>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedBy = _currentUserService?.UserId ?? "System";
                    entry.Entity.CreatedOn = _dateTime?.Now ?? DateTime.UtcNow;
                    break;

                case EntityState.Modified:
                    entry.Entity.LastModifiedBy = _currentUserService?.UserId;
                    entry.Entity.LastModifiedOn = _dateTime?.Now ?? DateTime.UtcNow;
                    break;
            }
        }

        foreach (var entry in ChangeTracker.Entries<ISoftDelete>())
        {
            switch (entry.State)
            {
                case EntityState.Deleted:
                    entry.State = EntityState.Modified;
                    entry.Entity.IsDeleted = true;
                    entry.Entity.DeletedBy = _currentUserService?.UserId;
                    entry.Entity.DeletedOn = _dateTime?.Now ?? DateTime.UtcNow;
                    break;
            }
        }

        var result = await base.SaveChangesAsync(cancellationToken);

        return result;
    }
} 