using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryQrCodeMethodDetail Entity
/// </summary>
public class InventoryQrCodeMethodDetail : Entity<InventoryQrCodeMethodDetailId>
{
    private InventoryQrCodeMethodDetail() { }

    /// <summary>
    /// The unique identifier for the InventoryQrCodeMethodDetail
    /// المعرف الفريد لـ InventoryQrCodeMethodDetail
    /// </summary>
    public InventoryQrCodeMethodDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the InventoryQrCodeMethodDetail
    /// RecordNumber الخاص بـ InventoryQrCodeMethodDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// MethodNumber of the InventoryQrCodeMethodDetail
    /// MethodNumber الخاص بـ InventoryQrCodeMethodDetail
    /// </summary>
    public decimal? MethodNumber { get; private set; }

    /// <summary>
    /// FieldNameShort of the InventoryQrCodeMethodDetail
    /// FieldNameShort الخاص بـ InventoryQrCodeMethodDetail
    /// </summary>
    public decimal? FieldNameShort { get; private set; }

    /// <summary>
    /// FieldLength of the InventoryQrCodeMethodDetail
    /// FieldLength الخاص بـ InventoryQrCodeMethodDetail
    /// </summary>
    public decimal? FieldLength { get; private set; }

    /// <summary>
    /// FieldCode of the InventoryQrCodeMethodDetail
    /// FieldCode الخاص بـ InventoryQrCodeMethodDetail
    /// </summary>
    public string FieldCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to InventoryQrCodeMethodMaster
    /// </summary>
    public InventoryQrCodeMethodMaster InventoryQrCodeMethodMaster { get; private set; }
    #endregion
}
}
