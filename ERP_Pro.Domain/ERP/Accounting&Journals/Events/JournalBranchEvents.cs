using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public record JournalBranchCreatedEvent : IDomainEvent
    {
        public MasterJournalBranch Journal { get; }
        public DateTime OccurredOn { get; }

        public JournalBranchCreatedEvent(MasterJournalBranch journal)
        {
            Journal = journal;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record JournalBranchPostedEvent : IDomainEvent
    {
        public MasterJournalBranch Journal { get; }
        public DateTime OccurredOn { get; }

        public JournalBranchPostedEvent(MasterJournalBranch journal)
        {
            Journal = journal;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record JournalBranchUnpostedEvent : IDomainEvent
    {
        public MasterJournalBranch Journal { get; }
        public DateTime OccurredOn { get; }

        public JournalBranchUnpostedEvent(MasterJournalBranch journal)
        {
            Journal = journal;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record JournalBranchDescriptionUpdatedEvent : IDomainEvent
    {
        public MasterJournalBranch Journal { get; }
        public string OldBeneficiaryName { get; }
        public string OldReceiverName { get; }
        public string OldDescription { get; }
        public DateTime OccurredOn { get; }

        public JournalBranchDescriptionUpdatedEvent(
            MasterJournalBranch journal,
            string oldBeneficiaryName,
            string oldReceiverName,
            string oldDescription)
        {
            Journal = journal;
            OldBeneficiaryName = oldBeneficiaryName;
            OldReceiverName = oldReceiverName;
            OldDescription = oldDescription;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record JournalBranchAuditedEvent : IDomainEvent
    {
        public MasterJournalBranch Journal { get; }
        public DateTime OccurredOn { get; }

        public JournalBranchAuditedEvent(MasterJournalBranch journal)
        {
            Journal = journal;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 