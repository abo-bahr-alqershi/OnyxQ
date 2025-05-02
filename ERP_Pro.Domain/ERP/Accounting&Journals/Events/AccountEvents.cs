using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public class AccountCreatedEvent : DomainEvent
    {
        public Account Account { get; }

        public AccountCreatedEvent(Account account)
        {
            Account = account;
        }
    }

    public class AccountNamesUpdatedEvent : DomainEvent
    {
        public Account Account { get; }
        public string OldNameAr { get; }
        public string? OldNameEn { get; }

        public AccountNamesUpdatedEvent(Account account, string oldNameAr, string? oldNameEn)
        {
            Account = account;
            OldNameAr = oldNameAr;
            OldNameEn = oldNameEn;
        }
    }

    public class AccountBalanceUpdatedEvent : DomainEvent
    {
        public Account Account { get; }
        public AccountBalance OldBalance { get; }
        public AccountBalance NewBalance { get; }

        public AccountBalanceUpdatedEvent(Account account, AccountBalance oldBalance, AccountBalance newBalance)
        {
            Account = account;
            OldBalance = oldBalance;
            NewBalance = newBalance;
        }
    }

    public class AccountSettingsUpdatedEvent : DomainEvent
    {
        public Account Account { get; }
        public AccountSettings OldSettings { get; }
        public AccountSettings NewSettings { get; }

        public AccountSettingsUpdatedEvent(Account account, AccountSettings oldSettings, AccountSettings newSettings)
        {
            Account = account;
            OldSettings = oldSettings;
            NewSettings = newSettings;
        }
    }

    public class AccountFlagsUpdatedEvent : DomainEvent
    {
        public Account Account { get; }
        public AccountFlags OldFlags { get; }
        public AccountFlags NewFlags { get; }

        public AccountFlagsUpdatedEvent(Account account, AccountFlags oldFlags, AccountFlags newFlags)
        {
            Account = account;
            OldFlags = oldFlags;
            NewFlags = newFlags;
        }
    }

    public class AccountActivatedEvent : DomainEvent
    {
        public Account Account { get; }

        public AccountActivatedEvent(Account account)
        {
            Account = account;
        }
    }

    public class AccountDeactivatedEvent : DomainEvent
    {
        public Account Account { get; }
        public string Reason { get; }

        public AccountDeactivatedEvent(Account account, string reason)
        {
            Account = account;
            Reason = reason;
        }
    }

    public class AccountParentChangedEvent : DomainEvent
    {
        public Account Account { get; }
        public Account OldParent { get; }
        public Account NewParent { get; }

        public AccountParentChangedEvent(Account account, Account oldParent, Account newParent)
        {
            Account = account;
            OldParent = oldParent;
            NewParent = newParent;
        }
    }
} 