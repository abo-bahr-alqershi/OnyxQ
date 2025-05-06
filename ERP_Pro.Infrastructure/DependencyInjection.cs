using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Contracts.Persistence.FinanceAccounting;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Domain.Common.Interfaces;
using ERP_Pro.Infrastructure.Persistence.Context;
using ERP_Pro.Infrastructure.Persistence.Repositories.FinanceAccounting;
using ERP_Pro.Infrastructure.Persistence.Repositories.SettingsParameters;
using ERP_Pro.Infrastructure.Services;

namespace ERP_Pro.Infrastructure
{
    /// <summary>
    /// تسجيل خدمات البنية التحتية
    /// </summary>
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // تسجيل قاعدة البيانات
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

            // تسجيل الخدمات
            services.AddTransient<IDateTime, DateTimeService>();
            
            // تسجيل خدمات النظام
            services.AddScoped<IBranchService, BranchService>();
            
            // تسجيل المستودعات - FinanceAccounting
            services.AddScoped<ICurrencyRepository, CurrencyRepository>();
            services.AddScoped<ICurrencyExchangeRateRepository, CurrencyExchangeRateRepository>();
            services.AddScoped<IFiscalYearRepository, FiscalYearRepository>();
            services.AddScoped<IFiscalPeriodRepository, FiscalPeriodRepository>();
            
            // تسجيل المستودعات - SettingsParameters
            services.AddScoped<IDocumentNumberingPatternRepository, DocumentNumberingPatternRepository>();
            
            // تسجيل خدمات أحداث النطاق
            services.AddScoped<IDomainEventDispatcher, DomainEventDispatcher>();
            services.AddScoped<IDomainEventService, DomainEventService>();

            return services;
        }
    }
} 