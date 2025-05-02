# جميع العلاقات دومينيًا (الاسم الحديث + القديم)

## المستودعات والمخزون

### العلاقات الرئيسية
Warehouse (WAREHOUSE_DETAILS) * ---- 1 WarehouseGroup (WAREHOUSE_GROUP)   (Warehouse.WarehouseGroupId → WarehouseGroup.Id)
Warehouse (WAREHOUSE_DETAILS) * ---- 1 Account (ACCOUNT)   (Warehouse.TransferAccountId → Account.Id)
Warehouse (WAREHOUSE_DETAILS) * ---- 1 CostCenter (COST_CENTER)   (Warehouse.CostCenterId → CostCenter.Id)
Warehouse (WAREHOUSE_DETAILS) * ---- 1 Country (COUNTRY)   (Warehouse.CountryId → Country.Id)
Warehouse (WAREHOUSE_DETAILS) * ---- 1 Province (PROVINCE)   (Warehouse.ProvinceId → Province.Id)
Warehouse (WAREHOUSE_DETAILS) * ---- 1 City (CITY)   (Warehouse.CityId → City.Id)
Warehouse (WAREHOUSE_DETAILS) * ---- 1 Region (REGION)   (Warehouse.RegionId → Region.Id)

### العلاقات الفرعية
Warehouse (WAREHOUSE_DETAILS) 1 ---- * InventoryBinDetail (INVENTORY_BIN_DETAIL)   (InventoryBinDetail.WarehouseId → Warehouse.Id)
Warehouse (WAREHOUSE_DETAILS) 1 ---- * ItemMovement (ITEM_MOVEMENT)   (ItemMovement.WarehouseId → Warehouse.Id)
Warehouse (WAREHOUSE_DETAILS) 1 ---- * ItemPrice (ITEM_PRICE)   (ItemPrice.WarehouseId → Warehouse.Id)
Warehouse (WAREHOUSE_DETAILS) 1 ---- * WarehousePrivilege (PRIVILEGE_WAREHOUSE)   (WarehousePrivilege.WarehouseId → Warehouse.Id)

WarehouseGroup (WAREHOUSE_GROUP) 1 ---- * SalesDiscount (SALES_DISCOUNT)   (SalesDiscount.WarehouseGroupId → WarehouseGroup.Id)
WarehouseGroup (WAREHOUSE_GROUP) 1 ---- * SalesFreeQty (SALES_FREE_QTY)   (SalesFreeQty.WarehouseGroupId → WarehouseGroup.Id)

// ... existing code ...
