CREATE TABLE [dbo].[EntertainerGroup]
(
	[EntertainerGroup_ID] int IDENTITY(1,1) NOT NULL,
    [Entertainer_name] varchar(100)  NOT NULL ,
    FK_ContractID int  NULL ,
    [FK_styleID] int  NULL ,
    [EntertainmentGroup_active] bit  NOT NULL DEFAULT(0),
    
);
GO

ALTER TABLE EntertainerGroup ADD
	CONSTRAINT [PK_EntertainerGroup] PRIMARY KEY CLUSTERED ( [EntertainerGroup_ID] ASC );
GO

ALTER TABLE EntertainerGroup ADD
	CONSTRAINT [eGroup_FK_agentID] FOREIGN KEY (FK_ContractID) REFERENCES AgentEntertainerContract (Contract_ID)
GO

ALTER TABLE EntertainerGroup ADD
	CONSTRAINT [FK_style] FOREIGN KEY (FK_styleID) REFERENCES Style (Style_ID)
GO
