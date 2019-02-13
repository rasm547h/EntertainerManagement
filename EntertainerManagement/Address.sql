CREATE TABLE [dbo].[Address]
(
	[Address_ID] int IDENTITY NOT NULL ,
	[Address_address] varchar(100) NOT NULL ,
	[Address_addressBuilding] varchar(2) NULL DEFAULT(NULL),
	[Address_addressNo] smallint NOT NULL,
	[Address_addressNoRange] tinyint NULL DEFAULT(NULL),
    [Address_city] varchar(60)  NOT NULL ,
    [Address_zipcode] varchar(20)  NULL ,
    [Address_country] varchar(55)  NOT NULL);
	GO

	ALTER TABLE dbo.Address ADD
	CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED(
    [Address_ID]) 
	GO 
		
	ALTER TABLE dbo.Address ADD
	CONSTRAINT [Address_address] CHECK(LEN([Address_address]) > 0)
	GO

	ALTER TABLE dbo.Address ADD
	CONSTRAINT [Address_addressNo] CHECK ([Address_addressNo] > 0)
	GO

