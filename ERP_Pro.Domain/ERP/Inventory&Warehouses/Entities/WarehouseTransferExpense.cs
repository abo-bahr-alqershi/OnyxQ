using System;
using System.Collections.Generic;

public class WarehouseTransferExpense : AggregateRoot
{
    #region Basic Info
    public Guid Id { get; private set; }
    public DocumentInfo DocumentInfo { get; private set; }  // Encapsulate DocNo, DocSerial, DocDesc, RefNo
    public TransferInOutType TransferType { get; private set; }
    #endregion

    #region Account Info
    public AccountInfo AccountInfo { get; private set; }  // Encapsulate AccountCode, AccountDtlCode, AccountDtlType
    public CurrencyInfo CurrencyInfo { get; private set; }  // Encapsulate CurrencyCode, AccountRate
    #endregion

    #region References
    public ReferenceInfo References { get; private set; }  // Encapsulate CostCenterCode, ProjectNo, ActivityNo
    #endregion

    #region Amounts
    public Money Amount { get; private set; }
    public Money InventoryAmount { get; private set; }
    #endregion

    #region Status
    public int? ExternalPost { get; private set; }
    public long? RecordNo { get; private set; }
    #endregion

    #region Company Info
    public CompanyInfo CompanyInfo { get; private set; }
    public BranchInfo BranchInfo { get; private set; }
    #endregion

    // Add methods for operations
    public void UpdateAmounts(Money amount, Money inventoryAmount)
    public void UpdateAccountInfo(AccountInfo accountInfo)
    public void UpdateCurrencyInfo(CurrencyInfo currencyInfo)
    public void MarkAsPosted(int externalPost)
}

// Add Value Objects
public record AccountInfo
{
    public string AccountCode { get; }
    public string? AccountDetailCode { get; }
    public short? AccountDetailType { get; }
    
    private AccountInfo(string accountCode, string? detailCode, short? detailType)
    {
        if (string.IsNullOrWhiteSpace(accountCode))
            throw new DomainException("Account code is required");
            
        AccountCode = accountCode;
        AccountDetailCode = detailCode;
        AccountDetailType = detailType;
    }
    
    public static AccountInfo Create(string accountCode, string? detailCode = null, short? detailType = null) =>
        new(accountCode, detailCode, detailType);
}

public record CurrencyInfo
{
    public string Code { get; }
    public int? Rate { get; }
    
    private CurrencyInfo(string code, int? rate)
    {
        if (string.IsNullOrWhiteSpace(code))
            throw new DomainException("Currency code is required");
            
        Code = code;
        Rate = rate;
    }
    
    public static CurrencyInfo Create(string code, int? rate = null) =>
        new(code, rate);
}

public class ItemGroupTree : AggregateRoot
{
    public Guid Id { get; private set; }
    public GroupInfo GroupInfo { get; private set; }  // Code, CodeTree, Name, Level
    public ItemInfo ItemInfo { get; private set; }
    public WarehouseInfo WarehouseInfo { get; private set; }
    public BatchInfo BatchInfo { get; private set; }
    public ItemDimensions Dimensions { get; private set; }
    
    // Add methods for operations
    public void UpdateGroupInfo(GroupInfo groupInfo)
    public void UpdateItemInfo(ItemInfo itemInfo)
    public void UpdateDimensions(ItemDimensions dimensions)
}

public class ItemLevelMeasure : AggregateRoot
{
    public Guid Id { get; private set; }
    public short? LevelNumber { get; private set; }
    public MeasurementInfo MeasurementInfo { get; private set; }
    public ItemRatios Ratios { get; private set; }
    public SalesMetrics SalesMetrics { get; private set; }
    
    // Add methods for operations
    public void UpdateMeasurementInfo(MeasurementInfo info)
    public void UpdateRatios(ItemRatios ratios)
    public void UpdateSalesMetrics(SalesMetrics metrics)
}