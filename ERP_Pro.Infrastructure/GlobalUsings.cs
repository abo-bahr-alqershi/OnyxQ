// Global using directives
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Threading;
global using System.Threading.Tasks;

// Entity Framework Core
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;

// Domain entities, interfaces, and repositories
global using ERP_Pro.Domain.SettingsParameters.Entities;
global using ERP_Pro.Domain.FinanceAccounting.Entities;
global using ERP_Pro.Domain.Common.Interfaces;
global using ERP_Pro.Domain.Common.Base;

// Application abstractions and repositories
global using ERP_Pro.Application.Abstractions.Interfaces;
global using ERP_Pro.Application.Abstractions.Repositories;
global using ERP_Pro.Application.Abstractions.Services;

// Infrastructure implementations
global using ERP_Pro.Infrastructure.Persistence.Context;
global using ERP_Pro.Infrastructure.Persistence.Repositories;

// Shared enums
global using ERP_Pro.Shared.Enums.Domain;
global using ERP_Pro.Domain.SettingsParameters.Enums;

// Microsoft extensions
global using Microsoft.Extensions.Logging; 