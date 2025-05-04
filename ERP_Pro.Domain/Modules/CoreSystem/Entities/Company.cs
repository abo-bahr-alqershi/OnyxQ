using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل الشركة ويحتوي على جميع بيانات الشركة الأساسية والتفصيلية.
public class Company : Entity<CompanyId>
{
    private Company() { }

    public Company(CompanyId id, decimal? companyNumberShort)
    {
        Id = id;
        CompanyNumberShort = companyNumberShort;
    }

    // المعرف الفريد للشركة (مفتاح رئيسي).
    public CompanyId Id { get; private set; }
    // الرقم المختصر للشركة.
    public decimal? CompanyNumberShort { get; private set; }
    // الاسم الأخير الكامل للشركة.
    public string CompanyLastNameFull { get; private set; }
    // الاسم الأول الكامل للشركة.
    public string CompanyFirstNameFull { get; private set; }
    // الاسم المختصر الأخير للشركة.
    public string CompanyShortLastName { get; private set; }
    // الاسم المختصر الكامل للشركة.
    public string CompanyShortNameFull { get; private set; }
    // وصف الشركة.
    public string CompanyDescription { get; private set; }
    // صورة الشركة (مسار أو اسم الملف).
    public string CompanyImage { get; private set; }
    // رقم مجموعة الشركة.
    public decimal? CompanyGroup { get; private set; }
    // موقع الشركة الإلكتروني.
    public string CompanyWebsite { get; private set; }
    // البريد الإلكتروني للشركة.
    public string CompanyEmail { get; private set; }
    // إحداثيات GPS للشركة.
    public string Gps { get; private set; }
    // رقم الدولة التابع لها الشركة.
    public decimal? CountryNumber { get; private set; }
    // علم الاتصال الإلكتروني للشركة.
    public decimal? WebConnection { get; private set; }
    // رابط Finscan للشركة.
    public string FinscanUrl { get; private set; }
    // اسم المنظمة في Finscan.
    public string FinscanOrganizationName { get; private set; }
    // اسم المستخدم في Finscan.
    public string FinscanUserName { get; private set; }
    // كلمة مرور المستخدم في Finscan.
    public string FinscanUserPassword { get; private set; }

    #region Methods
    // أضف هنا منطق الدومين الخاص بالشركة
    #endregion
}
}
