using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.JudicialLegal.ValueObjects;
namespace ERP_Pro.Domain.ERP.JudicialLegal.Entities
{
/// <summary>
/// JudicialFieldOrderMaster Entity
/// </summary>
public class JudicialFieldOrderMaster : AggregateRoot<JudicialFieldOrderMasterId>
{

    private JudicialFieldOrderMaster() { }

    public JudicialFieldOrderMaster(JudicialFieldOrderMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the JudicialFieldOrderMaster
    /// المعرف الفريد لـ JudicialFieldOrderMaster
    /// </summary>
    public JudicialFieldOrderMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the JudicialFieldOrderMaster
    /// DocNo الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the JudicialFieldOrderMaster
    /// DocSer الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// OrderType of the JudicialFieldOrderMaster
    /// OrderType الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public decimal? OrderType { get; private set; }

    /// <summary>
    /// FormNumber of the JudicialFieldOrderMaster
    /// FormNumber الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// DocDate of the JudicialFieldOrderMaster
    /// DocDate الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DrCnfg of the JudicialFieldOrderMaster
    /// DrCnfg الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public string DrCnfg { get; private set; }

    /// <summary>
    /// CreditConfig of the JudicialFieldOrderMaster
    /// CreditConfig الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public string CreditConfig { get; private set; }

    /// <summary>
    /// DrSmbl of the JudicialFieldOrderMaster
    /// DrSmbl الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public string DrSmbl { get; private set; }

    /// <summary>
    /// CreditSymbol of the JudicialFieldOrderMaster
    /// CreditSymbol الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public string CreditSymbol { get; private set; }

    /// <summary>
    /// Dflt of the JudicialFieldOrderMaster
    /// Dflt الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public decimal? Dflt { get; private set; }

    /// <summary>
    /// TDescription of the JudicialFieldOrderMaster
    /// TDescription الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public string TDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the JudicialFieldOrderMaster
    /// CompanyNumberShort الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the JudicialFieldOrderMaster
    /// BranchNumber الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the JudicialFieldOrderMaster
    /// BranchYear الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the JudicialFieldOrderMaster
    /// BranchUser الخاص بـ JudicialFieldOrderMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

