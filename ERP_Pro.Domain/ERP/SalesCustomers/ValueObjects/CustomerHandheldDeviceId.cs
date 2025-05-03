using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

/// <summary>
/// Represents the composite ID for a customer handheld device (CustomerCode + DeviceSerialNumber)
/// يمثل المعرف المركب لجهاز يد العميل (رمز العميل + الرقم التسلسلي للجهاز)
/// </summary>
public class CustomerHandheldDeviceId : ValueObject
{
    /// <summary>
    /// The customer code part of the composite ID
    /// جزء رمز العميل من المعرف المركب
    /// </summary>
    public string CustomerCode { get; }

    /// <summary>
    /// The device serial number part of the composite ID
    /// جزء الرقم التسلسلي للجهاز من المعرف المركب
    /// </summary>
    public string DeviceSerialNumber { get; }

    public CustomerHandheldDeviceId(string customerCode, string deviceSerialNumber)
    {
        if (string.IsNullOrWhiteSpace(customerCode))
            throw new ArgumentException("Customer code cannot be empty", nameof(customerCode));

        if (string.IsNullOrWhiteSpace(deviceSerialNumber))
            throw new ArgumentException("Device serial number cannot be empty", nameof(deviceSerialNumber));

        CustomerCode = customerCode;
        DeviceSerialNumber = deviceSerialNumber;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return CustomerCode;
        yield return DeviceSerialNumber;
    }

    public override string ToString() => $"{CustomerCode}_{DeviceSerialNumber}";
} 