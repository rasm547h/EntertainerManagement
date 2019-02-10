CREATE TABLE [dbo].[eGroupMember]
(
	[FK_eGroupID] INT NOT NULL,
	[FK_eMemberID] INT NOT NULL,
	CONSTRAINT [FK_eGroupID] FOREIGN KEY (FK_eGroupID)
		REFERENCES EntertainerGroup (EntertainerGroup_ID),
	CONSTRAINT [FK_eMemberID] FOREIGN KEY (FK_eMemberID)
		REFERENCES EntertainerMember (eMember_ID)
)
