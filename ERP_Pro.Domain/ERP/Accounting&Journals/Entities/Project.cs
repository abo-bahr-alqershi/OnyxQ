using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class Project : AggregateRoot
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> رمز المشروع </summary>
        public string Code { get; private set; }
        /// <summary> اسم المشروع بالعربي </summary>
        public string NameAr { get; private set; }
        /// <summary> اسم المشروع بالإنجليزي </summary>
        public string? NameEn { get; private set; }
        /// <summary> وصف المشروع </summary>
        public string? Description { get; private set; }
        /// <summary> تاريخ بداية المشروع </summary>
        public DateTime StartDate { get; private set; }
        /// <summary> تاريخ نهاية المشروع </summary>
        public DateTime? EndDate { get; private set; }
        /// <summary> حالة المشروع </summary>
        public ProjectStatus Status { get; private set; }
        /// <summary> نوع المشروع </summary>
        public ProjectType Type { get; private set; }
        /// <summary> الميزانية المخططة </summary>
        public decimal PlannedBudget { get; private set; }
        /// <summary> الميزانية الفعلية </summary>
        public decimal ActualBudget { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        public virtual IReadOnlyCollection<JournalDetail> JournalDetails => _journalDetails.AsReadOnly();
        public virtual IReadOnlyCollection<VoucherDetail> VoucherDetails => _voucherDetails.AsReadOnly();
        #endregion

        #region Private Collections
        private readonly List<JournalDetail> _journalDetails = new();
        private readonly List<VoucherDetail> _voucherDetails = new();
        #endregion

        private Project() { } // For EF Core

        public static Project Create(
            string code,
            string nameAr,
            string? nameEn,
            string? description,
            DateTime startDate,
            DateTime? endDate,
            ProjectType type,
            decimal plannedBudget,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var project = new Project
            {
                Id = Guid.NewGuid(),
                Code = code,
                NameAr = nameAr,
                NameEn = nameEn,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                Status = ProjectStatus.Planning,
                Type = type,
                PlannedBudget = plannedBudget,
                ActualBudget = 0,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            project.AddDomainEvent(new ProjectCreatedEvent(project));
            return project;
        }

        public void UpdateNames(string nameAr, string? nameEn)
        {
            var oldNameAr = NameAr;
            var oldNameEn = NameEn;

            NameAr = nameAr;
            NameEn = nameEn;

            AddDomainEvent(new ProjectNamesUpdatedEvent(this, oldNameAr, oldNameEn));
        }

        public void UpdateDescription(string? description)
        {
            var oldDescription = Description;
            Description = description;

            AddDomainEvent(new ProjectDescriptionUpdatedEvent(this, oldDescription));
        }

        public void UpdateDates(DateTime startDate, DateTime? endDate)
        {
            var oldStartDate = StartDate;
            var oldEndDate = EndDate;

            StartDate = startDate;
            EndDate = endDate;

            AddDomainEvent(new ProjectDatesUpdatedEvent(this, oldStartDate, oldEndDate));
        }

        public void UpdateBudget(decimal plannedBudget)
        {
            var oldPlannedBudget = PlannedBudget;
            PlannedBudget = plannedBudget;

            AddDomainEvent(new ProjectBudgetUpdatedEvent(this, oldPlannedBudget));
        }

        public void Start()
        {
            if (Status != ProjectStatus.Planning)
                throw new DomainException("Project can only be started when in planning status");

            Status = ProjectStatus.InProgress;
            AddDomainEvent(new ProjectStartedEvent(this));
        }

        public void Complete()
        {
            if (Status != ProjectStatus.InProgress)
                throw new DomainException("Project can only be completed when in progress");

            Status = ProjectStatus.Completed;
            EndDate = DateTime.UtcNow;

            AddDomainEvent(new ProjectCompletedEvent(this));
        }

        public void Cancel()
        {
            if (Status == ProjectStatus.Completed || Status == ProjectStatus.Cancelled)
                throw new DomainException("Project cannot be cancelled when completed or already cancelled");

            Status = ProjectStatus.Cancelled;
            EndDate = DateTime.UtcNow;

            AddDomainEvent(new ProjectCancelledEvent(this));
        }

        private void ValidateState()
        {
            if (string.IsNullOrWhiteSpace(Code))
                throw new DomainException("Project code is required");

            if (string.IsNullOrWhiteSpace(NameAr))
                throw new DomainException("Project Arabic name is required");

            if (StartDate == default)
                throw new DomainException("Project start date is required");

            if (EndDate.HasValue && EndDate.Value < StartDate)
                throw new DomainException("Project end date cannot be earlier than start date");

            if (Type == null)
                throw new DomainException("Project type is required");

            if (PlannedBudget < 0)
                throw new DomainException("Project planned budget cannot be negative");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");
        }
    }

    public enum ProjectStatus
    {
        /// <summary> تخطيط </summary>
        Planning = 1,
        /// <summary> قيد التنفيذ </summary>
        InProgress = 2,
        /// <summary> مكتمل </summary>
        Completed = 3,
        /// <summary> ملغي </summary>
        Cancelled = 4
    }

    public enum ProjectType
    {
        /// <summary> مشروع داخلي </summary>
        Internal = 1,
        /// <summary> مشروع خارجي </summary>
        External = 2,
        /// <summary> مشروع استثماري </summary>
        Investment = 3,
        /// <summary> مشروع تطويري </summary>
        Development = 4
    }
} 