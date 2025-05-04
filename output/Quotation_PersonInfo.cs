using System;

namespace ERP_Pro.Domain.ERP.Purchasing & Vendors.ValueObjects
{
    public record PersonInfo
    {
    public bool RequestNameEnglish { get; }
    public string RequestName { get; }
    public bool RequestNameEnglishShort { get; }
    public string RequestNameShort { get; }
    public string EquipmentFirstName { get; }
    public string EquipmentLastName { get; }

        private PersonInfo()
        {
            // Required by EF Core
        }

        private PersonInfo(bool requestnameenglish, string requestname, bool requestnameenglishshort, string requestnameshort, string equipmentfirstname, string equipmentlastname)
        {
        RequestNameEnglish = requestnameenglish;
        RequestName = requestname;
        RequestNameEnglishShort = requestnameenglishshort;
        RequestNameShort = requestnameshort;
        EquipmentFirstName = equipmentfirstname;
        EquipmentLastName = equipmentlastname;
        }

        public static PersonInfo Create(bool requestnameenglish, string requestname, bool requestnameenglishshort, string requestnameshort, string equipmentfirstname, string equipmentlastname)
        {
            // Add validation logic here
            return new PersonInfo(requestnameenglish, requestname, requestnameenglishshort, requestnameshort, equipmentfirstname, equipmentlastname);
        }
    }
}