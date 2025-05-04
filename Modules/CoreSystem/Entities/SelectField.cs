using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// SelectField Entity
/// </summary>
public class SelectField : Entity<SelectFieldId>
{
    private SelectField() { }

    /// <summary>
    /// The unique identifier for the SelectField
    /// المعرف الفريد لـ SelectField
    /// </summary>
    public SelectFieldId Id { get; private set; }

    /// <summary>
    /// FormNumber of the SelectField
    /// FormNumber الخاص بـ SelectField
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// FieldId of the SelectField
    /// FieldId الخاص بـ SelectField
    /// </summary>
    public decimal? FieldId { get; private set; }

    /// <summary>
    /// FieldName of the SelectField
    /// FieldName الخاص بـ SelectField
    /// </summary>
    public string FieldName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SelectField
    /// CompanyNumberShort الخاص بـ SelectField
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the SelectField
    /// BranchNumber الخاص بـ SelectField
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SelectField
    /// BranchYear الخاص بـ SelectField
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the SelectField
    /// BranchUser الخاص بـ SelectField
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
