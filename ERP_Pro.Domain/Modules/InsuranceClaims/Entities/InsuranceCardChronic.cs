using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;
namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceCardChronic Entity
/// </summary>
public class InsuranceCardChronic : Entity<InsuranceCardChronicId>
{
    private readonly List<InsuranceCard> _insuranceCard = new List<InsuranceCard>();
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();

    private InsuranceCardChronic() { }

    public InsuranceCardChronic(InsuranceCardChronicId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InsuranceCardChronic
    /// المعرف الفريد لـ InsuranceCardChronic
    /// </summary>
    public InsuranceCardChronicId Id { get; private set; }

    /// <summary>
    /// PersonSerial of the InsuranceCardChronic
    /// PersonSerial الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? PersonSerial { get; private set; }

    /// <summary>
    /// PersonNumberAlt of the InsuranceCardChronic
    /// PersonNumberAlt الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? PersonNumberAlt { get; private set; }

    /// <summary>
    /// ItemQuantityDay of the InsuranceCardChronic
    /// ItemQuantityDay الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? ItemQuantityDay { get; private set; }

    /// <summary>
    /// ItemQuantityMonth of the InsuranceCardChronic
    /// ItemQuantityMonth الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? ItemQuantityMonth { get; private set; }

    /// <summary>
    /// ItemUnit of the InsuranceCardChronic
    /// ItemUnit الخاص بـ InsuranceCardChronic
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// RecordNumber of the InsuranceCardChronic
    /// RecordNumber الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// PSize of the InsuranceCardChronic
    /// PSize الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? PSize { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<InsuranceCard> InsuranceCard => _insuranceCard;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

