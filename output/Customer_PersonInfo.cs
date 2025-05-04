using System;

namespace ERP_Pro.Domain.ERP.Sales & Customers.ValueObjects
{
    public record PersonInfo
    {
    public string ReceiverName { get; }
    public string ServiceName { get; }
    public string LocationFirstName { get; }
    public string LocationLastName { get; }
    public int AccountDetailFullName { get; }
    public int AccountDetailLastName { get; }
    public string CalcTypeFirstName { get; }
    public string CalcTypeLastName { get; }
    public string AttachmentDescriptionNameArabic { get; }
    public bool AttachmentDescriptionNameEnglish { get; }
    public string BatchDescriptionNameArabic { get; }
    public bool BatchDescriptionNameEnglish { get; }
    public decimal CostCenterNameArabic { get; }
    public decimal CostCenterNameEnglish { get; }
    public decimal CostCenterName { get; }
    public string SubFirstName { get; }
    public string SubLastName { get; }

        private PersonInfo()
        {
            // Required by EF Core
        }

        private PersonInfo(string receivername, string servicename, string locationfirstname, string locationlastname, int accountdetailfullname, int accountdetaillastname, string calctypefirstname, string calctypelastname, string attachmentdescriptionnamearabic, bool attachmentdescriptionnameenglish, string batchdescriptionnamearabic, bool batchdescriptionnameenglish, decimal costcenternamearabic, decimal costcenternameenglish, decimal costcentername, string subfirstname, string sublastname)
        {
        ReceiverName = receivername;
        ServiceName = servicename;
        LocationFirstName = locationfirstname;
        LocationLastName = locationlastname;
        AccountDetailFullName = accountdetailfullname;
        AccountDetailLastName = accountdetaillastname;
        CalcTypeFirstName = calctypefirstname;
        CalcTypeLastName = calctypelastname;
        AttachmentDescriptionNameArabic = attachmentdescriptionnamearabic;
        AttachmentDescriptionNameEnglish = attachmentdescriptionnameenglish;
        BatchDescriptionNameArabic = batchdescriptionnamearabic;
        BatchDescriptionNameEnglish = batchdescriptionnameenglish;
        CostCenterNameArabic = costcenternamearabic;
        CostCenterNameEnglish = costcenternameenglish;
        CostCenterName = costcentername;
        SubFirstName = subfirstname;
        SubLastName = sublastname;
        }

        public static PersonInfo Create(string receivername, string servicename, string locationfirstname, string locationlastname, int accountdetailfullname, int accountdetaillastname, string calctypefirstname, string calctypelastname, string attachmentdescriptionnamearabic, bool attachmentdescriptionnameenglish, string batchdescriptionnamearabic, bool batchdescriptionnameenglish, decimal costcenternamearabic, decimal costcenternameenglish, decimal costcentername, string subfirstname, string sublastname)
        {
            // Add validation logic here
            return new PersonInfo(receivername, servicename, locationfirstname, locationlastname, accountdetailfullname, accountdetaillastname, calctypefirstname, calctypelastname, attachmentdescriptionnamearabic, attachmentdescriptionnameenglish, batchdescriptionnamearabic, batchdescriptionnameenglish, costcenternamearabic, costcenternameenglish, costcentername, subfirstname, sublastname);
        }
    }
}