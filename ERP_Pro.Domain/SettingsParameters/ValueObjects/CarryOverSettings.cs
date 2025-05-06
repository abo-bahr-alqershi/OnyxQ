using System;
using ERP_Pro.Domain.Common.Base;

namespace ERP_Pro.Domain.SettingsParameters.ValueObjects
{
    /// <summary>
    /// كائن قيمة لإعدادات ترحيل الأرصدة
    /// </summary>
    public class CarryOverSettings : ValueObject
    {
        /// <summary>
        /// ترحيل أرصدة الأصول
        /// </summary>
        public bool CarryOverAssets { get; private set; }

        /// <summary>
        /// ترحيل أرصدة الخصوم
        /// </summary>
        public bool CarryOverLiabilities { get; private set; }

        /// <summary>
        /// ترحيل أرصدة حقوق الملكية
        /// </summary>
        public bool CarryOverEquity { get; private set; }

        /// <summary>
        /// ترحيل أرصدة العملاء
        /// </summary>
        public bool CarryOverCustomers { get; private set; }

        /// <summary>
        /// ترحيل أرصدة الموردين
        /// </summary>
        public bool CarryOverVendors { get; private set; }

        /// <summary>
        /// ترحيل أرصدة المخزون
        /// </summary>
        public bool CarryOverInventory { get; private set; }

        /// <summary>
        /// ترحيل أرصدة البنود المفتوحة
        /// </summary>
        public bool CarryOverOpenItems { get; private set; }

        /// <summary>
        /// ترحيل الميزانيات التقديرية
        /// </summary>
        public bool CarryOverBudgets { get; private set; }

        /// <summary>
        /// إضافة قيود التسوية التلقائية قبل الترحيل
        /// </summary>
        public bool AutoAdjustBeforeCarryOver { get; private set; }

        /// <summary>
        /// طريقة حساب الأرباح المحتجزة
        /// </summary>
        public string RetainedEarningsMethod { get; private set; }

        /// <summary>
        /// المنشئ الافتراضي
        /// </summary>
        public CarryOverSettings()
        {
            // القيم الافتراضية
            CarryOverAssets = true;
            CarryOverLiabilities = true;
            CarryOverEquity = true;
            CarryOverCustomers = true;
            CarryOverVendors = true;
            CarryOverInventory = true;
            CarryOverOpenItems = true;
            CarryOverBudgets = false;
            AutoAdjustBeforeCarryOver = true;
            RetainedEarningsMethod = "Standard";
        }

        /// <summary>
        /// المنشئ المخصص
        /// </summary>
        public CarryOverSettings(
            bool carryOverAssets,
            bool carryOverLiabilities,
            bool carryOverEquity,
            bool carryOverCustomers,
            bool carryOverVendors,
            bool carryOverInventory,
            bool carryOverOpenItems,
            bool carryOverBudgets,
            bool autoAdjustBeforeCarryOver,
            string retainedEarningsMethod)
        {
            CarryOverAssets = carryOverAssets;
            CarryOverLiabilities = carryOverLiabilities;
            CarryOverEquity = carryOverEquity;
            CarryOverCustomers = carryOverCustomers;
            CarryOverVendors = carryOverVendors;
            CarryOverInventory = carryOverInventory;
            CarryOverOpenItems = carryOverOpenItems;
            CarryOverBudgets = carryOverBudgets;
            AutoAdjustBeforeCarryOver = autoAdjustBeforeCarryOver;
            RetainedEarningsMethod = !string.IsNullOrEmpty(retainedEarningsMethod) ? retainedEarningsMethod : "Standard";
        }

        /// <summary>
        /// إنشاء نسخة جديدة من كائن القيمة بالبيانات المحدثة
        /// </summary>
        public CarryOverSettings WithChanges(
            bool? carryOverAssets = null,
            bool? carryOverLiabilities = null,
            bool? carryOverEquity = null,
            bool? carryOverCustomers = null,
            bool? carryOverVendors = null,
            bool? carryOverInventory = null,
            bool? carryOverOpenItems = null,
            bool? carryOverBudgets = null,
            bool? autoAdjustBeforeCarryOver = null,
            string retainedEarningsMethod = null)
        {
            return new CarryOverSettings(
                carryOverAssets ?? CarryOverAssets,
                carryOverLiabilities ?? CarryOverLiabilities,
                carryOverEquity ?? CarryOverEquity,
                carryOverCustomers ?? CarryOverCustomers,
                carryOverVendors ?? CarryOverVendors,
                carryOverInventory ?? CarryOverInventory,
                carryOverOpenItems ?? CarryOverOpenItems,
                carryOverBudgets ?? CarryOverBudgets,
                autoAdjustBeforeCarryOver ?? AutoAdjustBeforeCarryOver,
                retainedEarningsMethod ?? RetainedEarningsMethod
            );
        }

        /// <summary>
        /// المقارنة مع كائن قيمة آخر
        /// </summary>
        protected override bool EqualsCore(ValueObject other)
        {
            var otherSettings = (CarryOverSettings)other;
            return CarryOverAssets == otherSettings.CarryOverAssets &&
                   CarryOverLiabilities == otherSettings.CarryOverLiabilities &&
                   CarryOverEquity == otherSettings.CarryOverEquity &&
                   CarryOverCustomers == otherSettings.CarryOverCustomers &&
                   CarryOverVendors == otherSettings.CarryOverVendors &&
                   CarryOverInventory == otherSettings.CarryOverInventory &&
                   CarryOverOpenItems == otherSettings.CarryOverOpenItems &&
                   CarryOverBudgets == otherSettings.CarryOverBudgets &&
                   AutoAdjustBeforeCarryOver == otherSettings.AutoAdjustBeforeCarryOver &&
                   RetainedEarningsMethod == otherSettings.RetainedEarningsMethod;
        }

        /// <summary>
        /// حساب الهاشكود
        /// </summary>
        protected override int GetHashCodeCore()
        {
            unchecked
            {
                int hashCode = CarryOverAssets.GetHashCode();
                hashCode = (hashCode * 397) ^ CarryOverLiabilities.GetHashCode();
                hashCode = (hashCode * 397) ^ CarryOverEquity.GetHashCode();
                hashCode = (hashCode * 397) ^ CarryOverCustomers.GetHashCode();
                hashCode = (hashCode * 397) ^ CarryOverVendors.GetHashCode();
                hashCode = (hashCode * 397) ^ CarryOverInventory.GetHashCode();
                hashCode = (hashCode * 397) ^ CarryOverOpenItems.GetHashCode();
                hashCode = (hashCode * 397) ^ CarryOverBudgets.GetHashCode();
                hashCode = (hashCode * 397) ^ AutoAdjustBeforeCarryOver.GetHashCode();
                hashCode = (hashCode * 397) ^ (RetainedEarningsMethod != null ? RetainedEarningsMethod.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
} 