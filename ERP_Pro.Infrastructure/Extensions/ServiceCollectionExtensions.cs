using System;
using System.Linq;
using System.Reflection;
using ERP_Pro.Application.Abstractions.Base;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Infrastructure.Data.Context;
using ERP_Pro.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ERP_Pro.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            // Register services
            services.AddScoped<IDateTime, DateTimeService>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();

            // Register repositories
            services.AddScoped<IFiscalYearRepository, FiscalYearRepository>();
            services.AddScoped<IFiscalPeriodRepository, FiscalPeriodRepository>();
        }
    }

    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.UtcNow;
    }

    public class CurrentUserService : ICurrentUserService
    {
        public string UserId => "1"; // Default value for testing
    }
} 