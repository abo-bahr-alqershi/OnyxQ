using System;

namespace ERP_Pro.Domain.ERP.Sales & Customers.ValueObjects
{
    public record ContactInfo
    {
    public string MobileAttendanceSync { get; }
    public string AttendanceMobileSerial { get; }
    public string AttendanceMobileType { get; }
    public string CardSecondEmail { get; }
    public string CardSecondTelephone { get; }

        private ContactInfo()
        {
            // Required by EF Core
        }

        private ContactInfo(string mobileattendancesync, string attendancemobileserial, string attendancemobiletype, string cardsecondemail, string cardsecondtelephone)
        {
        MobileAttendanceSync = mobileattendancesync;
        AttendanceMobileSerial = attendancemobileserial;
        AttendanceMobileType = attendancemobiletype;
        CardSecondEmail = cardsecondemail;
        CardSecondTelephone = cardsecondtelephone;
        }

        public static ContactInfo Create(string mobileattendancesync, string attendancemobileserial, string attendancemobiletype, string cardsecondemail, string cardsecondtelephone)
        {
            // Add validation logic here
            return new ContactInfo(mobileattendancesync, attendancemobileserial, attendancemobiletype, cardsecondemail, cardsecondtelephone);
        }
    }
}