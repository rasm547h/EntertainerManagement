MERGE INTO EntertainerMember as Target
USING (VALUES
	(1, 'Benjamin', 'Jensen'),
	(2, 'Martin', 'Olsen'),
	(3, 'Daniel', 'Rasmussen'),
	(4, 'Rasmus', 'Klausen'),
	(5, 'Brett', 'Cupit'),
	(6, 'Kirsten', 'Hermsen'),
	(7, 'Gia', 'Heaps'),
	(8, 'Joanna', 'Yamamoto'),
	(9, 'Ingrid', 'Kranor'),
	(10, 'Arianna', 'Feeley'),
	(11, 'Micki', 'Vowels'),
	(12, 'Lee', 'Maacalosy'),
	(13, 'Carissa', 'Addler'),
	(14, 'Erik', 'Sandquist')
)
AS Source (eMember_ID, fName, lName)
ON Target.eMember_ID = Source.eMember_ID
WHEN NOT MATCHED BY TARGET THEN
INSERT (fName, lName)
VALUES(fName, lName);
