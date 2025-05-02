using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects
{
    public class AuditInfo : ValueObject
    {
        public int? AddedUserId { get; private set; }
        public DateTime? AddedDate { get; private set; }
        public int? UpdatedUserId { get; private set; }
        public DateTime? UpdatedDate { get; private set; }
        public long UpdateCount { get; private set; }
        public int? PrintReport { get; private set; }
        public string? AddedTerminal { get; private set; }
        public string? UpdatedTerminal { get; private set; }

        private AuditInfo() { } // For EF Core

        public AuditInfo(
            int? addedUserId = null,
            DateTime? addedDate = null,
            int? updatedUserId = null,
            DateTime? updatedDate = null,
            long updateCount = 0,
            int? printReport = null,
            string? addedTerminal = null,
            string? updatedTerminal = null)
        {
            AddedUserId = addedUserId;
            AddedDate = addedDate;
            UpdatedUserId = updatedUserId;
            UpdatedDate = updatedDate;
            UpdateCount = updateCount;
            PrintReport = printReport;
            AddedTerminal = addedTerminal;
            UpdatedTerminal = updatedTerminal;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return AddedUserId ?? 0;
            yield return AddedDate ?? DateTime.MinValue;
            yield return UpdatedUserId ?? 0;
            yield return UpdatedDate ?? DateTime.MinValue;
            yield return UpdateCount;
            yield return PrintReport ?? 0;
            yield return AddedTerminal ?? string.Empty;
            yield return UpdatedTerminal ?? string.Empty;
        }

        public AuditInfo Update(
            int? updatedUserId,
            DateTime? updatedDate = null,
            string? updatedTerminal = null)
        {
            return new AuditInfo(
                AddedUserId,
                AddedDate,
                updatedUserId,
                updatedDate ?? DateTime.UtcNow,
                UpdateCount + 1,
                PrintReport,
                AddedTerminal,
                updatedTerminal ?? UpdatedTerminal
            );
        }

        public static AuditInfo CreateNew(
            int addedUserId,
            string? addedTerminal = null)
        {
            return new AuditInfo(
                addedUserId,
                DateTime.UtcNow,
                null,
                null,
                0,
                null,
                addedTerminal,
                null
            );
        }
    }
} 