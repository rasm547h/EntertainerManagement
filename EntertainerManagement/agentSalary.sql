CREATE VIEW [dbo].[agentSalary]
	AS SELECT Agent.Agent_fName, Agent.Agent_lName, Agent_salary
	FROM Agent
	INNER JOIN(SELECT AgencyOffice.FK_addressID, AgencyOffice.FK_ContactInfoID
	FROM AgencyOffice) as Agency
	ON Agent.Agent_ID = Agent.FK_agencyOfficeID;
	GO
