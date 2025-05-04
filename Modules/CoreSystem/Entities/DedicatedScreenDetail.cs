using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// DedicatedScreenDetail Entity
/// </summary>
public class DedicatedScreenDetail : Entity<DedicatedScreenDetailId>
{
    private DedicatedScreenDetail() { }

    /// <summary>
    /// The unique identifier for the DedicatedScreenDetail
    /// المعرف الفريد لـ DedicatedScreenDetail
    /// </summary>
    public DedicatedScreenDetailId Id { get; private set; }

    /// <summary>
    /// FormNumber of the DedicatedScreenDetail
    /// FormNumber الخاص بـ DedicatedScreenDetail
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// ObjectNameShort of the DedicatedScreenDetail
    /// ObjectNameShort الخاص بـ DedicatedScreenDetail
    /// </summary>
    public string ObjectNameShort { get; private set; }

    /// <summary>
    /// FieldNameShort of the DedicatedScreenDetail
    /// FieldNameShort الخاص بـ DedicatedScreenDetail
    /// </summary>
    public string FieldNameShort { get; private set; }

    /// <summary>
    /// FieldNumber of the DedicatedScreenDetail
    /// FieldNumber الخاص بـ DedicatedScreenDetail
    /// </summary>
    public decimal? FieldNumber { get; private set; }

    /// <summary>
    /// LabelNumberShort of the DedicatedScreenDetail
    /// LabelNumberShort الخاص بـ DedicatedScreenDetail
    /// </summary>
    public decimal? LabelNumberShort { get; private set; }

    /// <summary>
    /// FieldTypeShort of the DedicatedScreenDetail
    /// FieldTypeShort الخاص بـ DedicatedScreenDetail
    /// </summary>
    public decimal? FieldTypeShort { get; private set; }

    /// <summary>
    /// FieldPrevious of the DedicatedScreenDetail
    /// FieldPrevious الخاص بـ DedicatedScreenDetail
    /// </summary>
    public decimal? FieldPrevious { get; private set; }

    /// <summary>
    /// FieldHeader of the DedicatedScreenDetail
    /// FieldHeader الخاص بـ DedicatedScreenDetail
    /// </summary>
    public decimal? FieldHeader { get; private set; }

    /// <summary>
    /// FieldMandatory of the DedicatedScreenDetail
    /// FieldMandatory الخاص بـ DedicatedScreenDetail
    /// </summary>
    public decimal? FieldMandatory { get; private set; }

    /// <summary>
    /// FlagListType of the DedicatedScreenDetail
    /// FlagListType الخاص بـ DedicatedScreenDetail
    /// </summary>
    public decimal? FlagListType { get; private set; }

    /// <summary>
    /// FlagListWhere of the DedicatedScreenDetail
    /// FlagListWhere الخاص بـ DedicatedScreenDetail
    /// </summary>
    public string FlagListWhere { get; private set; }

    /// <summary>
    /// FlagCode of the DedicatedScreenDetail
    /// FlagCode الخاص بـ DedicatedScreenDetail
    /// </summary>
    public string FlagCode { get; private set; }

    /// <summary>
    /// LastTable of the DedicatedScreenDetail
    /// LastTable الخاص بـ DedicatedScreenDetail
    /// </summary>
    public string LastTable { get; private set; }

    /// <summary>
    /// LastColumnName of the DedicatedScreenDetail
    /// LastColumnName الخاص بـ DedicatedScreenDetail
    /// </summary>
    public string LastColumnName { get; private set; }

    /// <summary>
    /// LastColumnValue of the DedicatedScreenDetail
    /// LastColumnValue الخاص بـ DedicatedScreenDetail
    /// </summary>
    public string LastColumnValue { get; private set; }

    /// <summary>
    /// FieldWidth of the DedicatedScreenDetail
    /// FieldWidth الخاص بـ DedicatedScreenDetail
    /// </summary>
    public decimal? FieldWidth { get; private set; }

    /// <summary>
    /// FieldUpdate of the DedicatedScreenDetail
    /// FieldUpdate الخاص بـ DedicatedScreenDetail
    /// </summary>
    public decimal? FieldUpdate { get; private set; }

    /// <summary>
    /// OrderNumberShort of the DedicatedScreenDetail
    /// OrderNumberShort الخاص بـ DedicatedScreenDetail
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }
}
}
