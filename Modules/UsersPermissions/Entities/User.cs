using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// User Entity
/// </summary>
public class User : Entity<UserId>
{
    private User() { }

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
    /// GroupNumber of the User
    /// GroupNumber الخاص بـ User
    /// </summary>
    public decimal? GroupNumber { get; private set; }

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
    /// One-to-many relationship: User to BranchUserPrivilege
    /// </summary>
    public IReadOnlyCollection<BranchUserPrivilege> BranchUserPrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to MobileScreenPrivilege
    /// </summary>
    public IReadOnlyCollection<MobileScreenPrivilege> MobileScreenPrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to ScreenLink
    /// </summary>
    public IReadOnlyCollection<ScreenLink> ScreenLinks { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to UserTypePrivilege
    /// </summary>
    public IReadOnlyCollection<UserTypePrivilege> UserTypePrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to ApprovalAppDevice
    /// </summary>
    public IReadOnlyCollection<ApprovalAppDevice> ApprovalAppDevices { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to ApprovedMovement
    /// </summary>
    public IReadOnlyCollection<ApprovedMovement> ApprovedMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to ApprovedUser
    /// </summary>
    public IReadOnlyCollection<ApprovedUser> ApprovedUsers { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to UserHandheldDevice
    /// </summary>
    public IReadOnlyCollection<UserHandheldDevice> UserHandheldDevices { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to ApexScreenPrivilege
    /// </summary>
    public IReadOnlyCollection<ApexScreenPrivilege> ApexScreenPrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to Audit
    /// </summary>
    public IReadOnlyCollection<Audit> Audits { get; private set; }
    /// <summary>
    /// ManyToOne relationship to UserGroup
    /// </summary>
    public UserGroup UserGroup { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to Permission
    /// </summary>
    public IReadOnlyCollection<Permission> Permissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to CostCenterPermission
    /// </summary>
    public IReadOnlyCollection<CostCenterPermission> CostCenterPermissions { get; private set; }
    /// <summary>
    /// OneToOne relationship to FixedPermission
    /// </summary>
    public FixedPermission FixedPermission { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to GeneralPermission
    /// </summary>
    public IReadOnlyCollection<GeneralPermission> GeneralPermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to WarehousePermission
    /// </summary>
    public IReadOnlyCollection<WarehousePermission> WarehousePermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to AccountPermission
    /// </summary>
    public IReadOnlyCollection<AccountPermission> AccountPermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to CashPermission
    /// </summary>
    public IReadOnlyCollection<CashPermission> CashPermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to IncomeTypePermission
    /// </summary>
    public IReadOnlyCollection<IncomeTypePermission> IncomeTypePermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to OutgoingTypePermission
    /// </summary>
    public IReadOnlyCollection<OutgoingTypePermission> OutgoingTypePermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to RequestTypePermission
    /// </summary>
    public IReadOnlyCollection<RequestTypePermission> RequestTypePermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to TransferTypePermission
    /// </summary>
    public IReadOnlyCollection<TransferTypePermission> TransferTypePermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to PrivilegeActivity
    /// </summary>
    public IReadOnlyCollection<PrivilegeActivity> PrivilegeActivities { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to PrivilegeAccountsPayable
    /// </summary>
    public IReadOnlyCollection<PrivilegeAccountsPayable> PrivilegeAccountsPayables { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to PrivilegeAccountsReceivable
    /// </summary>
    public IReadOnlyCollection<PrivilegeAccountsReceivable> PrivilegeAccountsReceivables { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to PrivilegeCustomer
    /// </summary>
    public IReadOnlyCollection<PrivilegeCustomer> PrivilegeCustomers { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to PrivilegePrice
    /// </summary>
    public IReadOnlyCollection<PrivilegePrice> PrivilegePrices { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to PrivilegeProjects
    /// </summary>
    public IReadOnlyCollection<PrivilegeProjects> PrivilegeProjectses { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to PrivilegeStockAdjustmentTypes
    /// </summary>
    public IReadOnlyCollection<PrivilegeStockAdjustmentTypes> PrivilegeStockAdjustmentTypeses { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to PrivilegeVendor
    /// </summary>
    public IReadOnlyCollection<PrivilegeVendor> PrivilegeVendors { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to FavoriteScreen
    /// </summary>
    public IReadOnlyCollection<FavoriteScreen> FavoriteScreens { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to FormFieldPrivilege
    /// </summary>
    public IReadOnlyCollection<FormFieldPrivilege> FormFieldPrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to GeneralCodePrivilege
    /// </summary>
    public IReadOnlyCollection<GeneralCodePrivilege> GeneralCodePrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to GeneralLedgerRequestTypesPrivilege
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestTypesPrivilege> GeneralLedgerRequestTypesPrivileges { get; private set; }
    /// <summary>
    /// OneToOne relationship to UserHead
    /// </summary>
    public UserHead UserHead { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to ItemActivityPrivilege
    /// </summary>
    public IReadOnlyCollection<ItemActivityPrivilege> ItemActivityPrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to GeneralLedgerAccountDetailPrivilege
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerAccountDetailPrivilege> GeneralLedgerAccountDetailPrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to GeneralLedgerCurrencyUserLimit
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerCurrencyUserLimit> GeneralLedgerCurrencyUserLimits { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to DateOptionPrivilege
    /// </summary>
    public IReadOnlyCollection<DateOptionPrivilege> DateOptionPrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to JournalVoucherTypeDetail
    /// </summary>
    public IReadOnlyCollection<JournalVoucherTypeDetail> JournalVoucherTypeDetails { get; private set; }
    /// <summary>
    /// OneToOne relationship to DateLockUser
    /// </summary>
    public DateLockUser DateLockUser { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to DateLockUserScreen
    /// </summary>
    public IReadOnlyCollection<DateLockUserScreen> DateLockUserScreens { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to BillFollowupMovement
    /// </summary>
    public IReadOnlyCollection<BillFollowupMovement> BillFollowupMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to ScaleMovement
    /// </summary>
    public IReadOnlyCollection<ScaleMovement> ScaleMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to Branch
    /// </summary>
    public IReadOnlyCollection<Branch> Branches { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to MobileScreen
    /// </summary>
    public IReadOnlyCollection<MobileScreen> MobileScreens { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to FormDetail
    /// </summary>
    public IReadOnlyCollection<FormDetail> FormDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to SystemType
    /// </summary>
    public IReadOnlyCollection<SystemType> SystemTypes { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to ApprovedLevel
    /// </summary>
    public IReadOnlyCollection<ApprovedLevel> ApprovedLevels { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to ApexScreen
    /// </summary>
    public IReadOnlyCollection<ApexScreen> ApexScreens { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to CostCenter
    /// </summary>
    public IReadOnlyCollection<CostCenter> CostCenters { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to GroupDetail
    /// </summary>
    public IReadOnlyCollection<GroupDetail> GroupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to Warehouse
    /// </summary>
    public IReadOnlyCollection<Warehouse> Warehouses { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to AccountCurrency
    /// </summary>
    public IReadOnlyCollection<AccountCurrency> AccountCurrencies { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to IncomeType
    /// </summary>
    public IReadOnlyCollection<IncomeType> IncomeTypes { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to OutgoingType
    /// </summary>
    public IReadOnlyCollection<OutgoingType> OutgoingTypes { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to RequestType
    /// </summary>
    public IReadOnlyCollection<RequestType> RequestTypes { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to TransferType
    /// </summary>
    public IReadOnlyCollection<TransferType> TransferTypes { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to Activity
    /// </summary>
    public IReadOnlyCollection<Activity> Activities { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to CustomerCurrency
    /// </summary>
    public IReadOnlyCollection<CustomerCurrency> CustomerCurrencies { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to PricingLevel
    /// </summary>
    public IReadOnlyCollection<PricingLevel> PricingLevels { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to Project
    /// </summary>
    public IReadOnlyCollection<Project> Projects { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to StockAdjustmentType
    /// </summary>
    public IReadOnlyCollection<StockAdjustmentType> StockAdjustmentTypes { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to VendorCurrency
    /// </summary>
    public IReadOnlyCollection<VendorCurrency> VendorCurrencies { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to FormField
    /// </summary>
    public IReadOnlyCollection<FormField> FormFields { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to GeneralLedgerRequestTypes
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestTypes> GeneralLedgerRequestTypeses { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to ItemActivity
    /// </summary>
    public IReadOnlyCollection<ItemActivity> ItemActivities { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to GeneralLedgerAccountDetailCurrency
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerAccountDetailCurrency> GeneralLedgerAccountDetailCurrencies { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to ExchangeRate
    /// </summary>
    public IReadOnlyCollection<ExchangeRate> ExchangeRates { get; private set; }
    /// <summary>
    /// One-to-many relationship: User to JournalVoucherType
    /// </summary>
    public IReadOnlyCollection<JournalVoucherType> JournalVoucherTypes { get; private set; }
    #endregion
}
}
