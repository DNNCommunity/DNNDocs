---
uid: ts-error-sql-timeout
locale: en
title: "Error: SQL Timeout"
dnnversion: 09.02.00
related-topics: ts-how-to-increase-max-upload-file-size,ts-error-login-ip-filtering-is-currently-disabled,ts-error-another-user-has-taken-action-on-the-page,ts-error-unknown-server-tag-DNNComboBox,ts-error-could-not-load-awssdk,ts-error-argumentnullexception-after-move-upgrade,ts-install-missing-resources,ts-mixed-content-ssl,ts-broken-profile-image,ts-page-remains-in-draft,ts-unable-to-remove-page-redirect-urls,ts-site-theme-not-loading,ts-incomplete-content-localization,ts-missing-persona-bar
---

# Error: SQL Timeout

## Symptom

Error:

Log Viewer is currently unavailable. DotNetNuke.Services.Exceptions.ModuleLoadException: Timeout expired. The timeout period elapsed prior to completion of the operation or the server is not responding. ---> System.Data.SqlClient.SqlException: Timeout expired. The timeout period elapsed prior to completion of the operation or the server is not responding. ---> System.ComponentModel.Win32Exception: The wait operation timed out --- End of inner exception stack trace --- at System.Data.SqlClient.SqlInternalConnection.OnError( SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)

## Possible Cause

Some SQL tables have grown too large, specifically **EventLog, SiteLog**, and **ScheduleHistory**.

## Solution

1.  Go to **Persona Bar \> Settings \> SQL Console**.
2.  Check the sizes of EventLog, SiteLog, and ScheduleHistory.
    1.  Run the following SQL script:
        
        ```
        
        SELECT t.NAME AS TableName
        	,p.rows AS RowCounts
        	,SUM(a.total_pages) * 8 AS TotalSpaceKB
        	,SUM(a.used_pages) * 8 AS UsedSpaceKB
        	,(SUM(a.total_pages) - SUM(a.used_pages)) * 8 AS UnusedSpaceKB
        FROM sys.tables t
        INNER JOIN sys.indexes i ON t.OBJECT_ID = i.object_id
        INNER JOIN sys.partitions p ON i.object_id = p.OBJECT_ID
        	AND i.index_id = p.index_id
        INNER JOIN sys.allocation_units a ON p.partition_id = a.container_id
        LEFT JOIN sys.schemas s ON t.schema_id = s.schema_id
        WHERE t.NAME NOT LIKE 'dt%'
        	AND t.is_ms_shipped = 0
        	AND i.OBJECT_ID > 255
        	AND t.name in ('ScheduleHistory', 'EventLog', 'SiteLog')
        GROUP BY t.NAME
        	,s.NAME
        	,p.Rows
        ORDER BY TotalSpaceKB DESC
                                            
        ```
        
    2.  In the result, note the **RowCounts** values for EventLog, SiteLog, and ScheduleHistory.
3.  Clear EventLog.
    1.  Run the following SQL script:
        
        ```
        
        DELETE TOP (1000)
        FROM EventLog;
                                            
        ```
        
        > [!NOTE]
        > To clear **EventLog**, replace `1000` with the **RowCounts** value. To reduce the size of **EventLog** (instead of clearing it), replace `1000` with the number of rows you want to delete.
        
4.  Delete the SiteLog and ScheduleHistory tables.
    1.  Run the following SQL script:
        
        ```
        
        TRUNCATE TABLE SiteLog;
        TRUNCATE TABLE ScheduleHistory;
                                            
        ```
        
5.  [Restart the application](xref:restart-application) to allow the changes to take effect.
6.  To test, try to [access the Admin Logs](xref:view-site-logs).
