using System;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.ChangeCurrencyStatus
{
    /// <summary>
    /// أمر تغيير حالة عملة (تفعيل/تعطيل)
    /// </summary>
    public class ChangeCurrencyStatusCommand : IRequest<bool>
    {
        public Guid Id { get; }
        public bool Activate { get; }

        public ChangeCurrencyStatusCommand(Guid id, bool activate)
        {
            Id = id;
            Activate = activate;
        }
    }
} 