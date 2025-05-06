# نمط CQRS في طبقة التطبيق (Application Layer)

## نظرة عامة

يتم تطبيق نمط CQRS (Command Query Responsibility Segregation) في طبقة التطبيق لفصل عمليات القراءة (الاستعلامات - Queries) عن عمليات الكتابة (الأوامر - Commands). هذا النمط يساعد في تحسين الأداء والقابلية للتوسع والصيانة، ويُسهِّل تنفيذ متطلبات الأعمال المعقدة.

## مكونات نمط CQRS

### 1. الأوامر (Commands)

الأوامر هي عمليات تغيير حالة النظام (مثل إنشاء، تحديث، حذف). الأوامر تعرف بالخصائص التالية:

- تنفذ عملية واحدة محددة
- يمكن أن تنجح أو تفشل (لا تُرجع بيانات)
- تكون معالجتها متسلسلة
- تتضمن التحقق من الصحة وفرض قواعد الأعمال

### 2. الاستعلامات (Queries)

الاستعلامات هي عمليات قراءة البيانات دون تغيير حالة النظام. الاستعلامات تعرف بالخصائص التالية:

- تُرجع بيانات فقط
- لا تغير حالة النظام
- يمكن تنفيذها بشكل متوازٍ
- قد تستخدم نماذج مختلفة لعرض البيانات

### 3. المعالجون (Handlers)

كل أمر أو استعلام له معالج مخصص مسؤول عن تنفيذ المنطق الخاص به.

## هيكل تنظيم CQRS في التطبيق

```
ERP_Pro.Application/
├── Features/                           # منظمة حسب الميزات
│   ├── Finance/                        # وحدة المالية
│   │   ├── Currencies/                 # ميزة العملات
│   │   │   ├── Commands/               # أوامر العملات
│   │   │   │   ├── CreateCurrency/     # أمر إنشاء عملة
│   │   │   │   │   ├── CreateCurrencyCommand.cs
│   │   │   │   │   ├── CreateCurrencyCommandHandler.cs
│   │   │   │   │   └── CreateCurrencyCommandValidator.cs
│   │   │   │   ├── UpdateCurrency/     # أمر تحديث عملة
│   │   │   │   ├── DeleteCurrency/     # أمر حذف عملة
│   │   │   │   └── ...
│   │   │   └── Queries/                # استعلامات العملات
│   │   │       ├── GetCurrencies/      # استعلام للحصول على قائمة العملات
│   │   │       │   ├── GetCurrenciesQuery.cs
│   │   │       │   └── GetCurrenciesQueryHandler.cs
│   │   │       ├── GetCurrencyById/    # استعلام للحصول على عملة بمعرف
│   │   │       └── ...
│   │   └── ...
│   ├── Inventory/                      # وحدة المخزون
│   │   ├── Items/                      # ميزة الأصناف
│   │   ├── Warehouses/                 # ميزة المستودعات
│   │   └── ...
│   └── ...
├── Behaviors/                          # سلوكيات الوسيط
│   ├── ValidationBehavior.cs           # سلوك التحقق من الصحة
│   ├── LoggingBehavior.cs              # سلوك التسجيل
│   ├── PerformanceBehavior.cs          # سلوك قياس الأداء
│   └── ...
├── Exceptions/                         # استثناءات التطبيق
├── Mappings/                           # تكوينات AutoMapper
├── Interfaces/                         # واجهات التطبيق
│   ├── Repositories/                   # واجهات المستودعات
│   ├── Services/                       # واجهات الخدمات
│   └── ...
└── DependencyInjection/                # تسجيل الخدمات
```

## تنفيذ الأوامر (Commands)

### مثال لأمر إنشاء عملة

```csharp
// Command
public class CreateCurrencyCommand : IRequest<int>
{
    public string Code { get; set; }
    public string NameAr { get; set; }
    public string NameEn { get; set; }
    public decimal ExchangeRate { get; set; }
    public bool IsBaseCurrency { get; set; }
    public string Symbol { get; set; }
}

// Command Handler
public class CreateCurrencyCommandHandler : IRequestHandler<CreateCurrencyCommand, int>
{
    private readonly IUnitOfWork _unitOfWork;
    
    public CreateCurrencyCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<int> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
    {
        // التحقق من عدم وجود عملة بنفس الرمز
        var existingCurrency = await _unitOfWork.Repository<Currency>().GetByCodeAsync(request.Code);
        if (existingCurrency != null)
        {
            throw new ApplicationException($"Currency with code {request.Code} already exists.");
        }
        
        // إنشاء كيان العملة الجديد
        var currency = new Currency(
            request.Code,
            request.NameAr,
            request.NameEn,
            request.ExchangeRate,
            request.IsBaseCurrency,
            request.Symbol
        );
        
        // إضافة الكيان وحفظ التغييرات
        await _unitOfWork.Repository<Currency>().AddAsync(currency);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        return currency.Id;
    }
}

// Command Validator
public class CreateCurrencyCommandValidator : AbstractValidator<CreateCurrencyCommand>
{
    public CreateCurrencyCommandValidator()
    {
        RuleFor(c => c.Code)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .Length(1, 10).WithMessage("{PropertyName} must be between 1 and 10 characters.");
            
        RuleFor(c => c.NameAr)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");
            
        RuleFor(c => c.NameEn)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");
            
        RuleFor(c => c.ExchangeRate)
            .GreaterThan(0).WithMessage("{PropertyName} must be greater than 0.");
            
        RuleFor(c => c.Symbol)
            .MaximumLength(10).WithMessage("{PropertyName} must not exceed 10 characters.");
    }
}
```

## تنفيذ الاستعلامات (Queries)

### مثال لاستعلام الحصول على قائمة العملات

```csharp
// Query
public class GetCurrenciesQuery : IRequest<List<CurrencyDto>>
{
    public bool ActiveOnly { get; set; } = false;
}

// Query Handler
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
```

## تسجيل نمط CQRS في Dependency Injection

```csharp
public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // تسجيل خدمات AutoMapper
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        
        // تسجيل خدمات FluentValidation
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        
        // تسجيل خدمات MediatR
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            
            // تسجيل السلوكيات (Pipeline Behaviors)
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(PerformanceBehavior<,>));
        });
        
        return services;
    }
}
```

## السلوكيات (Behaviors)

السلوكيات تقوم بتنفيذ عمليات مشتركة على جميع الأوامر أو الاستعلامات في Pipeline الخاص بـ MediatR.

### 1. سلوك التحقق من الصحة (Validation Behavior)

```csharp
public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;
    
    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }
    
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (_validators.Any())
        {
            var context = new ValidationContext<TRequest>(request);
            
            var validationResults = await Task.WhenAll(
                _validators.Select(v => v.ValidateAsync(context, cancellationToken)));
                
            var failures = validationResults
                .SelectMany(r => r.Errors)
                .Where(f => f != null)
                .ToList();
                
            if (failures.Count != 0)
            {
                throw new ValidationException(failures);
            }
        }
        
        return await next();
    }
}
```

### 2. سلوك التسجيل (Logging Behavior)

```csharp
public class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;
    private readonly ICurrentUserService _currentUserService;
    
    public LoggingBehavior(
        ILogger<LoggingBehavior<TRequest, TResponse>> logger,
        ICurrentUserService currentUserService)
    {
        _logger = logger;
        _currentUserService = currentUserService;
    }
    
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var requestName = typeof(TRequest).Name;
        var userId = _currentUserService.UserId ?? string.Empty;
        
        _logger.LogInformation("Handling {RequestName} by user {UserId}", requestName, userId);
        
        var response = await next();
        
        _logger.LogInformation("Handled {RequestName}", requestName);
        
        return response;
    }
}
```

## تحويل البيانات باستخدام AutoMapper

### مثال لتكوين AutoMapper

```csharp
public class CurrencyProfile : Profile
{
    public CurrencyProfile()
    {
        // التحويل من كيان العملة إلى DTO
        CreateMap<Currency, CurrencyDto>()
            .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NameEn))
            .ForMember(dest => dest.NameAr, opt => opt.MapFrom(src => src.NameAr))
            .ForMember(dest => dest.ExchangeRate, opt => opt.MapFrom(src => src.ExchangeRate))
            .ForMember(dest => dest.IsBaseCurrency, opt => opt.MapFrom(src => src.IsBaseCurrency))
            .ForMember(dest => dest.Symbol, opt => opt.MapFrom(src => src.Symbol))
            .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));
    }
}
```

## الفوائد والتحديات

### فوائد نمط CQRS

1. **الفصل الواضح للمسؤوليات**: فصل عمليات القراءة عن عمليات الكتابة
2. **قابلية التوسع**: يمكن تحسين أداء الاستعلامات بشكل مستقل عن الأوامر
3. **مرونة النموذج**: يمكن استخدام نماذج مختلفة للقراءة والكتابة
4. **قابلية الاختبار**: سهولة اختبار كل مكون بشكل منفصل
5. **تطبيق Cross-Cutting Concerns**: سهولة تطبيق التحقق من الصحة والتسجيل وغيرها

### التحديات والمخاطر

1. **زيادة التعقيد**: إضافة طبقات ومكونات إضافية
2. **التأخير في اتساق البيانات**: إذا تم استخدام قواعد بيانات منفصلة للقراءة والكتابة
3. **منحنى تعلم أكثر حدة**: يتطلب فهمًا أعمق للمفاهيم والأنماط

## إرشادات وأفضل الممارسات

1. **استخدم الطريقة المناسبة**: لا تطبق CQRS في كل مكان، بل فقط حيث تكون هناك حاجة
2. **حافظ على البساطة**: ابدأ بتنفيذ بسيط ثم قم بالتوسع حسب الحاجة
3. **استخدم أدوات مناسبة**: MediatR وFluentValidation وAutoMapper
4. **وثّق نهجك**: اشرح كيفية تنفيذ CQRS في المشروع
5. **طبق التحقق من الصحة**: تأكد من التحقق من صحة جميع الأوامر
6. **أنشئ اختبارات وحدة**: اختبر كل معالج أمر واستعلام بشكل منفصل
7. **تجنب منطق الأعمال المكرر**: ضع منطق الأعمال المشترك في خدمات منفصلة 