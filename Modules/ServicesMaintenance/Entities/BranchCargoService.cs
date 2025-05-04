using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ServicesMaintenance.Entities
{
/// <summary>
/// BranchCargoService Entity
/// </summary>
public class BranchCargoService : Entity<BranchCargoServiceId>
{
    private BranchCargoService() { }

    /// <summary>
    /// The unique identifier for the BranchCargoService
    /// المعرف الفريد لـ BranchCargoService
    /// </summary>
    public BranchCargoServiceId Id { get; private set; }

    /// <summary>
    /// BillSerial of the BranchCargoService
    /// BillSerial الخاص بـ BranchCargoService
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillNumber of the BranchCargoService
    /// BillNumber الخاص بـ BranchCargoService
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchCargoService
    /// BillDocumentTypeFull الخاص بـ BranchCargoService
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillOfLading of the BranchCargoService
    /// BillOfLading الخاص بـ BranchCargoService
    /// </summary>
    public string BillOfLading { get; private set; }

    /// <summary>
    /// GoodsBillNumber of the BranchCargoService
    /// GoodsBillNumber الخاص بـ BranchCargoService
    /// </summary>
    public decimal? GoodsBillNumber { get; private set; }

    /// <summary>
    /// ServiceTypeFull of the BranchCargoService
    /// ServiceTypeFull الخاص بـ BranchCargoService
    /// </summary>
    public decimal? ServiceTypeFull { get; private set; }

    /// <summary>
    /// Weight of the BranchCargoService
    /// Weight الخاص بـ BranchCargoService
    /// </summary>
    public decimal? Weight { get; private set; }

    /// <summary>
    /// CustomsDescNo of the BranchCargoService
    /// CustomsDescNo الخاص بـ BranchCargoService
    /// </summary>
    public string CustomsDescNo { get; private set; }

    /// <summary>
    /// CustomsDescType of the BranchCargoService
    /// CustomsDescType الخاص بـ BranchCargoService
    /// </summary>
    public decimal? CustomsDescType { get; private set; }

    /// <summary>
    /// ReceiveCommission of the BranchCargoService
    /// ReceiveCommission الخاص بـ BranchCargoService
    /// </summary>
    public string ReceiveCommission { get; private set; }

    /// <summary>
    /// TransportCompany of the BranchCargoService
    /// TransportCompany الخاص بـ BranchCargoService
    /// </summary>
    public string TransportCompany { get; private set; }

    /// <summary>
    /// PackageCount of the BranchCargoService
    /// PackageCount الخاص بـ BranchCargoService
    /// </summary>
    public decimal? PackageCount { get; private set; }

    /// <summary>
    /// ServiceSerial of the BranchCargoService
    /// ServiceSerial الخاص بـ BranchCargoService
    /// </summary>
    public decimal? ServiceSerial { get; private set; }

    /// <summary>
    /// AccountDescription of the BranchCargoService
    /// AccountDescription الخاص بـ BranchCargoService
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ArrivalDate of the BranchCargoService
    /// ArrivalDate الخاص بـ BranchCargoService
    /// </summary>
    public DateTime? ArrivalDate { get; private set; }

    /// <summary>
    /// BillTypeFull of the BranchCargoService
    /// BillTypeFull الخاص بـ BranchCargoService
    /// </summary>
    public decimal? BillTypeFull { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchCargoService
    /// ExternalPostFlag الخاص بـ BranchCargoService
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// BillPaymentYear of the BranchCargoService
    /// BillPaymentYear الخاص بـ BranchCargoService
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchCargoService
    /// CompanyNumberShort الخاص بـ BranchCargoService
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchCargoService
    /// BranchNumber الخاص بـ BranchCargoService
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchCargoService
    /// BranchYear الخاص بـ BranchCargoService
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchCargoService
    /// BranchUser الخاص بـ BranchCargoService
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
