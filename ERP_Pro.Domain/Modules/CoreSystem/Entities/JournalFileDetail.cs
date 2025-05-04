using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل تفاصيل ملف اليومية ويحتوي على جميع خصائص وتفاصيل القيد المحاسبي.
    public class JournalFileDetail : Entity<JournalFileDetailId>
    {
        // المعرف الفريد لتفاصيل ملف اليومية (مفتاح رئيسي).
        public JournalFileDetailId Id { get; private set; }
        // نوع المستند.
        public decimal? DocType { get; private set; }
        // نوع قيد اليومية الكامل.
        public decimal? JournalVoucherTypeFull { get; private set; }
        // رقم مستند اليومية.
        public decimal? JournalDocumentNumber { get; private set; }
        // كود الحساب الخارجي.
        public string AccountCodeExternal { get; private set; }
        // كود تفاصيل الحساب.
        public string AccountDetailCode { get; private set; }
        // كود تفاصيل الحساب الفرعي.
        public string AccountDetailSubCode { get; private set; }
        // نوع تفاصيل الحساب.
        public decimal? AccountDetailType { get; private set; }
        // كود تحليل الحساب الخارجي.
        public string AccountCodeAnalysisExternal { get; private set; }
        // عملة الحساب الخارجي.
        public string AccountCurrencyExternal { get; private set; }
        // وصف القيد.
        public string JournalDescription { get; private set; }
        // مبلغ المدين.
        public decimal? DrAmt { get; private set; }
        // مبلغ الدائن.
        public decimal? CreditAmount { get; private set; }
        // مبلغ المدين بالعملة الأجنبية.
        public decimal? DrAmtF { get; private set; }
        // مبلغ الدائن بالعملة الأجنبية.
        public decimal? CreditAmountForeignShort { get; private set; }
        // سعر الحساب.
        public decimal? AccountRate { get; private set; }
        // كود مركز التكلفة الخارجي.
        public string CostCenterCodeExternal { get; private set; }
        // رقم المشروع.
        public string ProjectNumber { get; private set; }
        // رقم المشروع الخارجي.
        public string ProjectNumberExternal { get; private set; }
        // رقم النشاط الخارجي.
        public string ActivityNumberExternal { get; private set; }
        // كود المندوب.
        public string RepCode { get; private set; }
        // رقم المجموعة الكامل.
        public string GroupNumberFull { get; private set; }
        // رقم الصندوق أو البنك.
        public decimal? CashBankNumber { get; private set; }
        // رقم السجل.
        public decimal? RecordNumber { get; private set; }
        // ترتيب السجل.
        public decimal? RecordNumberOrder { get; private set; }
        // نوع المستند المرجعي.
        public decimal? DocTypeRef { get; private set; }
        // نوع قيد اليومية المرجعي.
        public decimal? DocJvTypeRef { get; private set; }
        // رقم المستند المرجعي.
        public decimal? DocNoRef { get; private set; }
        // تسلسل المستند المرجعي.
        public decimal? DocSerRef { get; private set; }
        // تاريخ استحقاق المستند.
        public DateTime? DocDueDate { get; private set; }
        // رقم الفاتورة.
        public decimal? BillNumber { get; private set; }
        // تسلسل الفاتورة.
        public decimal? BillSerial { get; private set; }
        // رقم الصنف.
        public decimal? ItemNumber { get; private set; }
        // رقم أمر العمل.
        public decimal? WorkOrderNumber { get; private set; }
        // تسلسل أمر العمل.
        public decimal? WorkOrderSerial { get; private set; }
        // رقم المرجع.
        public string ReferenceNumber { get; private set; }
        // رقم الشيك.
        public decimal? ChequeNumber { get; private set; }
        // تسلسل المستند.
        public decimal? DocSequence { get; private set; }
        // رقم الشركة المختصر.
        public decimal? CompanyNumberShort { get; private set; }
        // رقم الفرع.
        public decimal? BranchNumber { get; private set; }
        // سنة الفرع.
        public decimal? BranchYear { get; private set; }
        // المستخدم المسؤول عن الفرع.
        public decimal? BranchUser { get; private set; }
        // رقم الملاحظة.
        public string NoteNumber { get; private set; }
        // رقم فرع المستند.
        public decimal? DocBrnNo { get; private set; }
        #region Navigation Properties
        // النشاط المرتبط بالقيد.
        public Activity Activity { get; private set; }
        // ملف اليومية الرئيسي المرتبط.
        public JournalFileMaster JournalFileMaster { get; private set; }
        // عملة الحساب المرتبطة.
        public AccountCurrency AccountCurrency { get; private set; }
        // المحصل المرتبط.
        public Collector Collector { get; private set; }
        // مركز التكلفة المرتبط.
        public CostCenter CostCenter { get; private set; }
        // العميل المرتبط.
        public Customer Customer { get; private set; }
        // تفاصيل السند المرتبطة.
        public VoucherDetails VoucherDetails { get; private set; }
        // اعتماد مستندي مرتبط.
        public LetterOfCreditMaster LetterOfCreditMaster { get; private set; }
        #endregion
        #region Methods
        // أضف هنا منطق الدومين الخاص بتفاصيل ملف اليومية
        #endregion
    }
}
