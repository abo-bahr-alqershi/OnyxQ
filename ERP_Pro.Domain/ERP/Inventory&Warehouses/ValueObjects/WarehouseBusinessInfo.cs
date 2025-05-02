using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects
{
    public class WarehouseBusinessInfo : ValueObject
    {
        public string? ProjectNumber { get; private set; }
        public string? ActivityCode { get; private set; }
        public string? SalesOrderDescription { get; private set; }
        public int? SalesOrderType { get; private set; }
        public int? ServiceCenterNumber { get; private set; }
        public int? BankNumber { get; private set; }
        public string? ReportCode { get; private set; }
        public int? ColumnNumber { get; private set; }
        public string? CustomerCode { get; private set; }
        public int? CalculationTypeNoTax { get; private set; }
        public int? CustomerGroupCode { get; private set; }

        private WarehouseBusinessInfo() { } // For EF Core

        public WarehouseBusinessInfo(
            string? projectNumber = null,
            string? activityCode = null,
            string? salesOrderDescription = null,
            int? salesOrderType = null,
            int? serviceCenterNumber = null,
            int? bankNumber = null,
            string? reportCode = null,
            int? columnNumber = null,
            string? customerCode = null,
            int? calculationTypeNoTax = null,
            int? customerGroupCode = null)
        {
            ProjectNumber = projectNumber;
            ActivityCode = activityCode;
            SalesOrderDescription = salesOrderDescription;
            SalesOrderType = salesOrderType;
            ServiceCenterNumber = serviceCenterNumber;
            BankNumber = bankNumber;
            ReportCode = reportCode;
            ColumnNumber = columnNumber;
            CustomerCode = customerCode;
            CalculationTypeNoTax = calculationTypeNoTax;
            CustomerGroupCode = customerGroupCode;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return ProjectNumber ?? string.Empty;
            yield return ActivityCode ?? string.Empty;
            yield return SalesOrderDescription ?? string.Empty;
            yield return SalesOrderType ?? 0;
            yield return ServiceCenterNumber ?? 0;
            yield return BankNumber ?? 0;
            yield return ReportCode ?? string.Empty;
            yield return ColumnNumber ?? 0;
            yield return CustomerCode ?? string.Empty;
            yield return CalculationTypeNoTax ?? 0;
            yield return CustomerGroupCode ?? 0;
        }

        public WarehouseBusinessInfo Update(
            string? projectNumber = null,
            string? activityCode = null,
            string? salesOrderDescription = null,
            int? salesOrderType = null,
            int? serviceCenterNumber = null,
            int? bankNumber = null,
            string? reportCode = null,
            int? columnNumber = null,
            string? customerCode = null,
            int? calculationTypeNoTax = null,
            int? customerGroupCode = null)
        {
            return new WarehouseBusinessInfo(
                projectNumber ?? ProjectNumber,
                activityCode ?? ActivityCode,
                salesOrderDescription ?? SalesOrderDescription,
                salesOrderType ?? SalesOrderType,
                serviceCenterNumber ?? ServiceCenterNumber,
                bankNumber ?? BankNumber,
                reportCode ?? ReportCode,
                columnNumber ?? ColumnNumber,
                customerCode ?? CustomerCode,
                calculationTypeNoTax ?? CalculationTypeNoTax,
                customerGroupCode ?? CustomerGroupCode
            );
        }
    }
} 