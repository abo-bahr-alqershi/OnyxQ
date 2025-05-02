using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.Events;
using ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.Entities
{
    public class UnitDescriptionItemDetail : Entity
    {
        #region Basic Info
        /// <summary> كود الصنف </summary>
        public string? ItemCode { get; private set; }
        /// <summary> تسلسل المستند </summary>
        public int? DocumentSequence { get; private set; }
        #endregion

        #region Unit Info
        public UnitInfo UnitInfo { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        public UnitDescriptionItemMaster UnitDescriptionItemMaster { get; private set; }
        #endregion

        private UnitDescriptionItemDetail() { } // For EF Core

        public static UnitDescriptionItemDetail Create(
            string? itemCode,
            int? documentSequence,
            UnitInfo unitInfo,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var detail = new UnitDescriptionItemDetail
            {
                ItemCode = itemCode,
                DocumentSequence = documentSequence,
                UnitInfo = unitInfo,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.CreateNew(userId, terminal)
            };

            detail.AddDomainEvent(new UnitDescriptionItemDetailCreatedEvent(detail));
            return detail;
        }

        public void UpdateUnitInfo(
            UnitInfo unitInfo,
            int userId,
            string terminal)
        {
            UnitInfo = unitInfo;
            AuditInfo = AuditInfo.Update(userId, DateTime.UtcNow, terminal);
            AddDomainEvent(new UnitDescriptionItemDetailUpdatedEvent(this));
        }

        private void ValidateState()
        {
            if (UnitInfo == null)
                throw new DomainException("Unit info is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");

            if (AuditInfo == null)
                throw new DomainException("Audit info is required");
        }
    }
}