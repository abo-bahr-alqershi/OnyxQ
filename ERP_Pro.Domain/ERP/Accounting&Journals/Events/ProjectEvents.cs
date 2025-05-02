using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public record ProjectCreatedEvent : IDomainEvent
    {
        public Project Project { get; }
        public DateTime OccurredOn { get; }

        public ProjectCreatedEvent(Project project)
        {
            Project = project;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record ProjectNamesUpdatedEvent : IDomainEvent
    {
        public Project Project { get; }
        public string OldNameAr { get; }
        public string? OldNameEn { get; }
        public DateTime OccurredOn { get; }

        public ProjectNamesUpdatedEvent(Project project, string oldNameAr, string? oldNameEn)
        {
            Project = project;
            OldNameAr = oldNameAr;
            OldNameEn = oldNameEn;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record ProjectDescriptionUpdatedEvent : IDomainEvent
    {
        public Project Project { get; }
        public string? OldDescription { get; }
        public DateTime OccurredOn { get; }

        public ProjectDescriptionUpdatedEvent(Project project, string? oldDescription)
        {
            Project = project;
            OldDescription = oldDescription;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record ProjectDatesUpdatedEvent : IDomainEvent
    {
        public Project Project { get; }
        public DateTime OldStartDate { get; }
        public DateTime? OldEndDate { get; }
        public DateTime OccurredOn { get; }

        public ProjectDatesUpdatedEvent(Project project, DateTime oldStartDate, DateTime? oldEndDate)
        {
            Project = project;
            OldStartDate = oldStartDate;
            OldEndDate = oldEndDate;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record ProjectBudgetUpdatedEvent : IDomainEvent
    {
        public Project Project { get; }
        public decimal OldPlannedBudget { get; }
        public DateTime OccurredOn { get; }

        public ProjectBudgetUpdatedEvent(Project project, decimal oldPlannedBudget)
        {
            Project = project;
            OldPlannedBudget = oldPlannedBudget;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record ProjectStartedEvent : IDomainEvent
    {
        public Project Project { get; }
        public DateTime OccurredOn { get; }

        public ProjectStartedEvent(Project project)
        {
            Project = project;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record ProjectCompletedEvent : IDomainEvent
    {
        public Project Project { get; }
        public DateTime OccurredOn { get; }

        public ProjectCompletedEvent(Project project)
        {
            Project = project;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record ProjectCancelledEvent : IDomainEvent
    {
        public Project Project { get; }
        public DateTime OccurredOn { get; }

        public ProjectCancelledEvent(Project project)
        {
            Project = project;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 