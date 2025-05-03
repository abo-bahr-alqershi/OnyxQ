using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a customer handheld device.
/// يمثل المعرف الفريد لجهاز العميل المحمول
/// </summary>
public sealed class CustomerHandheldDeviceId : ValueObject
{
    /// <summary>
    /// Gets the customer code.
    /// رمز العميل
    /// </summary>
    public string CustomerCode { get; }

    /// <summary>
    /// Gets the device serial number.
    /// الرقم التسلسلي للجهاز
    /// </summary>
    public string DeviceSerialNumber { get; }

    private CustomerHandheldDeviceId(string customerCode, string deviceSerialNumber)
    {
        CustomerCode = customerCode;
        DeviceSerialNumber = deviceSerialNumber;
    }

    public static CustomerHandheldDeviceId Create(string customerCode, string deviceSerialNumber)
    {
        return new CustomerHandheldDeviceId(customerCode, deviceSerialNumber);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return CustomerCode;
        yield return DeviceSerialNumber;
    }
} 