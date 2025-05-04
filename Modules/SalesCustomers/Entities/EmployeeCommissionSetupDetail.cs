using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// EmployeeCommissionSetupDetail Entity
/// </summary>
public class EmployeeCommissionSetupDetail : Entity<EmployeeCommissionSetupDetailId>
{
    private EmployeeCommissionSetupDetail() { }

    /// <summary>
    /// The unique identifier for the EmployeeCommissionSetupDetail
    /// المعرف الفريد لـ EmployeeCommissionSetupDetail
    /// </summary>
    public EmployeeCommissionSetupDetailId Id { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the EmployeeCommissionSetupDetail
    /// CommissionTypeShort الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// EmpNo of the EmployeeCommissionSetupDetail
    /// EmpNo الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// CClass of the EmployeeCommissionSetupDetail
    /// CClass الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// ItemCode of the EmployeeCommissionSetupDetail
    /// ItemCode الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the EmployeeCommissionSetupDetail
    /// ItemUnit الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// GuarantorCode of the EmployeeCommissionSetupDetail
    /// GuarantorCode الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ItemType of the EmployeeCommissionSetupDetail
    /// ItemType الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// FValue of the EmployeeCommissionSetupDetail
    /// FValue الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? FValue { get; private set; }

    /// <summary>
    /// TValue of the EmployeeCommissionSetupDetail
    /// TValue الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? TValue { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the EmployeeCommissionSetupDetail
    /// CommissionAmountTypeShort الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the EmployeeCommissionSetupDetail
    /// CommissionAmount الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// SliceDescription of the EmployeeCommissionSetupDetail
    /// SliceDescription الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public string SliceDescription { get; private set; }

    /// <summary>
    /// CommissionSliceNumber of the EmployeeCommissionSetupDetail
    /// CommissionSliceNumber الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? CommissionSliceNumber { get; private set; }

    /// <summary>
    /// PSize of the EmployeeCommissionSetupDetail
    /// PSize الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// CGroupCode of the EmployeeCommissionSetupDetail
    /// CGroupCode الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// EmpType of the EmployeeCommissionSetupDetail
    /// EmpType الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? EmpType { get; private set; }

    /// <summary>
    /// BillDocumentType of the EmployeeCommissionSetupDetail
    /// BillDocumentType الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? BillDocumentType { get; private set; }

    /// <summary>
    /// GroupCode of the EmployeeCommissionSetupDetail
    /// GroupCode الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public string GroupCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerClass
    /// </summary>
    public CustomerClass CustomerClass { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerGroup
    /// </summary>
    public CustomerGroup CustomerGroup { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GroupDetail
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemType
    /// </summary>
    public ItemType ItemType { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Measurement
    /// </summary>
    public Measurement Measurement { get; private set; }
    /// <summary>
    /// ManyToOne relationship to EmployeeCommissionSetupMaster
    /// </summary>
    public EmployeeCommissionSetupMaster EmployeeCommissionSetupMaster { get; private set; }
    #endregion
}
}
