using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;
using ERP_Pro.Domain.ERP.FixedAssets.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// User Entity
/// </summary>
public class User : AggregateRoot<UserId>
{

    private User() { }

    public User(UserId id, decimal? userId)
    {
        Id = id;
        UserId = userId;
    }

    /// <summary>
    /// The unique identifier for the User
    /// المعرف الفريد لـ User
    /// </summary>
    public UserId Id { get; private set; }

    /// <summary>
    /// UserId of the User
    /// UserId الخاص بـ User
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// UserArabicName of the User
    /// UserArabicName الخاص بـ User
    /// </summary>
    public string UserArabicName { get; private set; }

    /// <summary>
    /// UserEnglishName of the User
    /// UserEnglishName الخاص بـ User
    /// </summary>
    public string UserEnglishName { get; private set; }

    /// <summary>
    /// UserManager of the User
    /// UserManager الخاص بـ User
    /// </summary>
    public decimal? UserManager { get; private set; }

    /// <summary>
    /// Password of the User
    /// Password الخاص بـ User
    /// </summary>
    public string Password { get; private set; }

    /// <summary>
    /// Password2 of the User
    /// Password2 الخاص بـ User
    /// </summary>
    public string Password2 { get; private set; }

    /// <summary>
    /// SStartDate of the User
    /// SStartDate الخاص بـ User
    /// </summary>
    public DateTime? SStartDate { get; private set; }

    /// <summary>
    /// SEndDate of the User
    /// SEndDate الخاص بـ User
    /// </summary>
    public DateTime? SEndDate { get; private set; }

    /// <summary>
    /// SStartTime of the User
    /// SStartTime الخاص بـ User
    /// </summary>
    public string SStartTime { get; private set; }

    /// <summary>
    /// SEndTime of the User
    /// SEndTime الخاص بـ User
    /// </summary>
    public string SEndTime { get; private set; }

    /// <summary>
    /// LoginMethod of the User
    /// LoginMethod الخاص بـ User
    /// </summary>
    public decimal? LoginMethod { get; private set; }

    /// <summary>
    /// Dayactive of the User
    /// Dayactive الخاص بـ User
    /// </summary>
    public decimal? Dayactive { get; private set; }

    /// <summary>
    /// InactiveFlag of the User
    /// InactiveFlag الخاص بـ User
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the User
    /// InactiveDate الخاص بـ User
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the User
    /// InactivatedByUserId الخاص بـ User
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveReason of the User
    /// InactiveReason الخاص بـ User
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// AccountCode of the User
    /// AccountCode الخاص بـ User
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// UserType of the User
    /// UserType الخاص بـ User
    /// </summary>
    public decimal? UserType { get; private set; }

    /// <summary>
    /// AdminUser of the User
    /// AdminUser الخاص بـ User
    /// </summary>
    public decimal? AdminUser { get; private set; }

    /// <summary>
    /// ChangePasswordAfterLogin of the User
    /// ChangePasswordAfterLogin الخاص بـ User
    /// </summary>
    public decimal? ChangePasswordAfterLogin { get; private set; }

    /// <summary>
    /// UserOnlineFlag of the User
    /// UserOnlineFlag الخاص بـ User
    /// </summary>
    public decimal? UserOnlineFlag { get; private set; }

    /// <summary>
    /// ConnectionWebSystem of the User
    /// ConnectionWebSystem الخاص بـ User
    /// </summary>
    public decimal? ConnectionWebSystem { get; private set; }

    /// <summary>
    /// UpdatePasswordCount of the User
    /// UpdatePasswordCount الخاص بـ User
    /// </summary>
    public decimal? UpdatePasswordCount { get; private set; }

    /// <summary>
    /// ScreenThemeNumber of the User
    /// ScreenThemeNumber الخاص بـ User
    /// </summary>
    public decimal? ScreenThemeNumber { get; private set; }

    /// <summary>
    /// PrinterBarcodeDefaultName of the User
    /// PrinterBarcodeDefaultName الخاص بـ User
    /// </summary>
    public string PrinterBarcodeDefaultName { get; private set; }

    /// <summary>
    /// PrinterBarcodePath of the User
    /// PrinterBarcodePath الخاص بـ User
    /// </summary>
    public string PrinterBarcodePath { get; private set; }

    /// <summary>
    /// HoursUserWebSystem of the User
    /// HoursUserWebSystem الخاص بـ User
    /// </summary>
    public decimal? HoursUserWebSystem { get; private set; }

    /// <summary>
    /// TerminalName of the User
    /// TerminalName الخاص بـ User
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// TerminalLogin of the User
    /// TerminalLogin الخاص بـ User
    /// </summary>
    public string TerminalLogin { get; private set; }

    /// <summary>
    /// Occupation of the User
    /// Occupation الخاص بـ User
    /// </summary>
    public string Occupation { get; private set; }

    /// <summary>
    /// LoginFlag of the User
    /// LoginFlag الخاص بـ User
    /// </summary>
    public string LoginFlag { get; private set; }

    /// <summary>
    /// LogoutFlag of the User
    /// LogoutFlag الخاص بـ User
    /// </summary>
    public string LogoutFlag { get; private set; }

    /// <summary>
    /// LoggedOnFlag of the User
    /// LoggedOnFlag الخاص بـ User
    /// </summary>
    public decimal? LoggedOnFlag { get; private set; }

    /// <summary>
    /// LoginCount of the User
    /// LoginCount الخاص بـ User
    /// </summary>
    public decimal? LoginCount { get; private set; }

    /// <summary>
    /// ConnectionBranchNumber of the User
    /// ConnectionBranchNumber الخاص بـ User
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    /// <summary>
    /// ConnectionType of the User
    /// ConnectionType الخاص بـ User
    /// </summary>
    public decimal? ConnectionType { get; private set; }

    /// <summary>
    /// MachineNumber of the User
    /// MachineNumber الخاص بـ User
    /// </summary>
    public decimal? MachineNumber { get; private set; }

    /// <summary>
    /// WarehouseCodeDefault of the User
    /// WarehouseCodeDefault الخاص بـ User
    /// </summary>
    public decimal? WarehouseCodeDefault { get; private set; }

    /// <summary>
    /// CostCenterCodeDefault of the User
    /// CostCenterCodeDefault الخاص بـ User
    /// </summary>
    public string CostCenterCodeDefault { get; private set; }

    /// <summary>
    /// CashNumberDefault of the User
    /// CashNumberDefault الخاص بـ User
    /// </summary>
    public decimal? CashNumberDefault { get; private set; }

    /// <summary>
    /// CashNumber of the User
    /// CashNumber الخاص بـ User
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// EmpNo of the User
    /// EmpNo الخاص بـ User
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// RepCode of the User
    /// RepCode الخاص بـ User
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// LoanAccountCode of the User
    /// LoanAccountCode الخاص بـ User
    /// </summary>
    public string LoanAccountCode { get; private set; }

    /// <summary>
    /// LoanAccountCodeDetail of the User
    /// LoanAccountCodeDetail الخاص بـ User
    /// </summary>
    public string LoanAccountCodeDetail { get; private set; }

    /// <summary>
    /// InheritUserId of the User
    /// InheritUserId الخاص بـ User
    /// </summary>
    public decimal? InheritUserId { get; private set; }

    /// <summary>
    /// UseResolutionScreen of the User
    /// UseResolutionScreen الخاص بـ User
    /// </summary>
    public decimal? UseResolutionScreen { get; private set; }

    /// <summary>
    /// WarehouseCodeKeeper of the User
    /// WarehouseCodeKeeper الخاص بـ User
    /// </summary>
    public decimal? WarehouseCodeKeeper { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the User
    /// ColumnNumberShort الخاص بـ User
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// VerificationType of the User
    /// VerificationType الخاص بـ User
    /// </summary>
    public decimal? VerificationType { get; private set; }

    /// <summary>
    /// PdaName of the User
    /// PdaName الخاص بـ User
    /// </summary>
    public string PdaName { get; private set; }

    /// <summary>
    /// WordPath of the User
    /// WordPath الخاص بـ User
    /// </summary>
    public string WordPath { get; private set; }

    /// <summary>
    /// ExcelPath of the User
    /// ExcelPath الخاص بـ User
    /// </summary>
    public string ExcelPath { get; private set; }

    /// <summary>
    /// RmsUserType of the User
    /// RmsUserType الخاص بـ User
    /// </summary>
    public decimal? RmsUserType { get; private set; }

    /// <summary>
    /// LowLevelPrice of the User
    /// LowLevelPrice الخاص بـ User
    /// </summary>
    public decimal? LowLevelPrice { get; private set; }

    /// <summary>
    /// HighLevelPrice of the User
    /// HighLevelPrice الخاص بـ User
    /// </summary>
    public decimal? HighLevelPrice { get; private set; }

    /// <summary>
    /// DfltLvlPrice of the User
    /// DfltLvlPrice الخاص بـ User
    /// </summary>
    public decimal? DfltLvlPrice { get; private set; }

    /// <summary>
    /// RmsUserDefaultBillDocumentType of the User
    /// RmsUserDefaultBillDocumentType الخاص بـ User
    /// </summary>
    public decimal? RmsUserDefaultBillDocumentType { get; private set; }

    /// <summary>
    /// RmsDefaultHall of the User
    /// RmsDefaultHall الخاص بـ User
    /// </summary>
    public decimal? RmsDefaultHall { get; private set; }

    /// <summary>
    /// ImageEditorPath of the User
    /// ImageEditorPath الخاص بـ User
    /// </summary>
    public string ImageEditorPath { get; private set; }

    /// <summary>
    /// ExplorerPath of the User
    /// ExplorerPath الخاص بـ User
    /// </summary>
    public string ExplorerPath { get; private set; }

    /// <summary>
    /// DfltClcVatPriceTyp of the User
    /// DfltClcVatPriceTyp الخاص بـ User
    /// </summary>
    public decimal? DfltClcVatPriceTyp { get; private set; }

    /// <summary>
    /// MobileNumber of the User
    /// MobileNumber الخاص بـ User
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// CssUserFlag of the User
    /// CssUserFlag الخاص بـ User
    /// </summary>
    public decimal? CssUserFlag { get; private set; }

    /// <summary>
    /// DriverNo of the User
    /// DriverNo الخاص بـ User
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// ExcessAccountCode of the User
    /// ExcessAccountCode الخاص بـ User
    /// </summary>
    public string ExcessAccountCode { get; private set; }

    /// <summary>
    /// ExcessAccountCodeDetail of the User
    /// ExcessAccountCodeDetail الخاص بـ User
    /// </summary>
    public string ExcessAccountCodeDetail { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public UserGroup UserGroup { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

