CREATE TABLE [dbo].[AgentContactInformation]
(
	FK_AgentID int not null,
	ContactInfo_phoneNo varchar(15) null,
	ContactInfo_phoneNoExt VARCHAR(11) NULL,
	ContactInfo_email VARCHAR(254) NULL,
	ContactInfo_type NVARCHAR(7) NOT NULL DEFAULT('Private')
	)
	GO

	ALTER TABLE dbo.AgentContactInformation ADD
	CONSTRAINT [FK_AgentID] FOREIGN KEY (FK_AgentID)
		REFERENCES Agent (Agent_ID) ON DELETE CASCADE
		GO

    ALTER TABLE dbo.AgentContactInformation ADD
	CONSTRAINT [PK_AgentID] PRIMARY KEY (FK_AgentID)
	GO

	ALTER TABLE dbo.AgentContactInformation ADD
	CONSTRAINT [cInfo_type] CHECK((ContactInfo_type IN('Private', 'Public')))
    GO
