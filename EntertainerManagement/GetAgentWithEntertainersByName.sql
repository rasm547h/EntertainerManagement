CREATE PROCEDURE [dbo].[GetAgentWithEntertainersByName]
	@fullNameParam NVARCHAR(50)
AS
BEGIN
	SELECT *
	FROM dbo.agentEntertainer
	WHERE (dbo.agentEntertainer.Agent_fName + ' ' + dbo.agentEntertainer.Agent_lName) = @fullNameParam;
END
GO