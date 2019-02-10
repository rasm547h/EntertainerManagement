
MERGE INTO EntertainerGroup AS Target 
USING (VALUES 
        (1, 'Serial Wetness', 1, 1), 
        (2, 'Book Of The Same', 1, 2), 
        (3, 'Yeast Egg', 2, 3),
		(4, 'Bio Assembly And The Teeth', 2, 3), 
		(5, 'Soaked Perimeter', 3, 4), 
		(6, 'Modern Ginseng', 3, 5), 
		(7, 'Dough Of Suction', 4, 6), 
		(8, 'Policeman Of Pretentious', 5, 1)
) 
AS Source (EntertainerGroup_ID, Entertainer_name, FK_agentID, FK_styleID) 
ON Target.EntertainerGroup_ID = Source.EntertainerGroup_ID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Entertainer_name, FK_agentID, FK_styleID) 
VALUES (Entertainer_name, FK_agentID, FK_styleID);

-- Conflict when no agents exist.