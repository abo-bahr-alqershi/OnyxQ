using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.JudicialLegal.ValueObjects;
namespace ERP_Pro.Domain.ERP.JudicialLegal.Entities
{
/// <summary>
/// JudicialFieldOrderDetail Entity
/// </summary>
public class JudicialFieldOrderDetail : Entity<JudicialFieldOrderDetailId>
{

    private JudicialFieldOrderDetail() { }

    public JudicialFieldOrderDetail(JudicialFieldOrderDetailId id, decimal? formNumber, decimal? recordNumber, string fieldName)
    {
        Id = id;
        FormNumber = formNumber;
        RecordNumber = recordNumber;
        FieldName = fieldName;
    }

    /// <summary>
    /// The unique identifier for the JudicialFieldOrderDetail
    /// المعرف الفريد لـ JudicialFieldOrderDetail
    /// </summary>
    public JudicialFieldOrderDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the JudicialFieldOrderDetail
    /// DocNo الخاص بـ JudicialFieldOrderDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// OrderNumberShort of the JudicialFieldOrderDetail
    /// OrderNumberShort الخاص بـ JudicialFieldOrderDetail
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// FormNumber of the JudicialFieldOrderDetail
    /// FormNumber الخاص بـ JudicialFieldOrderDetail
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// OrderType of the JudicialFieldOrderDetail
    /// OrderType الخاص بـ JudicialFieldOrderDetail
    /// </summary>
    public decimal? OrderType { get; private set; }

    /// <summary>
    /// RecordNumber of the JudicialFieldOrderDetail
    /// RecordNumber الخاص بـ JudicialFieldOrderDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// FieldName of the JudicialFieldOrderDetail
    /// FieldName الخاص بـ JudicialFieldOrderDetail
    /// </summary>
    public string FieldName { get; private set; }

    /// <summary>
    /// FDigit of the JudicialFieldOrderDetail
    /// FDigit الخاص بـ JudicialFieldOrderDetail
    /// </summary>
    public decimal? FDigit { get; private set; }

    /// <summary>
    /// TDigit of the JudicialFieldOrderDetail
    /// TDigit الخاص بـ JudicialFieldOrderDetail
    /// </summary>
    public decimal? TDigit { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the JudicialFieldOrderDetail
    /// CompanyNumberShort الخاص بـ JudicialFieldOrderDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the JudicialFieldOrderDetail
    /// BranchNumber الخاص بـ JudicialFieldOrderDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the JudicialFieldOrderDetail
    /// BranchYear الخاص بـ JudicialFieldOrderDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the JudicialFieldOrderDetail
    /// BranchUser الخاص بـ JudicialFieldOrderDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public JudicialFieldOrderMaster JudicialFieldOrderMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

