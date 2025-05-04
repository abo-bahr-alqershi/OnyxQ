using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FixedAssets.Entities
{
/// <summary>
/// Revaluation Entity
/// </summary>
public class Revaluation : Entity<RevaluationId>
{
    private Revaluation() { }

    /// <summary>
    /// The unique identifier for the Revaluation
    /// المعرف الفريد لـ Revaluation
    /// </summary>
    public RevaluationId Id { get; private set; }

    /// <summary>
    /// DocType of the Revaluation
    /// DocType الخاص بـ Revaluation
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// ItemCode of the Revaluation
    /// ItemCode الخاص بـ Revaluation
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the Revaluation
    /// WarehouseCode الخاص بـ Revaluation
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the Revaluation
    /// WarehouseGroupCode الخاص بـ Revaluation
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// ExpireDate of the Revaluation
    /// ExpireDate الخاص بـ Revaluation
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the Revaluation
    /// BatchNumber الخاص بـ Revaluation
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// DocSequence of the Revaluation
    /// DocSequence الخاص بـ Revaluation
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// StockCost of the Revaluation
    /// StockCost الخاص بـ Revaluation
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// PSize of the Revaluation
    /// PSize الخاص بـ Revaluation
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// InOutFlag of the Revaluation
    /// InOutFlag الخاص بـ Revaluation
    /// </summary>
    public decimal? InOutFlag { get; private set; }

    /// <summary>
    /// RnFlag of the Revaluation
    /// RnFlag الخاص بـ Revaluation
    /// </summary>
    public decimal? RnFlag { get; private set; }

    /// <summary>
    /// Serial of the Revaluation
    /// Serial الخاص بـ Revaluation
    /// </summary>
    public decimal? Serial { get; private set; }

    /// <summary>
    /// PsumQuantity of the Revaluation
    /// PsumQuantity الخاص بـ Revaluation
    /// </summary>
    public decimal? PsumQuantity { get; private set; }

    /// <summary>
    /// KitQuantity of the Revaluation
    /// KitQuantity الخاص بـ Revaluation
    /// </summary>
    public decimal? KitQuantity { get; private set; }

    /// <summary>
    /// StockCost0 of the Revaluation
    /// StockCost0 الخاص بـ Revaluation
    /// </summary>
    public decimal? StockCost0 { get; private set; }

    /// <summary>
    /// SerialReference1 of the Revaluation
    /// SerialReference1 الخاص بـ Revaluation
    /// </summary>
    public decimal? SerialReference1 { get; private set; }

    /// <summary>
    /// AvailableQuantityBeforeShort of the Revaluation
    /// AvailableQuantityBeforeShort الخاص بـ Revaluation
    /// </summary>
    public decimal? AvailableQuantityBeforeShort { get; private set; }

    /// <summary>
    /// AvailableQuantityBeforeDivide of the Revaluation
    /// AvailableQuantityBeforeDivide الخاص بـ Revaluation
    /// </summary>
    public decimal? AvailableQuantityBeforeDivide { get; private set; }

    /// <summary>
    /// WeightedAverageAfter of the Revaluation
    /// WeightedAverageAfter الخاص بـ Revaluation
    /// </summary>
    public decimal? WeightedAverageAfter { get; private set; }

    /// <summary>
    /// WeightedAverageAfter1 of the Revaluation
    /// WeightedAverageAfter1 الخاص بـ Revaluation
    /// </summary>
    public decimal? WeightedAverageAfter1 { get; private set; }

    /// <summary>
    /// WeightedAverageAfter2 of the Revaluation
    /// WeightedAverageAfter2 الخاص بـ Revaluation
    /// </summary>
    public decimal? WeightedAverageAfter2 { get; private set; }

    /// <summary>
    /// SerialReference of the Revaluation
    /// SerialReference الخاص بـ Revaluation
    /// </summary>
    public decimal? SerialReference { get; private set; }

    /// <summary>
    /// ItemCostShort of the Revaluation
    /// ItemCostShort الخاص بـ Revaluation
    /// </summary>
    public decimal? ItemCostShort { get; private set; }

    /// <summary>
    /// ExpenseAmount of the Revaluation
    /// ExpenseAmount الخاص بـ Revaluation
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// DocTypeDtl of the Revaluation
    /// DocTypeDtl الخاص بـ Revaluation
    /// </summary>
    public decimal? DocTypeDtl { get; private set; }

    /// <summary>
    /// SerialReferenceOut of the Revaluation
    /// SerialReferenceOut الخاص بـ Revaluation
    /// </summary>
    public decimal? SerialReferenceOut { get; private set; }

    /// <summary>
    /// ReceiverNumber of the Revaluation
    /// ReceiverNumber الخاص بـ Revaluation
    /// </summary>
    public decimal? ReceiverNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the Revaluation
    /// RecordNumber الخاص بـ Revaluation
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the Revaluation
    /// ProcessedFlagFull الخاص بـ Revaluation
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// LastReevaluationSerial of the Revaluation
    /// LastReevaluationSerial الخاص بـ Revaluation
    /// </summary>
    public decimal? LastReevaluationSerial { get; private set; }

    /// <summary>
    /// InvoiceWeightedAverageForce of the Revaluation
    /// InvoiceWeightedAverageForce الخاص بـ Revaluation
    /// </summary>
    public decimal? InvoiceWeightedAverageForce { get; private set; }

    /// <summary>
    /// WeightedAverageBefore of the Revaluation
    /// WeightedAverageBefore الخاص بـ Revaluation
    /// </summary>
    public decimal? WeightedAverageBefore { get; private set; }
}
}
