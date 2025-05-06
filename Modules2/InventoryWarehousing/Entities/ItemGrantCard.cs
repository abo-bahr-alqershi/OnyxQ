using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemGrantCard Entity
/// </summary>
public class ItemGrantCard : Entity<ItemGrantCardId>
{

    private ItemGrantCard() { }

    public ItemGrantCard(ItemGrantCardId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the ItemGrantCard
    /// المعرف الفريد لـ ItemGrantCard
    /// </summary>
    public ItemGrantCardId Id { get; private set; }

    /// <summary>
    /// DocNo of the ItemGrantCard
    /// DocNo الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the ItemGrantCard
    /// DocSer الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the ItemGrantCard
    /// DocDate الخاص بـ ItemGrantCard
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the ItemGrantCard
    /// ReferenceNumber الخاص بـ ItemGrantCard
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// GrantDescription of the ItemGrantCard
    /// GrantDescription الخاص بـ ItemGrantCard
    /// </summary>
    public string GrantDescription { get; private set; }

    /// <summary>
    /// GrantCardNumber of the ItemGrantCard
    /// GrantCardNumber الخاص بـ ItemGrantCard
    /// </summary>
    public string GrantCardNumber { get; private set; }

    /// <summary>
    /// ItemCode of the ItemGrantCard
    /// ItemCode الخاص بـ ItemGrantCard
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemGrantCard
    /// ItemUnit الخاص بـ ItemGrantCard
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ItemGrantCard
    /// PSize الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// SerialNumber of the ItemGrantCard
    /// SerialNumber الخاص بـ ItemGrantCard
    /// </summary>
    public string SerialNumber { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the ItemGrantCard
    /// BillDocumentTypeFull الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the ItemGrantCard
    /// BillNumber الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the ItemGrantCard
    /// BillSerial الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillDate of the ItemGrantCard
    /// BillDate الخاص بـ ItemGrantCard
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// CCode of the ItemGrantCard
    /// CCode الخاص بـ ItemGrantCard
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the ItemGrantCard
    /// CName الخاص بـ ItemGrantCard
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// BillRecordNumber of the ItemGrantCard
    /// BillRecordNumber الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? BillRecordNumber { get; private set; }

    /// <summary>
    /// GrantPeriod of the ItemGrantCard
    /// GrantPeriod الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? GrantPeriod { get; private set; }

    /// <summary>
    /// GrantEndDate of the ItemGrantCard
    /// GrantEndDate الخاص بـ ItemGrantCard
    /// </summary>
    public DateTime? GrantEndDate { get; private set; }

    /// <summary>
    /// SaleDirection of the ItemGrantCard
    /// SaleDirection الخاص بـ ItemGrantCard
    /// </summary>
    public string SaleDirection { get; private set; }

    /// <summary>
    /// ReturnBillSerial of the ItemGrantCard
    /// ReturnBillSerial الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? ReturnBillSerial { get; private set; }

    /// <summary>
    /// Terminal of the ItemGrantCard
    /// Terminal الخاص بـ ItemGrantCard
    /// </summary>
    public string Terminal { get; private set; }

    /// <summary>
    /// GrantDocumentSource of the ItemGrantCard
    /// GrantDocumentSource الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? GrantDocumentSource { get; private set; }

    /// <summary>
    /// GrantStartDate of the ItemGrantCard
    /// GrantStartDate الخاص بـ ItemGrantCard
    /// </summary>
    public DateTime? GrantStartDate { get; private set; }

    /// <summary>
    /// PYear of the ItemGrantCard
    /// PYear الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? PYear { get; private set; }

    /// <summary>
    /// RepCode of the ItemGrantCard
    /// RepCode الخاص بـ ItemGrantCard
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// SalesReturnFlag of the ItemGrantCard
    /// SalesReturnFlag الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? SalesReturnFlag { get; private set; }

    /// <summary>
    /// GrantType of the ItemGrantCard
    /// GrantType الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? GrantType { get; private set; }

    /// <summary>
    /// DstncCuntr of the ItemGrantCard
    /// DstncCuntr الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? DstncCuntr { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ItemGrantCard
    /// CompanyNumberShort الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemGrantCard
    /// BranchNumber الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ItemGrantCard
    /// BranchYear الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ItemGrantCard
    /// BranchUser الخاص بـ ItemGrantCard
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

