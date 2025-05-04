using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل الكفيل ويحتوي على جميع بيانات الكفيل الأساسية والتفصيلية.
    public class Sponsor : Entity<SponsorId>
    {
        private Sponsor() { }

        // المعرف الفريد للكفيل (مفتاح رئيسي).
        public SponsorId Id { get; private set; }

        // رقم الكفيل.
        public decimal? SponsorNumber { get; private set; }

        // الاسم الأخير للكفيل.
        public string SponsorLastName { get; private set; }

        // الاسم الأول للكفيل.
        public string SponsorFirstName { get; private set; }

        // رقم بطاقة العمل للكفيل.
        public string CardJobNumber { get; private set; }

        // رقم مكتب العمل للكفيل.
        public string WorkOfficeNumber { get; private set; }

        // العنوان المختصر للكفيل.
        public string AddressShort { get; private set; }

        // رقم هوية الضامن.
        public string CardIdGuarantor { get; private set; }

        // تاريخ إصدار البطاقة البديل.
        public DateTime? CardIssueDateAlt { get; private set; }

        // مكان إصدار البطاقة.
        public string CardIssuePlace { get; private set; }

        // تاريخ انتهاء البطاقة.
        public DateTime? CardEndDate { get; private set; }

        // رقم السجل التجاري.
        public string CommercialNumber { get; private set; }

        // رقم التأمينات الاجتماعية.
        public string SocialInsuranceNumber { get; private set; }

        // اسم شركة الضامن.
        public string GuarantorCompanyName { get; private set; }

        // تاريخ السجل التجاري.
        public string CommerceDate { get; private set; }

        // حقل إضافي 1.
        public string Field1 { get; private set; }

        // حقل إضافي 2.
        public string Field2 { get; private set; }

        // حقل إضافي 3.
        public string Field3 { get; private set; }

        // حقل إضافي 4.
        public string Field4 { get; private set; }

        // حقل إضافي 5.
        public string Field5 { get; private set; }

        // حقل إضافي 6.
        public string Field6 { get; private set; }

        // حقل إضافي 7.
        public string Field7 { get; private set; }

        // حقل إضافي 8.
        public string Field8 { get; private set; }

        // حقل إضافي 9.
        public string Field9 { get; private set; }

        // حقل إضافي 10.
        public string Field10 { get; private set; }

        // علم التعطيل للكفيل.
        public decimal? InactiveFlag { get; private set; }

        // معرف المستخدم الذي قام بالتعطيل.
        public decimal? InactivatedByUserId { get; private set; }

        // تاريخ التعطيل للكفيل.
        public DateTime? InactiveDate { get; private set; }

        // سبب التعطيل للكفيل.
        public string InactiveReason { get; private set; }
    }
}
