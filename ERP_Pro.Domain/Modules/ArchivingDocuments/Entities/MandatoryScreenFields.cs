using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// MandatoryScreenFields Entity
/// </summary>
public class MandatoryScreenFields : Entity<MandatoryScreenFieldsId>
{

    private MandatoryScreenFields() { }

    public MandatoryScreenFields(MandatoryScreenFieldsId id, decimal? formNumber, string fieldNameShort)
    {
        Id = id;
        FormNumber = formNumber;
        FieldNameShort = fieldNameShort;
    }

    /// <summary>
    /// The unique identifier for the MandatoryScreenFields
    /// المعرف الفريد لـ MandatoryScreenFields
    /// </summary>
    public MandatoryScreenFieldsId Id { get; private set; }

    /// <summary>
    /// FormNumber of the MandatoryScreenFields
    /// FormNumber الخاص بـ MandatoryScreenFields
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// FieldNameShort of the MandatoryScreenFields
    /// FieldNameShort الخاص بـ MandatoryScreenFields
    /// </summary>
    public string FieldNameShort { get; private set; }

    /// <summary>
    /// FieldStatus of the MandatoryScreenFields
    /// FieldStatus الخاص بـ MandatoryScreenFields
    /// </summary>
    public decimal? FieldStatus { get; private set; }

    /// <summary>
    /// TableNameLabel of the MandatoryScreenFields
    /// TableNameLabel الخاص بـ MandatoryScreenFields
    /// </summary>
    public string TableNameLabel { get; private set; }

    /// <summary>
    /// SchemaName of the MandatoryScreenFields
    /// SchemaName الخاص بـ MandatoryScreenFields
    /// </summary>
    public string SchemaName { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

