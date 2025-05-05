using System;
using MediatR;
using ERP_Pro.Shared.Enums.Domain;
using ERP_Pro.Application.Features.Currencies.Dtos;

namespace ERP_Pro.Application.Features.Currencies.Commands
{
    /// <summary>
    /// أمر ربط حساب بالعملة
    /// </summary>
    public class LinkCurrencyAccountCommand : IRequest<CurrencyAccountDto>
    {
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
    }
} 