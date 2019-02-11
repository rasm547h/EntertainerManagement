CREATE TABLE [dbo].[eGroupMember]
(
	[FK_eGroupID] INT NOT NULL,
	[FK_eMemberID] INT NOT NULL,
	
);
GO

ALTER TABLE eGroupMember ADD
CONSTRAINT [FK_eGroupID] FOREIGN KEY (FK_eGroupID) REFERENCES EntertainerGroup (EntertainerGroup_ID)
GO

ALTER TABLE eGroupMember ADD
	CONSTRAINT [FK_eMemberID] FOREIGN KEY (FK_eMemberID) REFERENCES EntertainerMember (eMember_ID)
GO
