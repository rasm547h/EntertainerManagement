CREATE VIEW [dbo].[OfficeSalary]
AS
SELECT AgencyOffice.FK_addressID, SUM(Agent.Agent_salary) as TotalSalary
FROM AgencyOffice
INNER JOIN Agent
ON Agent.FK_agencyOfficeID = AgencyOffice.FK_addressID
WHERE AgencyOffice.FK_addressID = 1
GROUP BY AgencyOffice.FK_addressID;
GO


CREATE VIEW [dbo].[OfficeAgents]
AS
SELECT Agent.Agent_fName, Agent.Agent_lName, Agent_salary
FROM AgencyOffice
INNER JOIN Agent
ON Agent.FK_agencyOfficeID = AgencyOffice.FK_addressID
WHERE AgencyOffice.FK_addressID = 1;
GO