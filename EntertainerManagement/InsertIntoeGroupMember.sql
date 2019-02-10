MERGE INTO eGroupMember as Target
USING (VALUES
	(1,1),
	(1,2),
	(1,3),
	(2,4),
	(2,5),
	(3,6),
	(3,7),
	(4,8),
	(5,9),
	(5,10),
	(5,11),
	(6,12),
	(6,12),
	(7,13),
	(7,14),
	(8,15),
	(8,16)	
)
AS Source (FK_eGroupID, FK_eMemberID)
ON Target.FK_eMemberID = Source.FK_eMemberID
WHEN NOT MATCHED BY TARGET THEN
INSERT (FK_eGroupID, FK_eMemberID)
VALUES(FK_eGroupID, FK_eMemberID);

-- error no group or member exist.