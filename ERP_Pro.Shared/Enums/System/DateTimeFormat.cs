namespace ERP_Pro.Shared.Enums.System;

public enum DateTimeFormat
{
    ShortDate = 1,      // dd/MM/yyyy
    LongDate = 2,       // dddd, dd MMMM yyyy
    ShortDateTime = 3,  // dd/MM/yyyy HH:mm
    LongDateTime = 4,   // dddd, dd MMMM yyyy HH:mm:ss
    Time = 5,           // HH:mm:ss
    ShortTime = 6,      // HH:mm
    ISO = 7,            // yyyy-MM-ddTHH:mm:ss
    UTC = 8             // yyyy-MM-ddTHH:mm:ssZ
} 