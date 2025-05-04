using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CheckIncomeDetail Entity
/// </summary>
public class CheckIncomeDetail : Entity<CheckIncomeDetailId>
{
    private CheckIncomeDetail() { }

    /// <summary>
    /// The unique identifier for the CheckIncomeDetail
    /// المعرف الفريد لـ CheckIncomeDetail
    /// </summary>
    public CheckIncomeDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the CheckIncomeDetail
    /// DocNo الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the CheckIncomeDetail
    /// DocSer الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocType of the CheckIncomeDetail
    /// DocType الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocSequence of the CheckIncomeDetail
    /// DocSequence الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ItemCode of the CheckIncomeDetail
    /// ItemCode الخاص بـ CheckIncomeDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the CheckIncomeDetail
    /// ItemQuantity الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the CheckIncomeDetail
    /// FreeQuantity الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// CheckQuantity of the CheckIncomeDetail
    /// CheckQuantity الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? CheckQuantity { get; private set; }

    /// <summary>
    /// CheckFreeQuantity of the CheckIncomeDetail
    /// CheckFreeQuantity الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? CheckFreeQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the CheckIncomeDetail
    /// ItemUnit الخاص بـ CheckIncomeDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the CheckIncomeDetail
    /// PSize الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// CostCenterCode of the CheckIncomeDetail
    /// CostCenterCode الخاص بـ CheckIncomeDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the CheckIncomeDetail
    /// WarehouseCode الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ExpireDate of the CheckIncomeDetail
    /// ExpireDate الخاص بـ CheckIncomeDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the CheckIncomeDetail
    /// BatchNumber الخاص بـ CheckIncomeDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// DocNoRef of the CheckIncomeDetail
    /// DocNoRef الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocTypeef of the CheckIncomeDetail
    /// DocTypeef الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? DocTypeef { get; private set; }

    /// <summary>
    /// DocSerRef of the CheckIncomeDetail
    /// DocSerRef الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the CheckIncomeDetail
    /// DocSequenceRef الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// ItemDescription of the CheckIncomeDetail
    /// ItemDescription الخاص بـ CheckIncomeDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// Barcode of the CheckIncomeDetail
    /// Barcode الخاص بـ CheckIncomeDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// UseSerialNumber of the CheckIncomeDetail
    /// UseSerialNumber الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the CheckIncomeDetail
    /// RecordNumber الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// UseAttachment of the CheckIncomeDetail
    /// UseAttachment الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the CheckIncomeDetail
    /// ReceiveAttachment الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CheckIncomeDetail
    /// CompanyNumberShort الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CheckIncomeDetail
    /// BranchNumber الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CheckIncomeDetail
    /// BranchYear الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CheckIncomeDetail
    /// BranchUser الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemLength of the CheckIncomeDetail
    /// ItemLength الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the CheckIncomeDetail
    /// ItemWidth الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the CheckIncomeDetail
    /// ItemHeightShort الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the CheckIncomeDetail
    /// ItemNumberShort الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// CheckPartialQuantity of the CheckIncomeDetail
    /// CheckPartialQuantity الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? CheckPartialQuantity { get; private set; }

    /// <summary>
    /// CheckStatus of the CheckIncomeDetail
    /// CheckStatus الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? CheckStatus { get; private set; }

    /// <summary>
    /// CheckNote of the CheckIncomeDetail
    /// CheckNote الخاص بـ CheckIncomeDetail
    /// </summary>
    public string CheckNote { get; private set; }

    /// <summary>
    /// PQuantity of the CheckIncomeDetail
    /// PQuantity الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// CheckPreviousFreeQuantity of the CheckIncomeDetail
    /// CheckPreviousFreeQuantity الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? CheckPreviousFreeQuantity { get; private set; }

    /// <summary>
    /// CheckPreviousQuantity of the CheckIncomeDetail
    /// CheckPreviousQuantity الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? CheckPreviousQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the CheckIncomeDetail
    /// WeightedUnit الخاص بـ CheckIncomeDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the CheckIncomeDetail
    /// WeightedQuantity الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// ArgumentNumber of the CheckIncomeDetail
    /// ArgumentNumber الخاص بـ CheckIncomeDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to CheckIncomeMaster
    /// </summary>
    public CheckIncomeMaster CheckIncomeMaster { get; private set; }
    #endregion
}
}
