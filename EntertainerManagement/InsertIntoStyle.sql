/*
MERGE INTO Course AS Target 
USING (VALUES 
        (1, 'Economics', 3), 
        (2, 'Literature', 3), 
        (3, 'Chemistry', 4)
) 
AS Source (CourseID, Title, Credits) 
ON Target.CourseID = Source.CourseID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Title, Credits) 
VALUES (Title, Credits);
*/

MERGE INTO Style AS Target
USING (VALUES
	(1, 'Rock'),
	(2, 'Pop'),
	(3, 'Jazz'),
	(4, 'Blues'),
	(5, 'Metal'),
	(6, 'Rap')
)
AS Source (Style_ID, Style_name) 
ON Target.Style_ID = Source.Style_ID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Style_name) 
VALUES (Style_name);