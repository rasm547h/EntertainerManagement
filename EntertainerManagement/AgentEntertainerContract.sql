CREATE TABLE [AgentEntertainerContract] (
    Contract_ID int identity not null primary key,
	[FK_agentID] int  NOT NULL ,
    [Contract_agentFee] decimal(4,2)  NOT NULL DEFAULT 10 ,
    [Contract_detail] text  NULL ,
    [Contract_date] date  NOT NULL ,
    [Contract_expDate] date  NOT NULL)
	GO

	ALTER TABLE dbo.AgentEntertainerContract ADD
	CONSTRAINT [FK_agent] FOREIGN KEY (FK_agentID)
	REFERENCES Agent (Agent_ID) ON DELETE CASCADE
	GO
