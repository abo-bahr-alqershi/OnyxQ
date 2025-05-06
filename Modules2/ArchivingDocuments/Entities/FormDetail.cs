using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// FormDetail Entity
/// </summary>
public class FormDetail : Entity<FormDetailId>
{

    private FormDetail() { }

    public FormDetail(FormDetailId id, decimal? formNumber)
    {
        Id = id;
        FormNumber = formNumber;
    }

    /// <summary>
    /// The unique identifier for the FormDetail
    /// المعرف الفريد لـ FormDetail
    /// </summary>
    public FormDetailId Id { get; private set; }

    /// <summary>
    /// FSystem of the FormDetail
    /// FSystem الخاص بـ FormDetail
    /// </summary>
    public string FSystem { get; private set; }

    /// <summary>
    /// SystemNumber of the FormDetail
    /// SystemNumber الخاص بـ FormDetail
    /// </summary>
    public decimal? SystemNumber { get; private set; }

    /// <summary>
    /// FormNumber of the FormDetail
    /// FormNumber الخاص بـ FormDetail
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// FParentNumber of the FormDetail
    /// FParentNumber الخاص بـ FormDetail
    /// </summary>
    public decimal? FParentNumber { get; private set; }

    /// <summary>
    /// FFileName of the FormDetail
    /// FFileName الخاص بـ FormDetail
    /// </summary>
    public string FFileName { get; private set; }

    /// <summary>
    /// FBtPrivilege of the FormDetail
    /// FBtPrivilege الخاص بـ FormDetail
    /// </summary>
    public decimal? FBtPrivilege { get; private set; }

    /// <summary>
    /// FInactiveFlag of the FormDetail
    /// FInactiveFlag الخاص بـ FormDetail
    /// </summary>
    public decimal? FInactiveFlag { get; private set; }

    /// <summary>
    /// FOrderNumber of the FormDetail
    /// FOrderNumber الخاص بـ FormDetail
    /// </summary>
    public decimal? FOrderNumber { get; private set; }

    /// <summary>
    /// ScreenOriginal of the FormDetail
    /// ScreenOriginal الخاص بـ FormDetail
    /// </summary>
    public decimal? ScreenOriginal { get; private set; }

    /// <summary>
    /// ScreenThemeNumber of the FormDetail
    /// ScreenThemeNumber الخاص بـ FormDetail
    /// </summary>
    public decimal? ScreenThemeNumber { get; private set; }

    /// <summary>
    /// ScreenType of the FormDetail
    /// ScreenType الخاص بـ FormDetail
    /// </summary>
    public decimal? ScreenType { get; private set; }

    /// <summary>
    /// DocTyp of the FormDetail
    /// DocTyp الخاص بـ FormDetail
    /// </summary>
    public decimal? DocTyp { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

