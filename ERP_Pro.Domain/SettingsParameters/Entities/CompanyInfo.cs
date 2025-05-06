using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.SettingsParameters.ValueObjects;
using ERP_Pro.Domain.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// كيان معلومات الشركة - يمثل المعلومات الأساسية للشركة
    /// </summary>
    public class CompanyInfo : AggregateRoot
    {
        // المعلومات الأساسية
        public string NameAr { get; private set; }
        public string NameEn { get; private set; }
        public string LogoPath { get; private set; }
        public string CommercialRegistrationNo { get; private set; }
        public DateTime? CommercialRegistrationDate { get; private set; }
        public string TaxRegistrationNo { get; private set; }
        public DateTime? TaxRegistrationDate { get; private set; }
        public string LegalForm { get; private set; }
        public decimal Capital { get; private set; }
        public string CapitalCurrencyCode { get; private set; }
        
        // معلومات الاتصال
        public string Address { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public string Country { get; private set; }
        public string PostalCode { get; private set; }
        public string POBox { get; private set; }
        public string Phone { get; private set; }
        public string AlternatePhone { get; private set; }
        public string Fax { get; private set; }
        public string Email { get; private set; }
        public string Website { get; private set; }
        
        // معلومات الممثل القانوني
        public string LegalRepresentativeName { get; private set; }
        public string LegalRepresentativePosition { get; private set; }
        public string LegalRepresentativeIdNo { get; private set; }
        public string LegalRepresentativeIdType { get; private set; }
        public string LegalRepresentativePhone { get; private set; }
        public string LegalRepresentativeEmail { get; private set; }
        
        // إعدادات النظام
        public string BaseCurrencyCode { get; private set; }
        public string FiscalYearType { get; private set; }
        public int AccountingPeriods { get; private set; }
        public int DecimalPlaces { get; private set; }
        public string RoundingPolicy { get; private set; }
        public string BalanceDisplayMethod { get; private set; }
        public bool EnforceJournalBalance { get; private set; }
        public bool PreventUnbalancedJournals { get; private set; }
        public string DefaultLanguage { get; private set; }
        
        // العلاقات
        private readonly List<Branch> _branches = new List<Branch>();
        public IReadOnlyCollection<Branch> Branches => _branches.AsReadOnly();
        
        // محفوظة للقراءة فقط
        public DateTime EstablishmentDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime? LastModifiedAt { get; private set; }
        public string LastModifiedBy { get; private set; }

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private CompanyInfo() { }

        /// <summary>
        /// إنشاء كيان معلومات شركة جديد
        /// </summary>
        public static CompanyInfo Create(string nameAr, string nameEn, string taxRegistrationNo, string baseCurrencyCode)
        {
            if (string.IsNullOrWhiteSpace(nameAr))
                throw new ArgumentException("اسم الشركة بالعربية مطلوب", nameof(nameAr));
                
            if (string.IsNullOrWhiteSpace(taxRegistrationNo))
                throw new ArgumentException("الرقم الضريبي مطلوب", nameof(taxRegistrationNo));
                
            if (string.IsNullOrWhiteSpace(baseCurrencyCode))
                throw new ArgumentException("رمز العملة الأساسية مطلوب", nameof(baseCurrencyCode));

            return new CompanyInfo
            {
                Id = Guid.NewGuid(),
                NameAr = nameAr,
                NameEn = nameEn ?? nameAr,
                TaxRegistrationNo = taxRegistrationNo,
                BaseCurrencyCode = baseCurrencyCode,
                CapitalCurrencyCode = baseCurrencyCode,
                DecimalPlaces = 2,
                AccountingPeriods = 12,
                FiscalYearType = "Gregorian",
                RoundingPolicy = "Standard",
                BalanceDisplayMethod = "DebitCredit",
                DefaultLanguage = "ar",
                EnforceJournalBalance = true,
                PreventUnbalancedJournals = true,
                CreatedAt = DateTime.UtcNow
            };
        }

        /// <summary>
        /// تحديث المعلومات الأساسية للشركة
        /// </summary>
        public void UpdateBasicInfo(
            string nameAr, 
            string nameEn, 
            string commercialRegistrationNo, 
            DateTime? commercialRegistrationDate,
            string taxRegistrationNo,
            DateTime? taxRegistrationDate,
            string legalForm,
            decimal capital,
            string capitalCurrencyCode)
        {
            if (string.IsNullOrWhiteSpace(nameAr))
                throw new ArgumentException("اسم الشركة بالعربية مطلوب", nameof(nameAr));
            
            if (string.IsNullOrWhiteSpace(taxRegistrationNo))
                throw new ArgumentException("الرقم الضريبي مطلوب", nameof(taxRegistrationNo));
            
            NameAr = nameAr;
            NameEn = nameEn;
            CommercialRegistrationNo = commercialRegistrationNo;
            CommercialRegistrationDate = commercialRegistrationDate;
            TaxRegistrationNo = taxRegistrationNo;
            TaxRegistrationDate = taxRegistrationDate;
            LegalForm = legalForm;
            Capital = capital;
            CapitalCurrencyCode = capitalCurrencyCode;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// تحديث معلومات الاتصال للشركة
        /// </summary>
        public void UpdateContactInfo(
            string address,
            string city,
            string region,
            string country,
            string postalCode,
            string poBox,
            string phone,
            string alternatePhone,
            string fax,
            string email,
            string website)
        {
            Address = address;
            City = city;
            Region = region;
            Country = country;
            PostalCode = postalCode;
            POBox = poBox;
            Phone = phone;
            AlternatePhone = alternatePhone;
            Fax = fax;
            Email = email;
            Website = website;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// تحديث معلومات الممثل القانوني للشركة
        /// </summary>
        public void UpdateLegalRepresentative(
            string name,
            string position,
            string idNo,
            string idType,
            string phone,
            string email)
        {
            LegalRepresentativeName = name;
            LegalRepresentativePosition = position;
            LegalRepresentativeIdNo = idNo;
            LegalRepresentativeIdType = idType;
            LegalRepresentativePhone = phone;
            LegalRepresentativeEmail = email;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// تحديث إعدادات النظام الخاصة بالشركة
        /// </summary>
        public void UpdateSystemSettings(
            string baseCurrencyCode,
            string fiscalYearType,
            int accountingPeriods,
            int decimalPlaces,
            string roundingPolicy,
            string balanceDisplayMethod,
            bool enforceJournalBalance,
            bool preventUnbalancedJournals,
            string defaultLanguage)
        {
            if (string.IsNullOrWhiteSpace(baseCurrencyCode))
                throw new ArgumentException("رمز العملة الأساسية مطلوب", nameof(baseCurrencyCode));
            
            BaseCurrencyCode = baseCurrencyCode;
            FiscalYearType = fiscalYearType;
            AccountingPeriods = accountingPeriods;
            DecimalPlaces = decimalPlaces;
            RoundingPolicy = roundingPolicy;
            BalanceDisplayMethod = balanceDisplayMethod;
            EnforceJournalBalance = enforceJournalBalance;
            PreventUnbalancedJournals = preventUnbalancedJournals;
            DefaultLanguage = defaultLanguage;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// تحديث شعار الشركة
        /// </summary>
        public void UpdateLogo(string logoPath)
        {
            LogoPath = logoPath;
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// إضافة فرع جديد للشركة
        /// </summary>
        public void AddBranch(Branch branch)
        {
            if (branch == null)
                throw new ArgumentNullException(nameof(branch));
                
            _branches.Add(branch);
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// إزالة فرع من الشركة
        /// </summary>
        public void RemoveBranch(Branch branch)
        {
            if (branch == null)
                throw new ArgumentNullException(nameof(branch));
                
            _branches.Remove(branch);
            LastModifiedAt = DateTime.UtcNow;
        }
    }
} 