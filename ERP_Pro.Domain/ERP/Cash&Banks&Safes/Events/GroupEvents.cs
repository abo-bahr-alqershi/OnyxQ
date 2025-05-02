using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.Entities;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.Events
{
    #region CashGroup Events
    public class CashGroupCreatedEvent : DomainEvent
    {
        public CashGroup Group { get; }

        public CashGroupCreatedEvent(CashGroup group)
        {
            Group = group;
        }
    }

    public class CashGroupNamesUpdatedEvent : DomainEvent
    {
        public CashGroup Group { get; }
        public string OldNameAr { get; }
        public string? OldNameEn { get; }

        public CashGroupNamesUpdatedEvent(CashGroup group, string oldNameAr, string? oldNameEn)
        {
            Group = group;
            OldNameAr = oldNameAr;
            OldNameEn = oldNameEn;
        }
    }

    public class CashGroupStatusUpdatedEvent : DomainEvent
    {
        public CashGroup Group { get; }

        public CashGroupStatusUpdatedEvent(CashGroup group)
        {
            Group = group;
        }
    }

    public class CashGroupNotesUpdatedEvent : DomainEvent
    {
        public CashGroup Group { get; }

        public CashGroupNotesUpdatedEvent(CashGroup group)
        {
            Group = group;
        }
    }
    #endregion

    #region BankGroup Events
    public class BankGroupCreatedEvent : DomainEvent
    {
        public BankGroup Group { get; }

        public BankGroupCreatedEvent(BankGroup group)
        {
            Group = group;
        }
    }

    public class BankGroupNamesUpdatedEvent : DomainEvent
    {
        public BankGroup Group { get; }
        public string OldNameAr { get; }
        public string? OldNameEn { get; }

        public BankGroupNamesUpdatedEvent(BankGroup group, string oldNameAr, string? oldNameEn)
        {
            Group = group;
            OldNameAr = oldNameAr;
            OldNameEn = oldNameEn;
        }
    }

    public class BankGroupStatusUpdatedEvent : DomainEvent
    {
        public BankGroup Group { get; }

        public BankGroupStatusUpdatedEvent(BankGroup group)
        {
            Group = group;
        }
    }

    public class BankGroupNotesUpdatedEvent : DomainEvent
    {
        public BankGroup Group { get; }

        public BankGroupNotesUpdatedEvent(BankGroup group)
        {
            Group = group;
        }
    }
    #endregion
} 