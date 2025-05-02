using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class WarehouseTransferExpenseBranch : AggregateRoot
    {
        #region Basic Info
        /// <summary> رقم المستند. </summary>
        public long DocNo { get; private set; }
        /// <summary> الرقم التسلسلي للمستند. </summary>
        public long DocSerial { get; private set; }
        /// <summary> نوع التحويل: وارد/صادر. </summary>
        public short TransferInOutType { get; private set; }
        /// <summary> وصف المستند. </summary>
        public string? DocDesc { get; private set; }
        /// <summary> رقم مرجعي إضافي. </summary>
        public string? RefNo { get; private set; }
        /// <summary> علم الترحيل الخارجي. </summary>
        public int? ExternalPost { get; private set; }
        /// <summary> رقم السطر الداخلي. </summary>
        public int? RecordNo { get; private set; }
        /// <summary> رقم فرع المستند. </summary>
        public int? DocBranchNo { get; private set; }
        #endregion

        #region Transfer Info
        public TransferExpenseInfo ExpenseInfo { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        private WarehouseTransferExpenseBranch() { }

        public static WarehouseTransferExpenseBranch Create(
            long docNo,
            long docSerial,
            short transferInOutType,
            string? docDesc,
            string? refNo,
            int? externalPost,
            int? recordNo,
            int? docBranchNo,
            TransferExpenseInfo expenseInfo,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var transfer = new WarehouseTransferExpenseBranch
            {
                DocNo = docNo,
                DocSerial = docSerial,
                TransferInOutType = transferInOutType,
                DocDesc = docDesc,
                RefNo = refNo,
                ExternalPost = externalPost,
                RecordNo = recordNo,
                DocBranchNo = docBranchNo,
                ExpenseInfo = expenseInfo,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.CreateNew(userId, terminal)
            };

            transfer.AddDomainEvent(new WarehouseTransferExpenseBranchCreatedEvent(transfer));
            return transfer;
        }

        public void UpdateExpenseInfo(
            TransferExpenseInfo expenseInfo,
            int userId,
            string terminal)
        {
            ExpenseInfo = expenseInfo;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new WarehouseTransferExpenseBranchUpdatedEvent(this));
        }

        private void ValidateState()
        {
            if (DocNo <= 0)
                throw new DomainException("Document number must be positive");

            if (DocSerial <= 0)
                throw new DomainException("Document serial must be positive");

            if (ExpenseInfo == null)
                throw new DomainException("Expense info is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (AuditInfo == null)
                throw new DomainException("Audit info is required");
        }
    }
}