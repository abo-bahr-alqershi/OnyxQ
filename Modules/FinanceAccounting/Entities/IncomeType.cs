using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// IncomeType Entity
/// </summary>
public class IncomeType : Entity<IncomeTypeId>
{
    private IncomeType() { }

    /// <summary>
    /// The unique identifier for the IncomeType
    /// المعرف الفريد لـ IncomeType
    /// </summary>
    public IncomeTypeId Id { get; private set; }

    /// <summary>
    /// IncomeType of the IncomeType
    /// IncomeType الخاص بـ IncomeType
    /// </summary>
    public decimal? IncomeType { get; private set; }

    /// <summary>
    /// IncomeName of the IncomeType
    /// IncomeName الخاص بـ IncomeType
    /// </summary>
    public string IncomeName { get; private set; }

    /// <summary>
    /// IncomeNameEnglish of the IncomeType
    /// IncomeNameEnglish الخاص بـ IncomeType
    /// </summary>
    public string IncomeNameEnglish { get; private set; }

    /// <summary>
    /// IncomeReason of the IncomeType
    /// IncomeReason الخاص بـ IncomeType
    /// </summary>
    public decimal? IncomeReason { get; private set; }

    /// <summary>
    /// ConnectionWithPurchaseInvoice of the IncomeType
    /// ConnectionWithPurchaseInvoice الخاص بـ IncomeType
    /// </summary>
    public decimal? ConnectionWithPurchaseInvoice { get; private set; }

    /// <summary>
    /// IncomeSerial of the IncomeType
    /// IncomeSerial الخاص بـ IncomeType
    /// </summary>
    public decimal? IncomeSerial { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the IncomeType
    /// CalcTypeNumberTax الخاص بـ IncomeType
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: IncomeType to IncomeTypePermission
    /// </summary>
    public IReadOnlyCollection<IncomeTypePermission> IncomeTypePermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: IncomeType to GoodsReceiptIncomingMaster
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptIncomingMaster> GoodsReceiptIncomingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: IncomeType to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    #endregion
}
}
