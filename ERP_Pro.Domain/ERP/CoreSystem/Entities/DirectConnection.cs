using System;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a direct connection entity in the system.
/// يمثل كيان الاتصال المباشر في النظام
/// </summary>
public sealed class DirectConnection : AggregateRoot<DirectConnectionId>
{
    /// <summary>
    /// Gets the connection name.
    /// اسم الاتصال
    /// </summary>
    public string ConnectionName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the server name.
    /// اسم الخادم
    /// </summary>
    public string ServerName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the database name.
    /// اسم قاعدة البيانات
    /// </summary>
    public string DatabaseName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the user name.
    /// اسم المستخدم
    /// </summary>
    public string UserName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the password.
    /// كلمة المرور
    /// </summary>
    public string Password { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the connection type.
    /// نوع الاتصال
    /// </summary>
    public int ConnectionType { get; private set; }

    /// <summary>
    /// Gets the connection status.
    /// حالة الاتصال
    /// </summary>
    public bool ConnectionStatus { get; private set; }

    /// <summary>
    /// Gets the added user ID.
    /// معرف المستخدم الذي أضاف السجل
    /// </summary>
    public int AddedUserId { get; private set; }

    /// <summary>
    /// Gets the addition date.
    /// تاريخ الإضافة
    /// </summary>
    public DateTime AddedDate { get; private set; }

    /// <summary>
    /// Gets the terminal name where the record was added.
    /// اسم الطرفية التي تمت إضافة السجل منها
    /// </summary>
    public string AddedTerminalName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the updated user ID.
    /// معرف المستخدم الذي قام بالتحديث
    /// </summary>
    public int? UpdatedUserId { get; private set; }

    /// <summary>
    /// Gets the update date.
    /// تاريخ التحديث
    /// </summary>
    public DateTime? UpdatedDate { get; private set; }

    /// <summary>
    /// Gets the terminal name where the record was last updated.
    /// اسم الطرفية التي تم تحديث السجل منها
    /// </summary>
    public string UpdatedTerminalName { get; private set; } = string.Empty;

    private DirectConnection() { }

    private DirectConnection(
        DirectConnectionId id,
        string connectionName,
        string serverName,
        string databaseName,
        string userName,
        string password,
        int connectionType,
        bool connectionStatus,
        int addedUserId,
        DateTime addedDate,
        string addedTerminalName,
        string updatedTerminalName)
        : base(id)
    {
        ConnectionName = connectionName;
        ServerName = serverName;
        DatabaseName = databaseName;
        UserName = userName;
        Password = password;
        ConnectionType = connectionType;
        ConnectionStatus = connectionStatus;
        AddedUserId = addedUserId;
        AddedDate = addedDate;
        AddedTerminalName = addedTerminalName;
        UpdatedTerminalName = updatedTerminalName;
    }

    public static DirectConnection Create(
        string connectionName,
        string serverName,
        string databaseName,
        string userName,
        string password,
        int connectionType,
        bool connectionStatus,
        int addedUserId,
        string addedTerminalName)
    {
        var directConnection = new DirectConnection(
            DirectConnectionId.CreateUnique(),
            connectionName,
            serverName,
            databaseName,
            userName,
            password,
            connectionType,
            connectionStatus,
            addedUserId,
            DateTime.UtcNow,
            addedTerminalName,
            addedTerminalName);

        directConnection.RaiseDomainEvent(new DirectConnectionCreatedEvent(directConnection));

        return directConnection;
    }

    public void Update(
        string connectionName,
        string serverName,
        string databaseName,
        string userName,
        string password,
        int connectionType,
        bool connectionStatus,
        int updatedUserId,
        string updatedTerminalName)
    {
        ConnectionName = connectionName;
        ServerName = serverName;
        DatabaseName = databaseName;
        UserName = userName;
        Password = password;
        ConnectionType = connectionType;
        ConnectionStatus = connectionStatus;
        UpdatedUserId = updatedUserId;
        UpdatedDate = DateTime.UtcNow;
        UpdatedTerminalName = updatedTerminalName;

        RaiseDomainEvent(new DirectConnectionUpdatedEvent(this));
    }
} 