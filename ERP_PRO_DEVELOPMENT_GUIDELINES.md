# دليل تطوير نظام ERP Pro الشامل

## مقدمة

هذا الدليل يقدم إرشادات تفصيلية وخطوات محددة لبناء وتطوير مكونات نظام ERP Pro باستخدام معمارية CQRS (Command Query Responsibility Segregation) والتصميم النظيف (Clean Architecture). اتباع هذه الإرشادات بدقة سيضمن تطوير متناسق وخالٍ من الأخطاء.

## هيكل المشروع الأساسي

النظام مبني على الطبقات التالية:

1. **ERP_Pro.Domain**: طبقة نماذج المجال الأساسية والقواعد التجارية
2. **ERP_Pro.Application**: طبقة منطق الأعمال وتنفيذ حالات الاستخدام
3. **ERP_Pro.Infrastructure**: طبقة تنفيذ البنية التحتية والتخزين
4. **ERP_Pro.Infrastructure.Shared**: خدمات مشتركة ومساعدة للبنية التحتية
5. **ERP_Pro.Server**: طبقة واجهة المستخدم وواجهات API
6. **ERP_Pro.Shared**: نماذج وتعريفات مشتركة بين الطبقات

## خطوات تفصيلية لإضافة ميزة جديدة

### 1. تحليل المتطلبات وتخطيط الميزة

- حدد اسم الميزة وتعريفها بوضوح
- حدد الكيانات المطلوبة والعلاقات بينها
- حدد العمليات المطلوبة (إضافة، تعديل، حذف، استعلام)
- حدد القواعد التجارية التي يجب فرضها

### 2. إنشاء نماذج المجال (ERP_Pro.Domain)

```bash
# المسار المقترح للملفات
ERP_Pro.Domain/<ModuleName>/<EntityName>.cs
```

- قم بإنشاء نماذج المجال (Domain Models) المطلوبة مع الخصائص والسلوكيات
- حدد العلاقات بين الكيانات (1:1، 1:n، n:n)
- تنفيذ قواعد التحقق من الصحة على مستوى الكيان
- تنفيذ أحداث المجال (Domain Events) إذا لزم الأمر

#### مثال لنموذج مجال (لكيان العملة):

```csharp
// ERP_Pro.Domain/FinanceAccounting/Currency.cs
using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.FinanceAccounting.Events;

namespace ERP_Pro.Domain.FinanceAccounting
{
    public class Currency : AuditableEntity, IAggregateRoot
    {
        public string Code { get; private set; }
        public string NameAr { get; private set; }
        public string NameEn { get; private set; }
        public decimal ExchangeRate { get; private set; }
        public bool IsBaseCurrency { get; private set; }
        public string Symbol { get; private set; }
        public bool IsActive { get; private set; }
        
        // العلاقات مع كيانات أخرى
        public virtual ICollection<ExchangeRateHistory> ExchangeRateHistory { get; private set; }
        
        private Currency()
        {
            // مطلوب للـ ORM
        }
        
        public Currency(string code, string nameAr, string nameEn, decimal exchangeRate, 
                       bool isBaseCurrency, string symbol)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("Currency code cannot be empty", nameof(code));
                
            if (string.IsNullOrWhiteSpace(nameAr))
                throw new ArgumentException("Arabic name cannot be empty", nameof(nameAr));
                
            if (string.IsNullOrWhiteSpace(nameEn))
                throw new ArgumentException("English name cannot be empty", nameof(nameEn));
                
            if (exchangeRate <= 0)
                throw new ArgumentException("Exchange rate must be positive", nameof(exchangeRate));
                
            Code = code;
            NameAr = nameAr;
            NameEn = nameEn;
            ExchangeRate = exchangeRate;
            IsBaseCurrency = isBaseCurrency;
            Symbol = symbol;
            IsActive = true;
            ExchangeRateHistory = new List<ExchangeRateHistory>();
            
            AddDomainEvent(new CurrencyCreatedEvent(this));
        }
        
        public void UpdateExchangeRate(decimal newExchangeRate, string updatedBy)
        {
            if (newExchangeRate <= 0)
                throw new ArgumentException("Exchange rate must be positive", nameof(newExchangeRate));
                
            var oldRate = ExchangeRate;
            ExchangeRate = newExchangeRate;
            
            var history = new ExchangeRateHistory(this.Id, oldRate, newExchangeRate, DateTime.UtcNow, updatedBy);
            ExchangeRateHistory.Add(history);
            
            AddDomainEvent(new CurrencyExchangeRateUpdatedEvent(this, oldRate, newExchangeRate));
        }
        
        public void Activate()
        {
            if (!IsActive)
            {
                IsActive = true;
                AddDomainEvent(new CurrencyStatusChangedEvent(this));
            }
        }
        
        public void Deactivate()
        {
            if (IsActive)
            {
                IsActive = false;
                AddDomainEvent(new CurrencyStatusChangedEvent(this));
            }
        }
        
        public void Update(string nameAr, string nameEn, string symbol)
        {
            if (string.IsNullOrWhiteSpace(nameAr))
                throw new ArgumentException("Arabic name cannot be empty", nameof(nameAr));
                
            if (string.IsNullOrWhiteSpace(nameEn))
                throw new ArgumentException("English name cannot be empty", nameof(nameEn));
                
            NameAr = nameAr;
            NameEn = nameEn;
            Symbol = symbol;
            
            AddDomainEvent(new CurrencyUpdatedEvent(this));
        }
    }
}
```

### 3. تحديد مستودع الواجهة (Repository Interface) في طبقة المجال

```csharp
// ERP_Pro.Domain/FinanceAccounting/Interfaces/ICurrencyRepository.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting;

namespace ERP_Pro.Domain.FinanceAccounting.Interfaces
{
    public interface ICurrencyRepository
    {
        Task<Currency> GetByIdAsync(int id);
        Task<Currency> GetByCodeAsync(string code);
        Task<IEnumerable<Currency>> GetAllAsync();
        Task<IEnumerable<Currency>> GetActiveCurrenciesAsync();
        Task<Currency> AddAsync(Currency currency);
        Task UpdateAsync(Currency currency);
    }
}
```

### 4. إنشاء نماذج DTO في طبقة Shared

```csharp
// ERP_Pro.Shared/DTOs/Finance/CurrencyDto.cs
using System;

namespace ERP_Pro.Shared.DTOs.Finance
{
    public class CurrencyDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool IsBaseCurrency { get; set; }
        public string Symbol { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
    }
    
    public class CreateCurrencyRequest
    {
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool IsBaseCurrency { get; set; }
        public string Symbol { get; set; }
    }
    
    public class UpdateCurrencyRequest
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Symbol { get; set; }
    }
    
    public class UpdateExchangeRateRequest
    {
        public int Id { get; set; }
        public decimal ExchangeRate { get; set; }
    }
}
```

### 5. إنشاء طبقة التطبيق (Application - CQRS)

#### 5.1 إنشاء الاستعلامات (Queries)

```csharp
// ERP_Pro.Application/Features/Finance/Currencies/Queries/GetCurrencies
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ERP_Pro.Application.Interfaces.Repositories;
using ERP_Pro.Domain.FinanceAccounting;
using ERP_Pro.Shared.DTOs.Finance;
using MediatR;

namespace ERP_Pro.Application.Features.Finance.Currencies.Queries.GetCurrencies
{
    public class GetCurrenciesQuery : IRequest<List<CurrencyDto>>
    {
        public bool ActiveOnly { get; set; } = false;
    }
    
    public class GetCurrenciesQueryHandler : IRequestHandler<GetCurrenciesQuery, List<CurrencyDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        
        public GetCurrenciesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
        public async Task<List<CurrencyDto>> Handle(GetCurrenciesQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Currency> currencies;
            
            if (request.ActiveOnly)
            {
                currencies = await _unitOfWork.Repository<Currency>().GetActiveCurrenciesAsync();
            }
            else
            {
                currencies = await _unitOfWork.Repository<Currency>().GetAllAsync();
            }
            
            return _mapper.Map<List<CurrencyDto>>(currencies);
        }
    }
}
```

#### 5.2 إنشاء الأوامر (Commands)

```csharp
// ERP_Pro.Application/Features/Finance/Currencies/Commands/CreateCurrency
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ERP_Pro.Application.Interfaces.Repositories;
using ERP_Pro.Domain.FinanceAccounting;
using ERP_Pro.Shared.DTOs.Finance;
using MediatR;

namespace ERP_Pro.Application.Features.Finance.Currencies.Commands.CreateCurrency
{
    public class CreateCurrencyCommand : IRequest<int>
    {
        public CreateCurrencyRequest CurrencyRequest { get; set; }
    }
    
    public class CreateCurrencyCommandHandler : IRequestHandler<CreateCurrencyCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public CreateCurrencyCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<int> Handle(CreateCurrencyCommand command, CancellationToken cancellationToken)
        {
            var request = command.CurrencyRequest;
            
            // التحقق من عدم وجود عملة بنفس الرمز
            var existingCurrency = await _unitOfWork.Repository<Currency>().GetByCodeAsync(request.Code);
            if (existingCurrency != null)
            {
                throw new ApplicationException($"Currency with code {request.Code} already exists.");
            }
            
            var currency = new Currency(
                request.Code,
                request.NameAr,
                request.NameEn,
                request.ExchangeRate,
                request.IsBaseCurrency,
                request.Symbol
            );
            
            await _unitOfWork.Repository<Currency>().AddAsync(currency);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            
            return currency.Id;
        }
    }
}
```

#### 5.3 إنشاء ملف التحقق من الصحة (Validator)

```csharp
// ERP_Pro.Application/Features/Finance/Currencies/Commands/CreateCurrency/CreateCurrencyCommandValidator.cs
using ERP_Pro.Application.Features.Finance.Currencies.Commands.CreateCurrency;
using FluentValidation;

namespace ERP_Pro.Application.Features.Finance.Currencies.Commands.CreateCurrency
{
    public class CreateCurrencyCommandValidator : AbstractValidator<CreateCurrencyCommand>
    {
        public CreateCurrencyCommandValidator()
        {
            RuleFor(c => c.CurrencyRequest.Code)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .Length(1, 10).WithMessage("{PropertyName} must be between 1 and 10 characters.");
                
            RuleFor(c => c.CurrencyRequest.NameAr)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");
                
            RuleFor(c => c.CurrencyRequest.NameEn)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");
                
            RuleFor(c => c.CurrencyRequest.ExchangeRate)
                .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
                
            RuleFor(c => c.CurrencyRequest.Symbol)
                .MaximumLength(10).WithMessage("{PropertyName} must not exceed 10 characters.");
        }
    }
}
```

### 6. تنفيذ البنية التحتية (Infrastructure)

#### 6.1 إنشاء تكوين الكيان للـ EF Core

```csharp
// ERP_Pro.Infrastructure/Configurations/Finance/CurrencyConfiguration.cs
using ERP_Pro.Domain.FinanceAccounting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_Pro.Infrastructure.Configurations.Finance
{
    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.ToTable("Currencies", "Finance");
            
            builder.HasKey(c => c.Id);
            
            builder.Property(c => c.Code)
                .HasMaxLength(10)
                .IsRequired();
                
            builder.HasIndex(c => c.Code)
                .IsUnique();
                
            builder.Property(c => c.NameAr)
                .HasMaxLength(100)
                .IsRequired();
                
            builder.Property(c => c.NameEn)
                .HasMaxLength(100)
                .IsRequired();
                
            builder.Property(c => c.ExchangeRate)
                .HasColumnType("decimal(18,6)")
                .IsRequired();
                
            builder.Property(c => c.Symbol)
                .HasMaxLength(10);
                
            builder.Property(c => c.IsBaseCurrency)
                .HasDefaultValue(false);
                
            builder.Property(c => c.IsActive)
                .HasDefaultValue(true);
                
            // تكوين العلاقات
            builder.HasMany(c => c.ExchangeRateHistory)
                .WithOne()
                .HasForeignKey(h => h.CurrencyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
```

#### 6.2 تنفيذ المستودع (Repository)

```csharp
// ERP_Pro.Infrastructure/Repositories/Finance/CurrencyRepository.cs
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting;
using ERP_Pro.Domain.FinanceAccounting.Interfaces;
using ERP_Pro.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ERP_Pro.Infrastructure.Repositories.Finance
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly ApplicationDbContext _dbContext;
        
        public CurrencyRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<Currency> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Currency>()
                .Include(c => c.ExchangeRateHistory)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
        
        public async Task<Currency> GetByCodeAsync(string code)
        {
            return await _dbContext.Set<Currency>()
                .FirstOrDefaultAsync(c => c.Code == code);
        }
        
        public async Task<IEnumerable<Currency>> GetAllAsync()
        {
            return await _dbContext.Set<Currency>()
                .ToListAsync();
        }
        
        public async Task<IEnumerable<Currency>> GetActiveCurrenciesAsync()
        {
            return await _dbContext.Set<Currency>()
                .Where(c => c.IsActive)
                .ToListAsync();
        }
        
        public async Task<Currency> AddAsync(Currency currency)
        {
            await _dbContext.Set<Currency>().AddAsync(currency);
            return currency;
        }
        
        public Task UpdateAsync(Currency currency)
        {
            _dbContext.Entry(currency).State = EntityState.Modified;
            return Task.CompletedTask;
        }
    }
}
```

#### 6.3 تسجيل الخدمات في Dependency Injection

```csharp
// ERP_Pro.Infrastructure/DependencyInjection/RepositoryServiceRegistration.cs (إضافة لملف موجود)
using ERP_Pro.Domain.FinanceAccounting.Interfaces;
using ERP_Pro.Infrastructure.Repositories.Finance;
using Microsoft.Extensions.DependencyInjection;

namespace ERP_Pro.Infrastructure.DependencyInjection
{
    public static class RepositoryServiceRegistration
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            // تسجيل المستودعات الأخرى...
            services.AddTransient<ICurrencyRepository, CurrencyRepository>();
            
            return services;
        }
    }
}
```

### 7. تنفيذ خرائط AutoMapper

```csharp
// ERP_Pro.Application/Mappings/CurrencyProfile.cs
using AutoMapper;
using ERP_Pro.Domain.FinanceAccounting;
using ERP_Pro.Shared.DTOs.Finance;

namespace ERP_Pro.Application.Mappings
{
    public class CurrencyProfile : Profile
    {
        public CurrencyProfile()
        {
            CreateMap<Currency, CurrencyDto>();
        }
    }
}
```

### 8. إنشاء وحدة التحكم (Controller) في طبقة Server

```csharp
// ERP_Pro.Server/Controllers/v1/Finance/CurrenciesController.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Application.Features.Finance.Currencies.Commands.ActivateCurrency;
using ERP_Pro.Application.Features.Finance.Currencies.Commands.CreateCurrency;
using ERP_Pro.Application.Features.Finance.Currencies.Commands.DeactivateCurrency;
using ERP_Pro.Application.Features.Finance.Currencies.Commands.UpdateCurrency;
using ERP_Pro.Application.Features.Finance.Currencies.Commands.UpdateExchangeRate;
using ERP_Pro.Application.Features.Finance.Currencies.Queries.GetCurrencies;
using ERP_Pro.Application.Features.Finance.Currencies.Queries.GetCurrencyById;
using ERP_Pro.Shared.DTOs.Finance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Pro.Server.Controllers.v1.Finance
{
    [ApiController]
    [Route("api/v1/finance/[controller]")]
    public class CurrenciesController : BaseApiController
    {
        [HttpGet]
        [Authorize(Policy = "Currencies.View")]
        public async Task<ActionResult<List<CurrencyDto>>> Get([FromQuery] bool activeOnly = false)
        {
            return await Mediator.Send(new GetCurrenciesQuery { ActiveOnly = activeOnly });
        }
        
        [HttpGet("{id}")]
        [Authorize(Policy = "Currencies.View")]
        public async Task<ActionResult<CurrencyDto>> GetById(int id)
        {
            return await Mediator.Send(new GetCurrencyByIdQuery { Id = id });
        }
        
        [HttpPost]
        [Authorize(Policy = "Currencies.Create")]
        public async Task<ActionResult<int>> Create([FromBody] CreateCurrencyRequest request)
        {
            var command = new CreateCurrencyCommand { CurrencyRequest = request };
            return await Mediator.Send(command);
        }
        
        [HttpPut("{id}")]
        [Authorize(Policy = "Currencies.Edit")]
        public async Task<ActionResult> Update(int id, [FromBody] UpdateCurrencyRequest request)
        {
            if (id != request.Id) return BadRequest();
            
            await Mediator.Send(new UpdateCurrencyCommand { CurrencyRequest = request });
            return NoContent();
        }
        
        [HttpPut("{id}/exchange-rate")]
        [Authorize(Policy = "Currencies.Edit")]
        public async Task<ActionResult> UpdateExchangeRate(int id, [FromBody] UpdateExchangeRateRequest request)
        {
            if (id != request.Id) return BadRequest();
            
            await Mediator.Send(new UpdateExchangeRateCommand { Request = request });
            return NoContent();
        }
        
        [HttpPut("{id}/activate")]
        [Authorize(Policy = "Currencies.Edit")]
        public async Task<ActionResult> Activate(int id)
        {
            await Mediator.Send(new ActivateCurrencyCommand { Id = id });
            return NoContent();
        }
        
        [HttpPut("{id}/deactivate")]
        [Authorize(Policy = "Currencies.Edit")]
        public async Task<ActionResult> Deactivate(int id)
        {
            await Mediator.Send(new DeactivateCurrencyCommand { Id = id });
            return NoContent();
        }
    }
}
```

### 9. إضافة سياسات الوصول (Authorization Policies)

```csharp
// ERP_Pro.Server/Extensions/ServiceCollectionExtensions.cs (إضافة للملف الموجود)
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace ERP_Pro.Server.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAuthorizationPolicies(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                // سياسات أخرى...
                
                // سياسات العملات
                options.AddPolicy("Currencies.View", policy => policy.RequireClaim("Permission", "Currencies.View"));
                options.AddPolicy("Currencies.Create", policy => policy.RequireClaim("Permission", "Currencies.Create"));
                options.AddPolicy("Currencies.Edit", policy => policy.RequireClaim("Permission", "Currencies.Edit"));
            });
            
            return services;
        }
    }
}
```

## قواعد ومبادئ عامة للتطوير

### 1. قواعد طبقة المجال (Domain Layer)

- استخدم الكيانات كـ Aggregate Roots حيثما أمكن
- لا تستخدم تبعيات خارجية في طبقة المجال
- تأكد من فرض قواعد صحة البيانات داخل الكيانات
- استخدم الكائنات المجمدة (Immutable) حيثما أمكن
- استخدم أنماط المجال (Domain Patterns) مثل Value Objects و Entities
- استخدم Enumeration Classes بدلاً من Enums العادية
- نفذ الأحداث الداخلية (Domain Events) للتعامل مع الآثار الجانبية
- استخدم واجهات Repository في طبقة المجال
- تجنب التبعيات المباشرة بين Aggregates
- حماية البيانات في الكيانات باستخدام private setters

### 2. قواعد طبقة التطبيق (Application Layer)

- استخدم نمط CQRS مع MediatR
- فصل الأوامر (Commands) عن الاستعلامات (Queries)
- استخدم الوسطاء (Mediator) لمعالجة الأوامر والاستعلامات
- استخدم AutoMapper للتحويل بين الكيانات و DTOs
- استخدم FluentValidation للتحقق من صحة طلبات الأوامر
- استخدم Unit of Work Pattern
- تنفيذ سلوك التعامل مع Cross-Cutting Concerns مثل التحقق والتسجيل

### 3. قواعد البنية التحتية (Infrastructure Layer)

- احتفظ بتنفيذ Repository في هذه الطبقة
- استخدم Entity Framework Core للوصول إلى قاعدة البيانات
- تنفيذ الخدمات الخارجية مثل البريد الإلكتروني والتخزين
- تنفيذ تكوينات الكيانات (Entity Configurations) لـ EF Core
- تنفيذ Unit of Work

### 4. قواعد طبقة العرض (Presentation/Server Layer)

- استخدم Controllers نظيفة وبسيطة
- لا تحتوي على أي منطق أعمال
- التحقق من صحة طلبات API باستخدام Data Annotations
- تنفيذ سياسات التخويل (Authorization Policies)
- استخدام DTO للتبادل مع العميل

## قواعد تسمية وتنظيم الملفات

### 1. قواعد التسمية

- استخدم PascalCase لأسماء الفئات والواجهات والخصائص
- استخدم camelCase للمتغيرات والمعلمات
- استخدم UPPERCASE_SNAKE_CASE للثوابت
- بادئ الواجهات (Interfaces) بحرف I
- استخدم لاحقة Command للأوامر وQuery للاستعلامات
- استخدم لاحقة Dto للكائنات نقل البيانات
- استخدم لاحقة Repository للمستودعات
- استخدم لاحقة Service للخدمات

### 2. تنظيم المجلدات

- نظم حسب الميزات (Features) وليس حسب النوع
- استخدم مجلدات فرعية للأوامر والاستعلامات
- ضع ملفات المعالج (Handlers) مع الأوامر/الاستعلامات

## تعليمات إضافية

### 1. العلاقات بين الكيانات

- حدد علاقات 1:1 باستخدام Navigation Property في كلا الكيانين
- حدد علاقات 1:n باستخدام ICollection في الكيان الأب وNavigationProperty في الكيان الابن
- حدد علاقات n:n باستخدام كيان وسيط (Join Entity)

### 2. التعامل مع الأحداث

- نفذ أحداث المجال (Domain Events) باستخدام MediatR
- اشر الاهتمام بنماذج الأحداث (Event Sourcing Pattern)

### 3. التحقق من الصحة

- نفذ تحقق مزدوج: على مستوى المجال (للقواعد التجارية) وعلى مستوى التطبيق (للقواعد التقنية)
- استخدم FluentValidation للتحقق في طبقة التطبيق

### 4. التخويل والتفويض

- استخدم Authorization Policy Based للتخويل
- لا تنفذ منطق التخويل في وحدات التحكم

## قائمة مرجعية للتحقق من الصحة

- [ ] هل كيانات المجال محمية وتفرض قواعد التحقق؟
- [ ] هل تم تعريف Repository Interfaces في طبقة المجال؟
- [ ] هل تم تنفيذ CQRS بشكل صحيح؟
- [ ] هل تم استخدام DTOs للتبادل مع العميل؟
- [ ] هل تم تنفيذ التحقق من صحة الطلبات؟
- [ ] هل تم تكوين العلاقات بشكل صحيح في EF Core؟
- [ ] هل تم تنفيذ سياسات التخويل؟
- [ ] هل كانت وحدات التحكم نظيفة وبدون منطق أعمال؟
- [ ] هل تم تغطية السيناريوهات اللازمة؟
- [ ] هل البنية مفصولة بشكل صحيح (Separation of Concerns)؟

## مثال عملي: إضافة ميزة إدارة العملات

باتباع الخطوات المذكورة أعلاه، يمكن إضافة ميزة إدارة العملات كاملة مع جميع الوظائف المطلوبة. الكود المرجعي في هذا الدليل يوضح كيفية تنفيذ هذه الميزة بالكامل.

## ملاحظات ختامية

- اتبع المعايير والأنماط المذكورة بدقة
- احتفظ بالكود نظيفًا ومنظمًا
- التزم بمبادئ SOLID
- أضف تعليقات توثيقية حيثما لزم الأمر
- اكتب اختبارات وحدة (Unit Tests) وتكامل (Integration Tests)
- استخدم أدوات التحليل الثابت (Static Analysis) لضمان جودة الكود 