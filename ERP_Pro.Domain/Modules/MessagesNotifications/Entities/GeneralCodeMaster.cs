using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;
namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// GeneralCodeMaster Entity
/// </summary>
public class GeneralCodeMaster : AggregateRoot<GeneralCodeMasterId>
{

    private GeneralCodeMaster() { }

    public GeneralCodeMaster(GeneralCodeMasterId id, decimal? mainCode)
    {
        Id = id;
        MainCode = mainCode;
    }

    /// <summary>
    /// The unique identifier for the GeneralCodeMaster
    /// المعرف الفريد لـ GeneralCodeMaster
    /// </summary>
    public GeneralCodeMasterId Id { get; private set; }

    /// <summary>
    /// MainCode of the GeneralCodeMaster
    /// MainCode الخاص بـ GeneralCodeMaster
    /// </summary>
    public decimal? MainCode { get; private set; }

    /// <summary>
    /// MainLastName of the GeneralCodeMaster
    /// MainLastName الخاص بـ GeneralCodeMaster
    /// </summary>
    public string MainLastName { get; private set; }

    /// <summary>
    /// MainFirstName of the GeneralCodeMaster
    /// MainFirstName الخاص بـ GeneralCodeMaster
    /// </summary>
    public string MainFirstName { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the GeneralCodeMaster
    /// InactiveFlagAlt الخاص بـ GeneralCodeMaster
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// CodeType of the GeneralCodeMaster
    /// CodeType الخاص بـ GeneralCodeMaster
    /// </summary>
    public decimal? CodeType { get; private set; }

    /// <summary>
    /// TableNameLabel of the GeneralCodeMaster
    /// TableNameLabel الخاص بـ GeneralCodeMaster
    /// </summary>
    public string TableNameLabel { get; private set; }

    /// <summary>
    /// FlagCode of the GeneralCodeMaster
    /// FlagCode الخاص بـ GeneralCodeMaster
    /// </summary>
    public string FlagCode { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

