#!/bin/bash

# قائمة المجلدات مع أسماء العرض المناسبة
declare -A folders=(
  ["CoreSystem"]="النظام الأساسي"
  ["UsersPermissions"]="المستخدمين والصلاحيات"
  ["GeneralLedger"]="الأستاذ العام"
  ["FixedAssets"]="الأصول الثابتة"
  ["FinanceAccounting"]="المالية والمحاسبة"
  ["SalesCustomers"]="المبيعات والعملاء"
  ["PurchasingVendors"]="المشتريات والموردين"
  ["InventoryWarehousing"]="المخزون والمستودعات"
  ["ProductionManufacturing"]="الإنتاج والتصنيع"
  ["ServicesMaintenance"]="الخدمات والصيانة"
  ["HumanResources"]="الموارد البشرية"
  ["Attendance"]="الحضور والانصراف"
  ["InsuranceClaims"]="التأمين والمطالبات"
  ["GuaranteesWarranties"]="الضمانات والكفالات"
  ["StationsFuel"]="المحطات والوقود"
  ["TransportationShipping"]="النقل والشحن"
  ["DoctorsPatients"]="الأطباء والمرضى"
  ["ArticlesContent"]="المقالات والمحتوى"
  ["ArchivingDocuments"]="الأرشفة والمستندات"
  ["TrackingMonitoring"]="التتبع والمراقبة"
  ["ProjectsRegions"]="المشاريع والمناطق"
  ["MessagesNotifications"]="الرسائل والإشعارات"
  ["FormsSurveys"]="النماذج واستطلاعات الرأي"
  ["SettingsParameters"]="الإعدادات والمعلمات"
  ["ReplicationDuplication"]="النسخ والتكرار"
  ["JudicialLegal"]="القضاء والقانون"
  ["TaxFees"]="الضرائب والرسوم"
  ["WebServicesInterfaces"]="خدمات الويب والواجهات"
  ["TemporaryTables"]="الجداول المؤقتة"
)

# التأكد من أننا في المجلد الصحيح
cd New_ERP

# إنشاء ملفات README.md لكل مجلد
for folder in "${!folders[@]}"; do
  # استخراج الاسم العربي
  arabic_name="${folders[$folder]}"
  
  # إنشاء محتوى ملف README.md
  cat > "$folder/README.md" << EOF
# $folder - ${arabic_name}

هذا المجلد يحتوي على موديلات قسم ${arabic_name}.

## الوصف

يتضمن هذا القسم الموديلات المسؤولة عن إدارة وظائف ${arabic_name} في نظام ERP.

## الموديلات المضمنة

سيتم إضافة قائمة الموديلات المضمنة هنا.
EOF

  echo "تم إنشاء ملف README.md في مجلد $folder"
done

echo "تم الانتهاء من إنشاء ملفات README.md لجميع المجلدات" 