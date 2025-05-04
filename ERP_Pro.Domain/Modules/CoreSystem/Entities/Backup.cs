using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل النسخة الاحتياطية للنظام ويحتوي على جميع تفاصيل النسخ الاحتياطي.
public class Backup : Entity<BackupId>
{
    private Backup() { }

    public Backup(BackupId id, decimal? backupNumber)
    {
        Id = id;
        BackupNumber = backupNumber;
    }

    // المعرف الفريد للنسخة الاحتياطية (مفتاح رئيسي).
    public BackupId Id { get; private set; }

    // رقم النسخة الاحتياطية.
    public decimal? BackupNumber { get; private set; }

    // اسم النسخة الاحتياطية.
    public string BackupName { get; private set; }

    // اسم ملف النسخة الاحتياطية.
    public string FileName { get; private set; }

    // تاريخ إنشاء النسخة الاحتياطية.
    public DateTime? BackupDate { get; private set; }

    // كلمة مرور النسخة الاحتياطية (مشفر).
    public string EncPasswd { get; private set; }

    // رقم الشركة المرتبط بالنسخة الاحتياطية.
    public decimal? CompanyNumberShort { get; private set; }

    // رقم الفرع المرتبط بالنسخة الاحتياطية.
    public decimal? BranchNumber { get; private set; }

    // سنة الفرع المرتبط بالنسخة الاحتياطية.
    public decimal? BranchYear { get; private set; }

    // المستخدم المرتبط بالنسخة الاحتياطية.
    public decimal? BranchUser { get; private set; }

    #region Methods
    // أضف هنا منطق الدومين الخاص بالنسخة الاحتياطية
    #endregion
}
}
