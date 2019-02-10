CREATE TABLE [dbo].[AgentContactInformation]
(
	FK_AgentID int not null,
	ContactInfo_phoneNo varchar(15) null,
	ContactInfo_phoneNoExt varchar(11) null,
	ContactInfo_email varchar(254) null,
	ContactInfo_type nvarchar(7) not null default('Private'),
	CONSTRAINT [FK_AgentID] FOREIGN KEY (FK_AgentID)
		REFERENCES Agent (Agent_ID) ON DELETE CASCADE,
	CONSTRAINT [PK_AgentID] PRIMARY KEY (FK_AgentID),
	CONSTRAINT [cInfo_type] CHECK((ContactInfo_type IN('Private', 'Public')))
)
