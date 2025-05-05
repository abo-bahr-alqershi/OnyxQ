using ERP_Pro.Infrastructure.Shared.Services.Cache;
using ERP_Pro.Infrastructure.Shared.Services.DateTime;
using ERP_Pro.Infrastructure.Shared.Services.Email;
using ERP_Pro.Infrastructure.Shared.Services.FileStorage;
using ERP_Pro.Infrastructure.Shared.Validation.Behaviors;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ERP_Pro.Infrastructure.Shared.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureShared(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddValidators()
            .AddMediatrBehaviors()
            .AddCaching()
            .AddDateTime()
            .AddEmail(configuration)
            .AddFileStorage(configuration);

        return services;
    }

    private static IServiceCollection AddValidators(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(typeof(ServiceCollectionExtensions).Assembly);
        return services;
    }

    private static IServiceCollection AddMediatrBehaviors(this IServiceCollection services)
    {
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        return services;
    }

    private static IServiceCollection AddCaching(this IServiceCollection services)
    {
        services.AddMemoryCache();
        services.AddSingleton<ICacheService, MemoryCacheService>();
        return services;
    }

    private static IServiceCollection AddDateTime(this IServiceCollection services)
    {
        services.AddSingleton<IDateTimeService, DateTimeService>();
        return services;
    }

    private static IServiceCollection AddEmail(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<EmailSettings>(configuration.GetSection(nameof(EmailSettings)));
        services.AddTransient<IEmailService, SmtpMailService>();
        return services;
    }

    private static IServiceCollection AddFileStorage(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<FileStorageSettings>(configuration.GetSection(nameof(FileStorageSettings)));
        services.AddTransient<IFileStorageService, LocalFileStorageService>();
        return services;
    }
} 