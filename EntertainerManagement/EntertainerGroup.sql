CREATE TABLE [dbo].[EntertainerGroup]
(
	[EntertainerGroup_ID] int IDENTITY(1,1) NOT NULL ,
    [Entertainer_name] varchar(100)  NOT NULL ,
    [FK_agentID] int  NULL ,
    [FK_styleID] int  NULL ,
    [EntertainmentGroup_active] bit  NOT NULL DEFAULT(0),
    CONSTRAINT [PK_EntertainerGroup] PRIMARY KEY CLUSTERED (
        [EntertainerGroup_ID] ASC
    ),
	CONSTRAINT [eGroup_FK_agentID] FOREIGN KEY (FK_agentID)
		REFERENCES AgentEntertainerContract (FK_agentID),
	CONSTRAINT [FK_style] FOREIGN KEY (FK_styleID)
		REFERENCES Style (Style_ID)
);

