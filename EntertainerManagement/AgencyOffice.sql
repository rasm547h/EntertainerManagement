CREATE TABLE [AgencyOffice] (
    [FK_agencyID] int NOT NULL ,
    [FK_addressID] INT NOT NULL ,
	[FK_ContactInfoID] INT NOT NULL)
	GO

	ALTER TABLE dbo.AgencyOffice ADD
    CONSTRAINT [FK_agencyID] FOREIGN KEY (FK_agencyID)
	REFERENCES Agency (Agency_ID) ON DELETE NO ACTION
	GO

	ALTER TABLE dbo.AgencyOffice ADD
	CONSTRAINT [FK_addressID] FOREIGN KEY (FK_addressID)
	REFERENCES Address (Address_ID) ON DELETE CASCADE
	GO

	ALTER TABLE dbo.AgencyOffice ADD
	CONSTRAINT [PK_AgencyOffice] PRIMARY KEY CLUSTERED
    (FK_addressID )
	GO

    ALTER TABLE dbo.AgencyOffice ADD
	CONSTRAINT [FK_ContactInfoID] FOREIGN KEY (FK_ContactInfoID)
	REFERENCES OfficeContactInformation (ContactInfo_ID) ON DELETE NO ACTION
	GO