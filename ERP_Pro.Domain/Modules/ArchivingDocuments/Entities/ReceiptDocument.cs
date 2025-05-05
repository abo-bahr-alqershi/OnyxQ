using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.HumanResources.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;

using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// ReceiptDocument Entity
/// </summary>
public class ReceiptDocument : Entity<ReceiptDocumentId>
{

    private ReceiptDocument() { }

    public ReceiptDocument(ReceiptDocumentId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the ReceiptDocument
    /// المعرف الفريد لـ ReceiptDocument
    /// </summary>
    public ReceiptDocumentId Id { get; private set; }

    /// <summary>
    /// DocNo of the ReceiptDocument
    /// DocNo الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the ReceiptDocument
    /// DocSer الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the ReceiptDocument
    /// DocDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// MaintenanceType of the ReceiptDocument
    /// MaintenanceType الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? MaintenanceType { get; private set; }

    /// <summary>
    /// SerialNumber of the ReceiptDocument
    /// SerialNumber الخاص بـ ReceiptDocument
    /// </summary>
    public string SerialNumber { get; private set; }

    /// <summary>
    /// ItemNameFull of the ReceiptDocument
    /// ItemNameFull الخاص بـ ReceiptDocument
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemUnit of the ReceiptDocument
    /// ItemUnit الخاص بـ ReceiptDocument
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ReceiptDocument
    /// PSize الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// AttendanceItem of the ReceiptDocument
    /// AttendanceItem الخاص بـ ReceiptDocument
    /// </summary>
    public string AttendanceItem { get; private set; }

    /// <summary>
    /// DocDesc of the ReceiptDocument
    /// DocDesc الخاص بـ ReceiptDocument
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// DfltDlvryDate of the ReceiptDocument
    /// DfltDlvryDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? DfltDlvryDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the ReceiptDocument
    /// ReferenceNumber الخاص بـ ReceiptDocument
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CName of the ReceiptDocument
    /// CName الخاص بـ ReceiptDocument
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// CAddress of the ReceiptDocument
    /// CAddress الخاص بـ ReceiptDocument
    /// </summary>
    public string CAddress { get; private set; }

    /// <summary>
    /// CTel of the ReceiptDocument
    /// CTel الخاص بـ ReceiptDocument
    /// </summary>
    public string CTel { get; private set; }

    /// <summary>
    /// CProblem of the ReceiptDocument
    /// CProblem الخاص بـ ReceiptDocument
    /// </summary>
    public string CProblem { get; private set; }

    /// <summary>
    /// EngineerTransactionDate of the ReceiptDocument
    /// EngineerTransactionDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? EngineerTransactionDate { get; private set; }

    /// <summary>
    /// RepEngineerTest of the ReceiptDocument
    /// RepEngineerTest الخاص بـ ReceiptDocument
    /// </summary>
    public string RepEngineerTest { get; private set; }

    /// <summary>
    /// CardCode of the ReceiptDocument
    /// CardCode الخاص بـ ReceiptDocument
    /// </summary>
    public string CardCode { get; private set; }

    /// <summary>
    /// PlateCode of the ReceiptDocument
    /// PlateCode الخاص بـ ReceiptDocument
    /// </summary>
    public string PlateCode { get; private set; }

    /// <summary>
    /// CountryNumber of the ReceiptDocument
    /// CountryNumber الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ModelCode of the ReceiptDocument
    /// ModelCode الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ModelCode { get; private set; }

    /// <summary>
    /// Odometer of the ReceiptDocument
    /// Odometer الخاص بـ ReceiptDocument
    /// </summary>
    public string Odometer { get; private set; }

    /// <summary>
    /// CannotMaintainFlag of the ReceiptDocument
    /// CannotMaintainFlag الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? CannotMaintainFlag { get; private set; }

    /// <summary>
    /// ReturnToCustomer of the ReceiptDocument
    /// ReturnToCustomer الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ReturnToCustomer { get; private set; }

    /// <summary>
    /// ReceiptDate of the ReceiptDocument
    /// ReceiptDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? ReceiptDate { get; private set; }

    /// <summary>
    /// ReceiverName of the ReceiptDocument
    /// ReceiverName الخاص بـ ReceiptDocument
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// ItemReadyFlag of the ReceiptDocument
    /// ItemReadyFlag الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ItemReadyFlag { get; private set; }

    /// <summary>
    /// DocSerRef of the ReceiptDocument
    /// DocSerRef الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocNoRef of the ReceiptDocument
    /// DocNoRef الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// BillNumber of the ReceiptDocument
    /// BillNumber الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the ReceiptDocument
    /// BillSerial الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillDate of the ReceiptDocument
    /// BillDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the ReceiptDocument
    /// BillDocumentTypeFull الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DfltDlvryTime of the ReceiptDocument
    /// DfltDlvryTime الخاص بـ ReceiptDocument
    /// </summary>
    public string DfltDlvryTime { get; private set; }

    /// <summary>
    /// Status of the ReceiptDocument
    /// Status الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? Status { get; private set; }

    /// <summary>
    /// GrantCardNumber of the ReceiptDocument
    /// GrantCardNumber الخاص بـ ReceiptDocument
    /// </summary>
    public string GrantCardNumber { get; private set; }

    /// <summary>
    /// GrantPeriod of the ReceiptDocument
    /// GrantPeriod الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? GrantPeriod { get; private set; }

    /// <summary>
    /// GrantEndDate of the ReceiptDocument
    /// GrantEndDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? GrantEndDate { get; private set; }

    /// <summary>
    /// CameBy of the ReceiptDocument
    /// CameBy الخاص بـ ReceiptDocument
    /// </summary>
    public string CameBy { get; private set; }

    /// <summary>
    /// ActivityNumber of the ReceiptDocument
    /// ActivityNumber الخاص بـ ReceiptDocument
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ProjectNumber of the ReceiptDocument
    /// ProjectNumber الخاص بـ ReceiptDocument
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ProblemType of the ReceiptDocument
    /// ProblemType الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ProblemType { get; private set; }

    /// <summary>
    /// ProblemReason of the ReceiptDocument
    /// ProblemReason الخاص بـ ReceiptDocument
    /// </summary>
    public string ProblemReason { get; private set; }

    /// <summary>
    /// TestUserId of the ReceiptDocument
    /// TestUserId الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? TestUserId { get; private set; }

    /// <summary>
    /// TestUpdateDate of the ReceiptDocument
    /// TestUpdateDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? TestUpdateDate { get; private set; }

    /// <summary>
    /// AgreementFlag of the ReceiptDocument
    /// AgreementFlag الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? AgreementFlag { get; private set; }

    /// <summary>
    /// AgreementDate of the ReceiptDocument
    /// AgreementDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? AgreementDate { get; private set; }

    /// <summary>
    /// AgreementDescription of the ReceiptDocument
    /// AgreementDescription الخاص بـ ReceiptDocument
    /// </summary>
    public string AgreementDescription { get; private set; }

    /// <summary>
    /// AgreementUpdatedByUserId of the ReceiptDocument
    /// AgreementUpdatedByUserId الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? AgreementUpdatedByUserId { get; private set; }

    /// <summary>
    /// AgreementUpdatedDate of the ReceiptDocument
    /// AgreementUpdatedDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? AgreementUpdatedDate { get; private set; }

    /// <summary>
    /// MaintenanceDate of the ReceiptDocument
    /// MaintenanceDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? MaintenanceDate { get; private set; }

    /// <summary>
    /// MaintenanceEngineerId of the ReceiptDocument
    /// MaintenanceEngineerId الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? MaintenanceEngineerId { get; private set; }

    /// <summary>
    /// ItemStatusDescription of the ReceiptDocument
    /// ItemStatusDescription الخاص بـ ReceiptDocument
    /// </summary>
    public string ItemStatusDescription { get; private set; }

    /// <summary>
    /// MaintenanceEngineerDescription of the ReceiptDocument
    /// MaintenanceEngineerDescription الخاص بـ ReceiptDocument
    /// </summary>
    public string MaintenanceEngineerDescription { get; private set; }

    /// <summary>
    /// ItemStatus of the ReceiptDocument
    /// ItemStatus الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ItemStatus { get; private set; }

    /// <summary>
    /// MaintenanceEndDate of the ReceiptDocument
    /// MaintenanceEndDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? MaintenanceEndDate { get; private set; }

    /// <summary>
    /// MaintenanceUpdateUserId of the ReceiptDocument
    /// MaintenanceUpdateUserId الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? MaintenanceUpdateUserId { get; private set; }

    /// <summary>
    /// MaintenanceUpdateDate of the ReceiptDocument
    /// MaintenanceUpdateDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? MaintenanceUpdateDate { get; private set; }

    /// <summary>
    /// IssueDescription of the ReceiptDocument
    /// IssueDescription الخاص بـ ReceiptDocument
    /// </summary>
    public string IssueDescription { get; private set; }

    /// <summary>
    /// IssueUserId of the ReceiptDocument
    /// IssueUserId الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? IssueUserId { get; private set; }

    /// <summary>
    /// IssueUpdateDate of the ReceiptDocument
    /// IssueUpdateDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? IssueUpdateDate { get; private set; }

    /// <summary>
    /// RepCode of the ReceiptDocument
    /// RepCode الخاص بـ ReceiptDocument
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ApprovalReceivedFlag of the ReceiptDocument
    /// ApprovalReceivedFlag الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ApprovalReceivedFlag { get; private set; }

    /// <summary>
    /// ApprovalReceivedUserId of the ReceiptDocument
    /// ApprovalReceivedUserId الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ApprovalReceivedUserId { get; private set; }

    /// <summary>
    /// ApprovalReceivedDate of the ReceiptDocument
    /// ApprovalReceivedDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? ApprovalReceivedDate { get; private set; }

    /// <summary>
    /// ApprovalCheckFlag of the ReceiptDocument
    /// ApprovalCheckFlag الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ApprovalCheckFlag { get; private set; }

    /// <summary>
    /// ApprovalCheckUserId of the ReceiptDocument
    /// ApprovalCheckUserId الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ApprovalCheckUserId { get; private set; }

    /// <summary>
    /// ApprovalCheckDate of the ReceiptDocument
    /// ApprovalCheckDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? ApprovalCheckDate { get; private set; }

    /// <summary>
    /// ApprovalMaintenanceFlag of the ReceiptDocument
    /// ApprovalMaintenanceFlag الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ApprovalMaintenanceFlag { get; private set; }

    /// <summary>
    /// ApprovalMaintenanceUserId of the ReceiptDocument
    /// ApprovalMaintenanceUserId الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ApprovalMaintenanceUserId { get; private set; }

    /// <summary>
    /// ApprovalMaintenanceDate of the ReceiptDocument
    /// ApprovalMaintenanceDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? ApprovalMaintenanceDate { get; private set; }

    /// <summary>
    /// ApprovalAgreementFlag of the ReceiptDocument
    /// ApprovalAgreementFlag الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ApprovalAgreementFlag { get; private set; }

    /// <summary>
    /// ApprovalAgreementUserId of the ReceiptDocument
    /// ApprovalAgreementUserId الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ApprovalAgreementUserId { get; private set; }

    /// <summary>
    /// ApprovalAgreementDate of the ReceiptDocument
    /// ApprovalAgreementDate الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? ApprovalAgreementDate { get; private set; }

    /// <summary>
    /// BillRecordNumber of the ReceiptDocument
    /// BillRecordNumber الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? BillRecordNumber { get; private set; }

    /// <summary>
    /// ReceiptTypeNumber of the ReceiptDocument
    /// ReceiptTypeNumber الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ReceiptTypeNumber { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the ReceiptDocument
    /// ProcessedFlagFull الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// GrantType of the ReceiptDocument
    /// GrantType الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? GrantType { get; private set; }

    /// <summary>
    /// DstncCuntr of the ReceiptDocument
    /// DstncCuntr الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? DstncCuntr { get; private set; }

    /// <summary>
    /// WarehouseCode of the ReceiptDocument
    /// WarehouseCode الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// Field1Old of the ReceiptDocument
    /// Field1Old الخاص بـ ReceiptDocument
    /// </summary>
    public string Field1Old { get; private set; }

    /// <summary>
    /// Field2Old of the ReceiptDocument
    /// Field2Old الخاص بـ ReceiptDocument
    /// </summary>
    public string Field2Old { get; private set; }

    /// <summary>
    /// Field3Old of the ReceiptDocument
    /// Field3Old الخاص بـ ReceiptDocument
    /// </summary>
    public string Field3Old { get; private set; }

    /// <summary>
    /// Field4Old of the ReceiptDocument
    /// Field4Old الخاص بـ ReceiptDocument
    /// </summary>
    public string Field4Old { get; private set; }

    /// <summary>
    /// Field5Old of the ReceiptDocument
    /// Field5Old الخاص بـ ReceiptDocument
    /// </summary>
    public string Field5Old { get; private set; }

    /// <summary>
    /// Field6Old of the ReceiptDocument
    /// Field6Old الخاص بـ ReceiptDocument
    /// </summary>
    public string Field6Old { get; private set; }

    /// <summary>
    /// Field7Old of the ReceiptDocument
    /// Field7Old الخاص بـ ReceiptDocument
    /// </summary>
    public string Field7Old { get; private set; }

    /// <summary>
    /// Field8Old of the ReceiptDocument
    /// Field8Old الخاص بـ ReceiptDocument
    /// </summary>
    public string Field8Old { get; private set; }

    /// <summary>
    /// Field9Old of the ReceiptDocument
    /// Field9Old الخاص بـ ReceiptDocument
    /// </summary>
    public string Field9Old { get; private set; }

    /// <summary>
    /// Field10Old of the ReceiptDocument
    /// Field10Old الخاص بـ ReceiptDocument
    /// </summary>
    public string Field10Old { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ReceiptDocument
    /// CompanyNumberShort الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ReceiptDocument
    /// BranchNumber الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ReceiptDocument
    /// BranchYear الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ReceiptDocument
    /// BranchUser الخاص بـ ReceiptDocument
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CreatedDateClock of the ReceiptDocument
    /// CreatedDateClock الخاص بـ ReceiptDocument
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Employee Employee { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public DeviceTypes DeviceTypes { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

