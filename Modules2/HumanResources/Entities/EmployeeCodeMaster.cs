using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;
namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeCodeMaster Entity
/// </summary>
public class EmployeeCodeMaster : Entity<EmployeeCodeMasterId>
{

    private EmployeeCodeMaster() { }

    public EmployeeCodeMaster(EmployeeCodeMasterId id, decimal? codeType)
    {
        Id = id;
        CodeType = codeType;
    }

    /// <summary>
    /// The unique identifier for the EmployeeCodeMaster
    /// المعرف الفريد لـ EmployeeCodeMaster
    /// </summary>
    public EmployeeCodeMasterId Id { get; private set; }

    /// <summary>
    /// CodeType of the EmployeeCodeMaster
    /// CodeType الخاص بـ EmployeeCodeMaster
    /// </summary>
    public decimal? CodeType { get; private set; }

    /// <summary>
    /// TypeLastNameShort of the EmployeeCodeMaster
    /// TypeLastNameShort الخاص بـ EmployeeCodeMaster
    /// </summary>
    public string TypeLastNameShort { get; private set; }

    /// <summary>
    /// TypeFirstNameShort of the EmployeeCodeMaster
    /// TypeFirstNameShort الخاص بـ EmployeeCodeMaster
    /// </summary>
    public string TypeFirstNameShort { get; private set; }

    /// <summary>
    /// InactiveFlag of the EmployeeCodeMaster
    /// InactiveFlag الخاص بـ EmployeeCodeMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// FromType of the EmployeeCodeMaster
    /// FromType الخاص بـ EmployeeCodeMaster
    /// </summary>
    public decimal? FromType { get; private set; }

    /// <summary>
    /// UseLawFlag of the EmployeeCodeMaster
    /// UseLawFlag الخاص بـ EmployeeCodeMaster
    /// </summary>
    public decimal? UseLawFlag { get; private set; }

    /// <summary>
    /// FlagCode of the EmployeeCodeMaster
    /// FlagCode الخاص بـ EmployeeCodeMaster
    /// </summary>
    public string FlagCode { get; private set; }

    /// <summary>
    /// TableNameLabel of the EmployeeCodeMaster
    /// TableNameLabel الخاص بـ EmployeeCodeMaster
    /// </summary>
    public string TableNameLabel { get; private set; }

    /// <summary>
    /// ColumnNameShort of the EmployeeCodeMaster
    /// ColumnNameShort الخاص بـ EmployeeCodeMaster
    /// </summary>
    public string ColumnNameShort { get; private set; }

    /// <summary>
    /// ColumnValue of the EmployeeCodeMaster
    /// ColumnValue الخاص بـ EmployeeCodeMaster
    /// </summary>
    public string ColumnValue { get; private set; }

    /// <summary>
    /// FieldNameShort of the EmployeeCodeMaster
    /// FieldNameShort الخاص بـ EmployeeCodeMaster
    /// </summary>
    public string FieldNameShort { get; private set; }

    /// <summary>
    /// EmpFlg of the EmployeeCodeMaster
    /// EmpFlg الخاص بـ EmployeeCodeMaster
    /// </summary>
    public decimal? EmpFlg { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

