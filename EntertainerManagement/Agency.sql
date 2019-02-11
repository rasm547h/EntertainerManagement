CREATE TABLE [Agency] (
    [Agency_ID] INT IDENTITY(1,1) NOT NULL ,
    [Agency_name] VARCHAR(100)  NOT NULL )
	GO

	ALTER TABLE dbo.Agency ADD
    CONSTRAINT [PK_Agency] PRIMARY KEY CLUSTERED (
        [Agency_ID] )
    GO

	ALTER TABLE dbo.Agency ADD
	CONSTRAINT [Agency_name] CHECK(LEN([Agency_name]) > 0)
	GO
