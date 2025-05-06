using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.ServicesMaintenance.ValueObjects;
namespace ERP_Pro.Domain.ERP.ServicesMaintenance.Entities
{
/// <summary>
/// CargoService Entity
/// </summary>
public class CargoService : Entity<CargoServiceId>
{

    private CargoService() { }

    public CargoService(CargoServiceId id, decimal? billSerial)
    {
        Id = id;
        BillSerial = billSerial;
    }

    /// <summary>
    /// The unique identifier for the CargoService
    /// المعرف الفريد لـ CargoService
    /// </summary>
    public CargoServiceId Id { get; private set; }

    /// <summary>
    /// BillSerial of the CargoService
    /// BillSerial الخاص بـ CargoService
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillNumber of the CargoService
    /// BillNumber الخاص بـ CargoService
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the CargoService
    /// BillDocumentTypeFull الخاص بـ CargoService
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillOfLading of the CargoService
    /// BillOfLading الخاص بـ CargoService
    /// </summary>
    public string BillOfLading { get; private set; }

    /// <summary>
    /// GoodsBillNumber of the CargoService
    /// GoodsBillNumber الخاص بـ CargoService
    /// </summary>
    public decimal? GoodsBillNumber { get; private set; }

    /// <summary>
    /// ServiceTypeFull of the CargoService
    /// ServiceTypeFull الخاص بـ CargoService
    /// </summary>
    public decimal? ServiceTypeFull { get; private set; }

    /// <summary>
    /// Weight of the CargoService
    /// Weight الخاص بـ CargoService
    /// </summary>
    public decimal? Weight { get; private set; }

    /// <summary>
    /// CustomsDescNo of the CargoService
    /// CustomsDescNo الخاص بـ CargoService
    /// </summary>
    public string CustomsDescNo { get; private set; }

    /// <summary>
    /// CustomsDescType of the CargoService
    /// CustomsDescType الخاص بـ CargoService
    /// </summary>
    public decimal? CustomsDescType { get; private set; }

    /// <summary>
    /// ReceiveCommission of the CargoService
    /// ReceiveCommission الخاص بـ CargoService
    /// </summary>
    public string ReceiveCommission { get; private set; }

    /// <summary>
    /// TransportCompany of the CargoService
    /// TransportCompany الخاص بـ CargoService
    /// </summary>
    public string TransportCompany { get; private set; }

    /// <summary>
    /// PackageCount of the CargoService
    /// PackageCount الخاص بـ CargoService
    /// </summary>
    public decimal? PackageCount { get; private set; }

    /// <summary>
    /// ServiceSerial of the CargoService
    /// ServiceSerial الخاص بـ CargoService
    /// </summary>
    public decimal? ServiceSerial { get; private set; }

    /// <summary>
    /// AccountDescription of the CargoService
    /// AccountDescription الخاص بـ CargoService
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ArrivalDate of the CargoService
    /// ArrivalDate الخاص بـ CargoService
    /// </summary>
    public DateTime? ArrivalDate { get; private set; }

    /// <summary>
    /// BillTypeFull of the CargoService
    /// BillTypeFull الخاص بـ CargoService
    /// </summary>
    public decimal? BillTypeFull { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the CargoService
    /// ExternalPostFlag الخاص بـ CargoService
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// BillPaymentYear of the CargoService
    /// BillPaymentYear الخاص بـ CargoService
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CargoService
    /// CompanyNumberShort الخاص بـ CargoService
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CargoService
    /// BranchNumber الخاص بـ CargoService
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CargoService
    /// BranchYear الخاص بـ CargoService
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CargoService
    /// BranchUser الخاص بـ CargoService
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

