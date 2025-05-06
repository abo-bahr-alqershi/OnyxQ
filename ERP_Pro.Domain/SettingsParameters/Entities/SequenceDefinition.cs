using System;
using System.Collections.Generic;
using System.Linq;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Events;
using ERP_Pro.Domain.SettingsParameters.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;
using SharedNumberAllocationStatusEnum = ERP_Pro.Shared.Enums.Domain.NumberAllocationStatusEnum;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// كيان تعريف التسلسل الرقمي
    /// </summary>
    public class SequenceDefinition : ERP_Pro.Domain.Common.Base.AuditableEntity<Guid>, IAggregateRoot
    {
        private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        /// <summary>
        /// رمز التسلسل (مثل INV لفواتير المبيعات، PO لأوامر الشراء)
        /// </summary>
        public string Code { get; private set; }
        
        /// <summary>
        /// اسم التسلسل بالعربية
        /// </summary>
        public string NameAr { get; private set; }
        
        /// <summary>
        /// اسم التسلسل بالإنجليزية
        /// </summary>
        public string NameEn { get; private set; }
        
        /// <summary>
        /// نوع المستند المرتبط 
        /// </summary>
        public string DocumentType { get; private set; }
        
        /// <summary>
        /// المجموعة التي ينتمي إليها التسلسل (مالية، مبيعات، مشتريات، مخزون)
        /// </summary>
        public string Group { get; private set; }
        
        /// <summary>
        /// وصف التسلسل
        /// </summary>
        public string Description { get; private set; }
        
        /// <summary>
        /// حالة التسلسل (نشط أو غير نشط)
        /// </summary>
        public ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum Status { get; private set; }
        
        /// <summary>
        /// قائمة الشاشات التي تستخدم هذا التسلسل
        /// </summary>
        public string UsedInScreens { get; private set; }
        
        /// <summary>
        /// بادئة ثابتة للتسلسل
        /// </summary>
        public string Prefix { get; private set; }
        
        /// <summary>
        /// لاحقة ثابتة للتسلسل
        /// </summary>
        public string Suffix { get; private set; }
        
        /// <summary>
        /// استخدام رمز السنة المالية
        /// </summary>
        public bool IncludeFiscalYearCode { get; private set; }
        
        /// <summary>
        /// تنسيق رمز السنة (YY أو YYYY)
        /// </summary>
        public string YearFormat { get; private set; }
        
        /// <summary>
        /// استخدام رمز الفرع
        /// </summary>
        public bool IncludeBranchCode { get; private set; }
        
        /// <summary>
        /// استخدام رمز الإدارة
        /// </summary>
        public bool IncludeDepartmentCode { get; private set; }
        
        /// <summary>
        /// استخدام رمز القسم
        /// </summary>
        public bool IncludeSectionCode { get; private set; }
        
        /// <summary>
        /// استخدام رمز المستخدم
        /// </summary>
        public bool IncludeUserCode { get; private set; }
        
        /// <summary>
        /// عدد خانات الترقيم
        /// </summary>
        public int NumberLength { get; private set; }
        
        /// <summary>
        /// فاصل البادئة
        /// </summary>
        public string PrefixSeparator { get; private set; }
        
        /// <summary>
        /// فاصل اللاحقة
        /// </summary>
        public string SuffixSeparator { get; private set; }
        
        /// <summary>
        /// إكمال الخانات بأصفار
        /// </summary>
        public bool PadWithZeros { get; private set; }
        
        /// <summary>
        /// بداية نطاق الترقيم
        /// </summary>
        public long StartNumber { get; private set; }
        
        /// <summary>
        /// نهاية نطاق الترقيم
        /// </summary>
        public long EndNumber { get; private set; }
        
        /// <summary>
        /// الرقم الحالي
        /// </summary>
        public long CurrentNumber { get; private set; }
        
        /// <summary>
        /// قيمة الزيادة بين الأرقام المتتالية (عادة 1)
        /// </summary>
        public int Increment { get; private set; }
        
        /// <summary>
        /// إعادة ضبط الترقيم مع كل سنة مالية جديدة
        /// </summary>
        public bool ResetWithFiscalYear { get; private set; }
        
        /// <summary>
        /// إعادة ضبط الترقيم مع كل فرع بشكل مستقل
        /// </summary>
        public bool ResetWithBranch { get; private set; }
        
        /// <summary>
        /// إعادة ضبط الترقيم مع بداية كل شهر
        /// </summary>
        public bool ResetWithMonth { get; private set; }
        
        /// <summary>
        /// السماح بالتعديل اليدوي للرقم أثناء إنشاء المستند
        /// </summary>
        public bool AllowManualEdit { get; private set; }
        
        /// <summary>
        /// المستخدمون المصرح لهم بالتعديل اليدوي
        /// </summary>
        public string ManualEditAllowedUsers { get; private set; }
        
        /// <summary>
        /// السماح بإعادة استخدام الأرقام الملغاة
        /// </summary>
        public bool AllowReuseOfCanceledNumbers { get; private set; }
        
        /// <summary>
        /// المدة اللازمة (بالأيام) قبل إعادة استخدام الأرقام الملغاة
        /// </summary>
        public int DaysBeforeReuseOfCanceledNumbers { get; private set; }
        
        /// <summary>
        /// ملاحظات عامة للتسلسل
        /// </summary>
        public string Notes { get; private set; }

        // الأرقام المخصصة والمحجوزة
        private readonly List<NumberAllocation> _numberAllocations = new List<NumberAllocation>();
        public IReadOnlyCollection<NumberAllocation> NumberAllocations => _numberAllocations.AsReadOnly();
        
        // الأرقام المستخدمة
        private readonly List<UsedNumber> _usedNumbers = new List<UsedNumber>();
        public IReadOnlyCollection<UsedNumber> UsedNumbers => _usedNumbers.AsReadOnly();
        
        // الأرقام الملغاة
        private readonly List<CanceledNumber> _canceledNumbers = new List<CanceledNumber>();
        public IReadOnlyCollection<CanceledNumber> CanceledNumbers => _canceledNumbers.AsReadOnly();
        
        // فجوات الأرقام
        private readonly List<NumberGap> _numberGaps = new List<NumberGap>();
        public IReadOnlyCollection<NumberGap> NumberGaps => _numberGaps.AsReadOnly();
        
        // سجل التدقيق للتسلسل
        private readonly List<SequenceAudit> _auditRecords = new List<SequenceAudit>();
        public IReadOnlyCollection<SequenceAudit> AuditRecords => _auditRecords.AsReadOnly();

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private SequenceDefinition() { }

        /// <summary>
        /// إنشاء تعريف تسلسل جديد
        /// </summary>
        public static SequenceDefinition Create(
            string code,
            string nameAr,
            string nameEn,
            string documentType,
            string group,
            string prefix,
            string suffix,
            int numberLength,
            long startNumber,
            long endNumber)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("رمز التسلسل مطلوب", nameof(code));

            if (string.IsNullOrWhiteSpace(nameAr))
                throw new ArgumentException("اسم التسلسل بالعربية مطلوب", nameof(nameAr));

            if (startNumber < 0)
                throw new ArgumentException("بداية نطاق الترقيم يجب أن تكون أكبر من أو تساوي صفر", nameof(startNumber));

            if (endNumber <= startNumber)
                throw new ArgumentException("نهاية نطاق الترقيم يجب أن تكون أكبر من بداية النطاق", nameof(endNumber));

            if (numberLength <= 0)
                throw new ArgumentException("عدد خانات الترقيم يجب أن يكون أكبر من صفر", nameof(numberLength));

            var sequence = new SequenceDefinition
            {
                Id = Guid.NewGuid(),
                Code = code.ToUpperInvariant(),
                NameAr = nameAr,
                NameEn = nameEn ?? nameAr,
                DocumentType = documentType,
                Group = group,
                Status = ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum.Active,
                Prefix = prefix,
                Suffix = suffix,
                IncludeFiscalYearCode = false,
                YearFormat = "YY",
                IncludeBranchCode = false,
                IncludeDepartmentCode = false,
                IncludeSectionCode = false,
                IncludeUserCode = false,
                NumberLength = numberLength,
                PrefixSeparator = "-",
                SuffixSeparator = "-",
                PadWithZeros = true,
                StartNumber = startNumber,
                EndNumber = endNumber,
                CurrentNumber = startNumber,
                Increment = 1,
                ResetWithFiscalYear = false,
                ResetWithBranch = false,
                ResetWithMonth = false,
                AllowManualEdit = false,
                AllowReuseOfCanceledNumbers = false,
                DaysBeforeReuseOfCanceledNumbers = 30
            };

            sequence.AddDomainEvent(new SequenceCreatedEvent(sequence.Id));
            return sequence;
        }

        /// <summary>
        /// تحديث المعلومات الأساسية للتسلسل
        /// </summary>
        public void UpdateBasicInfo(
            string nameAr,
            string nameEn,
            string documentType,
            string group,
            string description,
            string usedInScreens)
        {
            NameAr = nameAr;
            NameEn = nameEn;
            DocumentType = documentType;
            Group = group;
            Description = description;
            UsedInScreens = usedInScreens;

            AddDomainEvent(new SequenceUpdatedEvent(Id));
        }

        /// <summary>
        /// تحديث تكوين الرقم التسلسلي
        /// </summary>
        public void UpdateNumberConfiguration(
            string prefix,
            string suffix,
            bool includeFiscalYearCode,
            string yearFormat,
            bool includeBranchCode,
            bool includeDepartmentCode,
            bool includeSectionCode,
            bool includeUserCode,
            int numberLength,
            string prefixSeparator,
            string suffixSeparator,
            bool padWithZeros)
        {
            Prefix = prefix;
            Suffix = suffix;
            IncludeFiscalYearCode = includeFiscalYearCode;
            YearFormat = yearFormat;
            IncludeBranchCode = includeBranchCode;
            IncludeDepartmentCode = includeDepartmentCode;
            IncludeSectionCode = includeSectionCode;
            IncludeUserCode = includeUserCode;
            NumberLength = numberLength;
            PrefixSeparator = prefixSeparator;
            SuffixSeparator = suffixSeparator;
            PadWithZeros = padWithZeros;

            AddDomainEvent(new SequenceUpdatedEvent(Id));
        }

        /// <summary>
        /// تحديث نطاق الترقيم
        /// </summary>
        public void UpdateNumberRange(
            long startNumber,
            long endNumber,
            int increment,
            bool resetWithFiscalYear,
            bool resetWithBranch,
            bool resetWithMonth)
        {
            if (startNumber < 0)
                throw new ArgumentException("بداية نطاق الترقيم يجب أن تكون أكبر من أو تساوي صفر", nameof(startNumber));

            if (endNumber <= startNumber)
                throw new ArgumentException("نهاية نطاق الترقيم يجب أن تكون أكبر من بداية النطاق", nameof(endNumber));

            if (increment <= 0)
                throw new ArgumentException("قيمة الزيادة يجب أن تكون أكبر من صفر", nameof(increment));

            // الاحتفاظ بالرقم الحالي إذا كان ضمن النطاق الجديد
            if (CurrentNumber < startNumber)
                CurrentNumber = startNumber;
            else if (CurrentNumber > endNumber)
                CurrentNumber = startNumber;

            StartNumber = startNumber;
            EndNumber = endNumber;
            Increment = increment;
            ResetWithFiscalYear = resetWithFiscalYear;
            ResetWithBranch = resetWithBranch;
            ResetWithMonth = resetWithMonth;

            AddDomainEvent(new SequenceUpdatedEvent(Id));
        }

        /// <summary>
        /// تحديث إعدادات الصلاحيات والتحكم
        /// </summary>
        public void UpdatePermissionsAndControl(
            bool allowManualEdit,
            string manualEditAllowedUsers,
            bool allowReuseOfCanceledNumbers,
            int daysBeforeReuseOfCanceledNumbers)
        {
            AllowManualEdit = allowManualEdit;
            ManualEditAllowedUsers = manualEditAllowedUsers;
            AllowReuseOfCanceledNumbers = allowReuseOfCanceledNumbers;
            DaysBeforeReuseOfCanceledNumbers = daysBeforeReuseOfCanceledNumbers;

            AddDomainEvent(new SequenceUpdatedEvent(Id));
        }

        /// <summary>
        /// تحديث الملاحظات
        /// </summary>
        public void UpdateNotes(string notes)
        {
            Notes = notes;
            
            AddDomainEvent(new SequenceUpdatedEvent(Id));
        }

        /// <summary>
        /// تفعيل التسلسل
        /// </summary>
        public void Activate()
        {
            if (Status != ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum.Active)
            {
                Status = ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum.Active;
                AddDomainEvent(new SequenceStatusChangedEvent(Id, ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum.Active));
            }
        }

        /// <summary>
        /// تعطيل التسلسل
        /// </summary>
        public void Deactivate()
        {
            if (Status != ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum.Inactive)
            {
                Status = ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum.Inactive;
                AddDomainEvent(new SequenceStatusChangedEvent(Id, ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum.Inactive));
            }
        }

        /// <summary>
        /// الحصول على الرقم التالي في التسلسل
        /// </summary>
        public string GetNextNumber(
            string branchCode = null,
            string departmentCode = null,
            string sectionCode = null,
            string userCode = null,
            string fiscalYearCode = null)
        {
            if (Status != ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum.Active)
                throw new InvalidOperationException("لا يمكن الحصول على رقم من تسلسل غير نشط");

            if (CurrentNumber > EndNumber)
                throw new InvalidOperationException("تم الوصول إلى نهاية نطاق الترقيم");

            long number = CurrentNumber;
            CurrentNumber += Increment;

            // بناء الرقم التسلسلي المركب
            string formattedNumber = BuildSequenceNumber(
                number,
                branchCode,
                departmentCode,
                sectionCode,
                userCode,
                fiscalYearCode);

            // إضافة سجل للرقم المستخدم
            var usedNumber = new UsedNumber(
                Guid.NewGuid(),
                Id,
                formattedNumber,
                number,
                DateTime.UtcNow);
            _usedNumbers.Add(usedNumber);

            AddDomainEvent(new NumberGeneratedEvent(Id, formattedNumber, number));
            return formattedNumber;
        }

        /// <summary>
        /// إعادة تعيين عداد التسلسل
        /// </summary>
        public void ResetCounter(long newValue)
        {
            if (newValue < StartNumber || newValue > EndNumber)
                throw new ArgumentException("القيمة الجديدة للعداد يجب أن تكون ضمن نطاق الترقيم", nameof(newValue));

            CurrentNumber = newValue;
            AddDomainEvent(new SequenceCounterResetEvent(Id, newValue));
        }

        /// <summary>
        /// حجز نطاق من الأرقام
        /// </summary>
        public NumberAllocation ReserveNumberRange(
            long rangeStart,
            long rangeEnd,
            string reason,
            Guid userId,
            Guid? branchId = null,
            DateTime? expiryDate = null)
        {
            if (Status != ERP_Pro.Shared.Enums.Domain.SequenceStatusEnum.Active)
                throw new InvalidOperationException("لا يمكن حجز أرقام من تسلسل غير نشط");

            if (rangeStart < StartNumber || rangeStart > EndNumber)
                throw new ArgumentException("بداية النطاق المحجوز يجب أن تكون ضمن نطاق الترقيم", nameof(rangeStart));

            if (rangeEnd < rangeStart || rangeEnd > EndNumber)
                throw new ArgumentException("نهاية النطاق المحجوز يجب أن تكون ضمن نطاق الترقيم وأكبر من بدايته", nameof(rangeEnd));

            // التحقق من عدم تداخل النطاق المحجوز مع نطاقات أخرى محجوزة
            foreach (var existingAllocation in _numberAllocations)
            {
                if (existingAllocation.Status == SharedNumberAllocationStatusEnum.Active &&
                    !(rangeEnd < existingAllocation.RangeStart || rangeStart > existingAllocation.RangeEnd))
                {
                    throw new InvalidOperationException("النطاق المطلوب حجزه يتداخل مع نطاق محجوز آخر");
                }
            }

            // إنشاء حجز جديد
            var newAllocation = new NumberAllocation(
                Guid.NewGuid(),
                Id,
                rangeStart,
                rangeEnd,
                reason,
                userId,
                branchId,
                branchId.HasValue ? GetBranchName(branchId.Value) : null,
                DateTime.UtcNow,
                expiryDate);

            _numberAllocations.Add(newAllocation);

            // إذا كان الرقم الحالي ضمن النطاق المحجوز، ننقله إلى ما بعد النطاق
            if (CurrentNumber >= rangeStart && CurrentNumber <= rangeEnd)
            {
                CurrentNumber = rangeEnd + 1;
            }

            AddDomainEvent(new NumberRangeReservedEvent(Id, newAllocation.Id, rangeStart, rangeEnd));
            return newAllocation;
        }

        /// <summary>
        /// إلغاء رقم مستخدم
        /// </summary>
        public CanceledNumber CancelNumber(
            string formattedNumber,
            string reason,
            Guid userId)
        {
            // البحث عن الرقم في قائمة الأرقام المستخدمة
            var usedNumber = _usedNumbers.Find(n => n.FormattedNumber == formattedNumber);
            if (usedNumber == null)
                throw new InvalidOperationException("الرقم المطلوب إلغاؤه غير موجود في قائمة الأرقام المستخدمة");

            // إنشاء سجل للرقم الملغى
            var canceledNumber = new CanceledNumber(
                Guid.NewGuid(),
                Id,
                formattedNumber,
                usedNumber.RawNumber,
                reason,
                userId,
                DateTime.UtcNow);

            _canceledNumbers.Add(canceledNumber);

            // إذا كان مسموحاً بإعادة استخدام الأرقام الملغاة، نعيّن تاريخ إعادة الاستخدام المستقبلي
            if (AllowReuseOfCanceledNumbers && DaysBeforeReuseOfCanceledNumbers > 0)
            {
                canceledNumber.SetReuseDate(DateTime.UtcNow.AddDays(DaysBeforeReuseOfCanceledNumbers));
            }

            return canceledNumber;
        }

        /// <summary>
        /// اكتشاف الفجوات في التسلسل
        /// </summary>
        public List<NumberGap> DetectGaps()
        {
            // تنفيذ منطق اكتشاف الفجوات
            // يتم تحديد الفجوات من خلال مقارنة الأرقام المستخدمة والأرقام المتوقعة ضمن النطاق
            
            // هذا مجرد مثال مبسط، يجب تطويره حسب متطلبات النظام الفعلية
            var usedRawNumbers = _usedNumbers.ConvertAll(u => u.RawNumber);
            usedRawNumbers.Sort();
            
            var gaps = new List<NumberGap>();
            
            for (long i = StartNumber; i < usedRawNumbers[usedRawNumbers.Count - 1]; i += Increment)
            {
                if (!usedRawNumbers.Contains(i))
                {
                    // وجدنا فجوة
                    long gapStart = i;
                    while (i < usedRawNumbers[usedRawNumbers.Count - 1] && !usedRawNumbers.Contains(i))
                    {
                        i += Increment;
                    }
                    long gapEnd = i - Increment;
                    
                    var gap = new NumberGap(
                        Guid.NewGuid(),
                        Id,
                        gapStart,
                        gapEnd,
                        "فجوة مكتشفة تلقائياً",
                        DateTime.UtcNow);
                    
                    gaps.Add(gap);
                    _numberGaps.Add(gap);
                }
            }
            
            return gaps;
        }

        /// <summary>
        /// بناء الرقم التسلسلي
        /// </summary>
        private string BuildSequenceNumber(
            long number,
            string branchCode,
            string departmentCode,
            string sectionCode,
            string userCode,
            string fiscalYearCode)
        {
            var parts = new List<string>();

            // إضافة البادئة
            if (!string.IsNullOrEmpty(Prefix))
            {
                parts.Add(Prefix);
            }

            // إضافة رمز السنة المالية
            if (IncludeFiscalYearCode && !string.IsNullOrEmpty(fiscalYearCode))
            {
                parts.Add(fiscalYearCode);
            }

            // إضافة رمز الفرع
            if (IncludeBranchCode && !string.IsNullOrEmpty(branchCode))
            {
                parts.Add(branchCode);
            }

            // إضافة رمز الإدارة
            if (IncludeDepartmentCode && !string.IsNullOrEmpty(departmentCode))
            {
                parts.Add(departmentCode);
            }

            // إضافة رمز القسم
            if (IncludeSectionCode && !string.IsNullOrEmpty(sectionCode))
            {
                parts.Add(sectionCode);
            }

            // إضافة رمز المستخدم
            if (IncludeUserCode && !string.IsNullOrEmpty(userCode))
            {
                parts.Add(userCode);
            }

            // إضافة الرقم التسلسلي
            string formattedNumber;
            if (PadWithZeros)
            {
                formattedNumber = number.ToString().PadLeft(NumberLength, '0');
            }
            else
            {
                formattedNumber = number.ToString();
            }
            parts.Add(formattedNumber);

            // إضافة اللاحقة
            if (!string.IsNullOrEmpty(Suffix))
            {
                parts.Add(Suffix);
            }

            // دمج الأجزاء باستخدام الفواصل المناسبة
            return string.Join(PrefixSeparator, parts);
        }

        /// <summary>
        /// إضافة حدث نطاق
        /// </summary>
        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        /// <summary>
        /// إزالة حدث نطاق
        /// </summary>
        public void RemoveDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Remove(domainEvent);
        }

        /// <summary>
        /// مسح جميع أحداث النطاق
        /// </summary>
        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        /// <summary>
        /// الحصول على اسم الفرع من معرفه
        /// </summary>
        private string GetBranchName(Guid branchId)
        {
            // في بيئة حقيقية، يجب استرجاع اسم الفرع من قاعدة البيانات
            // لكن هنا نقوم بإرجاع قيمة افتراضية للتبسيط
            return "فرع افتراضي";
        }
    }
} 