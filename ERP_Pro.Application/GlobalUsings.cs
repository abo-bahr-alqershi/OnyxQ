// Global using directives
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Threading;
global using System.Threading.Tasks;

// MediatR imports
global using MediatR;
global using MediatR.Pipeline;
global using MediatR.NotificationPublisher;

// AutoMapper imports
global using AutoMapper;
global using AutoMapper.QueryableExtensions;

// FluentValidation imports
global using FluentValidation;
global using FluentValidation.Results;

// Common response models
global using ERP_Pro.Shared.Models.Results;
global using ERP_Pro.Application.Common.Responses;
global using ERP_Pro.Application.Common.Models;

// Entity framework
global using Microsoft.EntityFrameworkCore;

// Logging
global using Microsoft.Extensions.Logging;

// Domain entities imports
global using ERP_Pro.Domain.SettingsParameters.Entities;
global using ERP_Pro.Domain.FinanceAccounting.Entities;
global using ERP_Pro.Domain.InventoryWarehousing.Entities;

// Domain enums
global using ERP_Pro.Shared.Enums.Domain;
global using ERP_Pro.Domain.SettingsParameters.Enums;
global using ERP_Pro.Shared.Enums.System;

// Domain events
global using ERP_Pro.Domain.Common.Events;
global using ERP_Pro.Domain.SettingsParameters.Events;
global using ERP_Pro.Domain.FinanceAccounting.Events;

// Value objects
global using ERP_Pro.Domain.FinanceAccounting.ValueObjects;

// Common interfaces
global using ERP_Pro.Application.Abstractions.Interfaces;
global using ERP_Pro.Application.Abstractions.Services;
global using ERP_Pro.Application.Abstractions.Repositories;

// Use specific repositories to avoid ambiguity
global using FinanceAccountingRepo = ERP_Pro.Application.Abstractions.Repositories;
global using FinanceAccountingContracts = ERP_Pro.Application.Contracts.Persistence.FinanceAccounting;

// MediatR helpers
global using Unit = MediatR.Unit;

// Common services
global using ERP_Pro.Application.Abstractions.Services.SettingsParameters;

// Application behaviors
global using ERP_Pro.Application.Common.Behaviors;

// Services
global using ERP_Pro.Infrastructure.Shared.Services;
global using ERP_Pro.Infrastructure.Shared.Services.DateTime;
global using ERP_Pro.Infrastructure.Shared.Services.Email;
global using ERP_Pro.Infrastructure.Shared.Services.FileStorage;

// Mappings
global using ERP_Pro.Application.Common.Mappings;

// User service
global using ERP_Pro.Application.Common.Interfaces;

// Application responses
global using ERP_Pro.Shared.Models.Results; 