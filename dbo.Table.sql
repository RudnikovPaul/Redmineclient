CREATE TABLE [dbo].[Table]
(
	[numberId] INT NOT NULL PRIMARY KEY, 
    [project] VARCHAR(MAX) NULL, 
    [subject] NVARCHAR(MAX) NULL, 
    [done] INT NULL DEFAULT 0, 
    [priority] VARCHAR(50) NULL, 
    [assignedTo] VARCHAR(50) NULL, 
    [status] VARCHAR(60) NULL, 
    [tracker] VARCHAR(MAX) NULL, 
    [startdateCh] BIT NULL, 
    [duedateCh] BIT NULL, 
    [estimhours] DECIMAL(2) NULL, 
    [startdate] DATETIME NULL , 
    [duedate] DATETIME NULL, 
    [description] VARCHAR(MAX) NULL, 
    [notes] VARCHAR(MAX) NULL, 
    [overalltime] INT NULL, 
    [commit] BIT NOT NULL
)
