import os

# المسار لملف Branch.cs
BRANCH_PATH = "Modules/CoreSystem/Entities/Branch.cs"

def fix_branch_entity():
    # قراءة ملف Branch الحالي
    with open(BRANCH_PATH, 'r', encoding='utf-8') as f:
        content = f.readlines()
    
    # التحقق من وجود قسم العلاقات
    has_relations = False
    for line in content:
        if "#region Navigation Properties" in line:
            has_relations = True
            break
    
    # إذا كان لديه بالفعل قسم علاقات، لا داعي للإصلاح
    if has_relations:
        print("ملف Branch.cs يحتوي بالفعل على قسم العلاقات")
        return
    
    # إنشاء علاقات جديدة
    # العلاقات الموجودة في المخطط:
    # - BranchGroup (S_BRN_GRPS)
    # - Company (S_CMPNY)
    # - Province (IAS_PROVINCES)
    # - Region (REGIONS)
    # - City (CITIES)
    # - Country (CNTRY)
    
    # البحث عن مكان إضافة العلاقات (قبل قسم Methods)
    methods_section_index = -1
    for i, line in enumerate(content):
        if "#region Methods" in line:
            methods_section_index = i
            break
    
    if methods_section_index == -1:
        print("لم نعثر على قسم Methods في ملف Branch.cs")
        return
    
    # إضافة استيرادات جديدة
    imports_added = False
    for i, line in enumerate(content):
        if "using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;" in line:
            imports_added = True
            break
            
    if not imports_added:
        # العثور على موقع آخر استيراد
        last_import_index = -1
        for i, line in enumerate(content):
            if line.strip().startswith("using "):
                last_import_index = i
        
        if last_import_index != -1:
            content.insert(last_import_index + 1, "using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;\n")
            
    # إضافة قسم العلاقات
    navigation_properties = [
        "    #region Navigation Properties",
        "    /// <summary>",
        "    /// Reference relationship: ManyToOne",
        "    /// </summary>",
        "    public BranchGroup BranchGroup { get; private set; }",
        "    /// <summary>",
        "    /// Reference relationship: ManyToOne",
        "    /// </summary>",
        "    public Company Company { get; private set; }",
        "    /// <summary>",
        "    /// Reference relationship: ManyToOne",
        "    /// </summary>",
        "    public Province Province { get; private set; }",
        "    /// <summary>",
        "    /// Reference relationship: ManyToOne",
        "    /// </summary>",
        "    public Region Region { get; private set; }",
        "    /// <summary>",
        "    /// Reference relationship: ManyToOne",
        "    /// </summary>",
        "    public City City { get; private set; }",
        "    /// <summary>",
        "    /// Reference relationship: ManyToOne",
        "    /// </summary>",
        "    public Country Country { get; private set; }",
        "    #endregion",
        ""  # سطر فارغ
    ]
    
    # إضافة العلاقات قبل قسم Methods
    for i, line in enumerate(navigation_properties):
        content.insert(methods_section_index + i, line + "\n")
    
    # كتابة المحتوى المحدث
    with open(BRANCH_PATH, 'w', encoding='utf-8') as f:
        f.writelines(content)
    
    print("تم إصلاح ملف Branch.cs بنجاح وإضافة 6 علاقات له")

if __name__ == "__main__":
    fix_branch_entity() 