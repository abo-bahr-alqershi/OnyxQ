using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.Entities;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.Events
{
    #region CashInHand Events
    public class CashInHandCreatedEvent : DomainEvent
    {
        public CashInHand Cash { get; }

        public CashInHandCreatedEvent(CashInHand cash)
        {
            Cash = cash;
        }
    }

    public class CashInHandNamesUpdatedEvent : DomainEvent
    {
        public CashInHand Cash { get; }
        public string OldNameAr { get; }
        public string? OldNameEn { get; }

        public CashInHandNamesUpdatedEvent(CashInHand cash, string oldNameAr, string? oldNameEn)
        {
            Cash = cash;
            OldNameAr = oldNameAr;
            OldNameEn = oldNameEn;
        }
    }

    public class CashInHandSettingsUpdatedEvent : DomainEvent
    {
        public CashInHand Cash { get; }
        public CashSettings OldSettings { get; }
        public CashSettings NewSettings { get; }

        public CashInHandSettingsUpdatedEvent(CashInHand cash, CashSettings oldSettings, CashSettings newSettings)
        {
            Cash = cash;
            OldSettings = oldSettings;
            NewSettings = newSettings;
        }
    }

    public class CashInHandBalanceAddedEvent : DomainEvent
    {
        public CashInHand Cash { get; }
        public CashBalance Balance { get; }

        public CashInHandBalanceAddedEvent(CashInHand cash, CashBalance balance)
        {
            Cash = cash;
            Balance = balance;
        }
    }

    public class CashInHandConfirmedEvent : DomainEvent
    {
        public CashInHand Cash { get; }

        public CashInHandConfirmedEvent(CashInHand cash)
        {
            Cash = cash;
        }
    }
    #endregion

    #region CashAtBank Events
    public class CashAtBankCreatedEvent : DomainEvent
    {
        public CashAtBank Bank { get; }

        public CashAtBankCreatedEvent(CashAtBank bank)
        {
            Bank = bank;
        }
    }

    public class CashAtBankNamesUpdatedEvent : DomainEvent
    {
        public CashAtBank Bank { get; }
        public string OldNameAr { get; }
        public string? OldNameEn { get; }

        public CashAtBankNamesUpdatedEvent(CashAtBank bank, string oldNameAr, string? oldNameEn)
        {
            Bank = bank;
            OldNameAr = oldNameAr;
            OldNameEn = oldNameEn;
        }
    }

    public class CashAtBankContactInfoUpdatedEvent : DomainEvent
    {
        public CashAtBank Bank { get; }
        public BankContactInfo OldContactInfo { get; }
        public BankContactInfo NewContactInfo { get; }

        public CashAtBankContactInfoUpdatedEvent(CashAtBank bank, BankContactInfo oldContactInfo, BankContactInfo newContactInfo)
        {
            Bank = bank;
            OldContactInfo = oldContactInfo;
            NewContactInfo = newContactInfo;
        }
    }

    public class CashAtBankDocumentInfoUpdatedEvent : DomainEvent
    {
        public CashAtBank Bank { get; }
        public BankDocumentInfo OldDocumentInfo { get; }
        public BankDocumentInfo NewDocumentInfo { get; }

        public CashAtBankDocumentInfoUpdatedEvent(CashAtBank bank, BankDocumentInfo oldDocumentInfo, BankDocumentInfo newDocumentInfo)
        {
            Bank = bank;
            OldDocumentInfo = oldDocumentInfo;
            NewDocumentInfo = newDocumentInfo;
        }
    }

    public class CashAtBankSettingsUpdatedEvent : DomainEvent
    {
        public CashAtBank Bank { get; }
        public CashSettings OldSettings { get; }
        public CashSettings NewSettings { get; }

        public CashAtBankSettingsUpdatedEvent(CashAtBank bank, CashSettings oldSettings, CashSettings newSettings)
        {
            Bank = bank;
            OldSettings = oldSettings;
            NewSettings = newSettings;
        }
    }

    public class CashAtBankBalanceAddedEvent : DomainEvent
    {
        public CashAtBank Bank { get; }
        public CashBalance Balance { get; }

        public CashAtBankBalanceAddedEvent(CashAtBank bank, CashBalance balance)
        {
            Bank = bank;
            Balance = balance;
        }
    }

    public class CashAtBankConfirmedEvent : DomainEvent
    {
        public CashAtBank Bank { get; }

        public CashAtBankConfirmedEvent(CashAtBank bank)
        {
            Bank = bank;
        }
    }
    #endregion
} 