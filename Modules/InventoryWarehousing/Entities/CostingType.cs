using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// CostingType Entity
/// </summary>
public class CostingType : Entity<CostingTypeId>
{
    private CostingType() { }

    /// <summary>
    /// The unique identifier for the CostingType
    /// المعرف الفريد لـ CostingType
    /// </summary>
    public CostingTypeId Id { get; private set; }

    /// <summary>
    /// CostingTypeNumber of the CostingType
    /// CostingTypeNumber الخاص بـ CostingType
    /// </summary>
    public decimal? CostingTypeNumber { get; private set; }

    /// <summary>
    /// InvoiceType of the CostingType
    /// InvoiceType الخاص بـ CostingType
    /// </summary>
    public string InvoiceType { get; private set; }

    /// <summary>
    /// InvoiceAccount of the CostingType
    /// InvoiceAccount الخاص بـ CostingType
    /// </summary>
    public string InvoiceAccount { get; private set; }

    /// <summary>
    /// NoAccounts of the CostingType
    /// NoAccounts الخاص بـ CostingType
    /// </summary>
    public decimal? NoAccounts { get; private set; }

    /// <summary>
    /// Account1Code of the CostingType
    /// Account1Code الخاص بـ CostingType
    /// </summary>
    public string Account1Code { get; private set; }

    /// <summary>
    /// Account1Name of the CostingType
    /// Account1Name الخاص بـ CostingType
    /// </summary>
    public string Account1Name { get; private set; }

    /// <summary>
    /// Account2Code of the CostingType
    /// Account2Code الخاص بـ CostingType
    /// </summary>
    public string Account2Code { get; private set; }

    /// <summary>
    /// Account2Name of the CostingType
    /// Account2Name الخاص بـ CostingType
    /// </summary>
    public string Account2Name { get; private set; }

    /// <summary>
    /// Account3Code of the CostingType
    /// Account3Code الخاص بـ CostingType
    /// </summary>
    public string Account3Code { get; private set; }

    /// <summary>
    /// Account3Name of the CostingType
    /// Account3Name الخاص بـ CostingType
    /// </summary>
    public string Account3Name { get; private set; }

    /// <summary>
    /// Account4Code of the CostingType
    /// Account4Code الخاص بـ CostingType
    /// </summary>
    public string Account4Code { get; private set; }

    /// <summary>
    /// Account4Name of the CostingType
    /// Account4Name الخاص بـ CostingType
    /// </summary>
    public string Account4Name { get; private set; }

    /// <summary>
    /// Account5Code of the CostingType
    /// Account5Code الخاص بـ CostingType
    /// </summary>
    public string Account5Code { get; private set; }

    /// <summary>
    /// Account5Name of the CostingType
    /// Account5Name الخاص بـ CostingType
    /// </summary>
    public string Account5Name { get; private set; }

    /// <summary>
    /// Account6Code of the CostingType
    /// Account6Code الخاص بـ CostingType
    /// </summary>
    public string Account6Code { get; private set; }

    /// <summary>
    /// Account6Name of the CostingType
    /// Account6Name الخاص بـ CostingType
    /// </summary>
    public string Account6Name { get; private set; }

    /// <summary>
    /// Account7Code of the CostingType
    /// Account7Code الخاص بـ CostingType
    /// </summary>
    public string Account7Code { get; private set; }

    /// <summary>
    /// Account7Name of the CostingType
    /// Account7Name الخاص بـ CostingType
    /// </summary>
    public string Account7Name { get; private set; }

    /// <summary>
    /// Account8Code of the CostingType
    /// Account8Code الخاص بـ CostingType
    /// </summary>
    public string Account8Code { get; private set; }

    /// <summary>
    /// Account8Name of the CostingType
    /// Account8Name الخاص بـ CostingType
    /// </summary>
    public string Account8Name { get; private set; }

    /// <summary>
    /// Account9Code of the CostingType
    /// Account9Code الخاص بـ CostingType
    /// </summary>
    public string Account9Code { get; private set; }

    /// <summary>
    /// Account9Name of the CostingType
    /// Account9Name الخاص بـ CostingType
    /// </summary>
    public string Account9Name { get; private set; }

    /// <summary>
    /// Account10Code of the CostingType
    /// Account10Code الخاص بـ CostingType
    /// </summary>
    public string Account10Code { get; private set; }

    /// <summary>
    /// Account10Name of the CostingType
    /// Account10Name الخاص بـ CostingType
    /// </summary>
    public string Account10Name { get; private set; }

    /// <summary>
    /// Account11Code of the CostingType
    /// Account11Code الخاص بـ CostingType
    /// </summary>
    public string Account11Code { get; private set; }

    /// <summary>
    /// Account11Name of the CostingType
    /// Account11Name الخاص بـ CostingType
    /// </summary>
    public string Account11Name { get; private set; }

    /// <summary>
    /// Account12Code of the CostingType
    /// Account12Code الخاص بـ CostingType
    /// </summary>
    public string Account12Code { get; private set; }

    /// <summary>
    /// Account12Name of the CostingType
    /// Account12Name الخاص بـ CostingType
    /// </summary>
    public string Account12Name { get; private set; }

    /// <summary>
    /// Account13Code of the CostingType
    /// Account13Code الخاص بـ CostingType
    /// </summary>
    public string Account13Code { get; private set; }

    /// <summary>
    /// Account13Name of the CostingType
    /// Account13Name الخاص بـ CostingType
    /// </summary>
    public string Account13Name { get; private set; }

    /// <summary>
    /// Account14Code of the CostingType
    /// Account14Code الخاص بـ CostingType
    /// </summary>
    public string Account14Code { get; private set; }

    /// <summary>
    /// Account14Name of the CostingType
    /// Account14Name الخاص بـ CostingType
    /// </summary>
    public string Account14Name { get; private set; }

    /// <summary>
    /// Account15Code of the CostingType
    /// Account15Code الخاص بـ CostingType
    /// </summary>
    public string Account15Code { get; private set; }

    /// <summary>
    /// Account15Name of the CostingType
    /// Account15Name الخاص بـ CostingType
    /// </summary>
    public string Account15Name { get; private set; }

    /// <summary>
    /// Account16Code of the CostingType
    /// Account16Code الخاص بـ CostingType
    /// </summary>
    public string Account16Code { get; private set; }

    /// <summary>
    /// Account16Name of the CostingType
    /// Account16Name الخاص بـ CostingType
    /// </summary>
    public string Account16Name { get; private set; }

    /// <summary>
    /// Account17Code of the CostingType
    /// Account17Code الخاص بـ CostingType
    /// </summary>
    public string Account17Code { get; private set; }

    /// <summary>
    /// Account17Name of the CostingType
    /// Account17Name الخاص بـ CostingType
    /// </summary>
    public string Account17Name { get; private set; }

    /// <summary>
    /// Account18Code of the CostingType
    /// Account18Code الخاص بـ CostingType
    /// </summary>
    public string Account18Code { get; private set; }

    /// <summary>
    /// Account18Name of the CostingType
    /// Account18Name الخاص بـ CostingType
    /// </summary>
    public string Account18Name { get; private set; }

    /// <summary>
    /// Account19Code of the CostingType
    /// Account19Code الخاص بـ CostingType
    /// </summary>
    public string Account19Code { get; private set; }

    /// <summary>
    /// Account19Name of the CostingType
    /// Account19Name الخاص بـ CostingType
    /// </summary>
    public string Account19Name { get; private set; }

    /// <summary>
    /// Account20Code of the CostingType
    /// Account20Code الخاص بـ CostingType
    /// </summary>
    public string Account20Code { get; private set; }

    /// <summary>
    /// Account20Name of the CostingType
    /// Account20Name الخاص بـ CostingType
    /// </summary>
    public string Account20Name { get; private set; }

    /// <summary>
    /// Account21Code of the CostingType
    /// Account21Code الخاص بـ CostingType
    /// </summary>
    public string Account21Code { get; private set; }

    /// <summary>
    /// Account21Name of the CostingType
    /// Account21Name الخاص بـ CostingType
    /// </summary>
    public string Account21Name { get; private set; }

    /// <summary>
    /// Account22Code of the CostingType
    /// Account22Code الخاص بـ CostingType
    /// </summary>
    public string Account22Code { get; private set; }

    /// <summary>
    /// Account22Name of the CostingType
    /// Account22Name الخاص بـ CostingType
    /// </summary>
    public string Account22Name { get; private set; }

    /// <summary>
    /// Account23Code of the CostingType
    /// Account23Code الخاص بـ CostingType
    /// </summary>
    public string Account23Code { get; private set; }

    /// <summary>
    /// Account23Name of the CostingType
    /// Account23Name الخاص بـ CostingType
    /// </summary>
    public string Account23Name { get; private set; }

    /// <summary>
    /// Account24Code of the CostingType
    /// Account24Code الخاص بـ CostingType
    /// </summary>
    public string Account24Code { get; private set; }

    /// <summary>
    /// Account24Name of the CostingType
    /// Account24Name الخاص بـ CostingType
    /// </summary>
    public string Account24Name { get; private set; }

    /// <summary>
    /// Account25Code of the CostingType
    /// Account25Code الخاص بـ CostingType
    /// </summary>
    public string Account25Code { get; private set; }

    /// <summary>
    /// Account25Name of the CostingType
    /// Account25Name الخاص بـ CostingType
    /// </summary>
    public string Account25Name { get; private set; }
}
}
