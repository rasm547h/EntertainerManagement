CREATE TABLE [dbo].[Agent]
(
	[Agent_ID] INT NOT NULL, 
    [Agent_fName] NVARCHAR(50) NOT NULL, 
    [Agent_lName] NVARCHAR(50) NOT NULL,
	[Agent_salary] money not null,
	[Agent_hiringDate] date  NOT NULL ,
    [FK_agencyOfficeID] int  NOT NULL
	);
	GO

	ALTER TABLE dbo.Agent ADD
	
    CONSTRAINT [FK_AgencyOffice] FOREIGN KEY (FK_agencyOfficeID)
	REFERENCES AgencyOffice (FK_addressID) ON DELETE NO ACTION
    GO

	ALTER TABLE dbo.Agent ADD
	CONSTRAINT [PK_Agent] PRIMARY KEY (Agent_ID)
	GO

	ALTER TABLE dbo.Agent ADD
	CONSTRAINT [Agent_salary] CHECK([Agent_salary] > 0)
	GO
	
	ALTER TABLE dbo.Agent ADD
	CONSTRAINT [Agent_fName] CHECK(LEN([Agent_fName]) > 0)
	GO

	ALTER TABLE dbo.Agent ADD
	CONSTRAINT [Agent_lName] CHECK(LEN([Agent_lName]) > 0)
    GO

