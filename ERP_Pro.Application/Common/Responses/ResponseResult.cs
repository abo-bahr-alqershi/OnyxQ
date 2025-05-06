using System.Collections.Generic;

namespace ERP_Pro.Application.Common.Responses;

/// <summary>
/// نموذج موحد للاستجابة
/// </summary>
/// <typeparam name="T">نوع البيانات المضمنة في الاستجابة</typeparam>
public class ResponseResult<T>
{
    /// <summary>
    /// حالة نجاح العملية
    /// </summary>
    public bool Succeeded { get; private set; }
    
    /// <summary>
    /// البيانات المضمنة في الاستجابة
    /// </summary>
    public T Data { get; private set; }
    
    /// <summary>
    /// رمز الرسالة
    /// </summary>
    public string MessageCode { get; private set; }
    
    /// <summary>
    /// رسالة نتيجة العملية
    /// </summary>
    public string Message { get; private set; }
    
    /// <summary>
    /// قائمة الأخطاء في حالة وجودها
    /// </summary>
    public IDictionary<string, string[]> Errors { get; private set; }

    private ResponseResult(bool succeeded, T data = default, string messageCode = null, string message = null, IDictionary<string, string[]> errors = null)
    {
        Succeeded = succeeded;
        Data = data;
        MessageCode = messageCode;
        Message = message;
        Errors = errors;
    }

    /// <summary>
    /// إنشاء استجابة ناجحة مع بيانات
    /// </summary>
    public static ResponseResult<T> Success(T data, string message = null, string messageCode = "Success")
    {
        return new ResponseResult<T>(true, data, messageCode, message);
    }

    /// <summary>
    /// إنشاء استجابة فاشلة مع رسالة خطأ
    /// </summary>
    public static ResponseResult<T> Failure(string messageCode, string message, IDictionary<string, string[]> errors = null)
    {
        return new ResponseResult<T>(false, default, messageCode, message, errors);
    }

    /// <summary>
    /// إنشاء استجابة فاشلة مع قائمة أخطاء
    /// </summary>
    public static ResponseResult<T> Failure(IDictionary<string, string[]> errors)
    {
        return new ResponseResult<T>(false, default, "ValidationError", "حدث خطأ في التحقق من صحة البيانات", errors);
    }
}

/// <summary>
/// نموذج موحد للاستجابة بدون بيانات
/// </summary>
public class ResponseResult
{
    /// <summary>
    /// حالة نجاح العملية
    /// </summary>
    public bool Succeeded { get; private set; }
    
    /// <summary>
    /// رمز الرسالة
    /// </summary>
    public string MessageCode { get; private set; }
    
    /// <summary>
    /// رسالة نتيجة العملية
    /// </summary>
    public string Message { get; private set; }
    
    /// <summary>
    /// قائمة الأخطاء في حالة وجودها
    /// </summary>
    public IDictionary<string, string[]> Errors { get; private set; }

    private ResponseResult(bool succeeded, string messageCode = null, string message = null, IDictionary<string, string[]> errors = null)
    {
        Succeeded = succeeded;
        MessageCode = messageCode;
        Message = message;
        Errors = errors;
    }

    /// <summary>
    /// إنشاء استجابة ناجحة
    /// </summary>
    public static ResponseResult Success(string message = null, string messageCode = "Success")
    {
        return new ResponseResult(true, messageCode, message);
    }

    /// <summary>
    /// إنشاء استجابة فاشلة مع رسالة خطأ
    /// </summary>
    public static ResponseResult Failure(string messageCode, string message, IDictionary<string, string[]> errors = null)
    {
        return new ResponseResult(false, messageCode, message, errors);
    }

    /// <summary>
    /// إنشاء استجابة فاشلة مع قائمة أخطاء
    /// </summary>
    public static ResponseResult Failure(IDictionary<string, string[]> errors)
    {
        return new ResponseResult(false, "ValidationError", "حدث خطأ في التحقق من صحة البيانات", errors);
    }
} 