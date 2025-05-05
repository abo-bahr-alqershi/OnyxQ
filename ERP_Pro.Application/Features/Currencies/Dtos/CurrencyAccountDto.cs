using System;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Features.Currencies.Dtos
{
    /// <summary>
    /// DTO حساب العملة
    /// </summary>
    public class CurrencyAccountDto
    {
        /// <summary>
        /// المعرف الفريد
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }

        /// <summary>
        /// نوع الحساب
        /// </summary>
        public CurrencyAccountTypeEnum AccountType { get; set; }

        /// <summary>
        /// رقم الحساب
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// اسم الحساب
        /// </summary>
        public string AccountName { get; set; }
        
        /// <summary>
        /// وصف نوع الحساب
        /// </summary>
        public string AccountTypeDescription { get; set; }
    }
} 