CREATE VIEW [dbo].[agentEntertainer]
	AS SELECT Agent.Agent_fName, Agent.Agent_lName, Entertainer.Entertainer_name
	FROM Agent
	INNER JOIN (SELECT AgentEntertainerContract.FK_agentID, EntertainerGroup.Entertainer_name
				FROM AgentEntertainerContract
				INNER JOIN EntertainerGroup 
				ON AgentEntertainerContract.Contract_ID = EntertainerGroup.FK_ContractID) as Entertainer
	ON Agent.Agent_ID = Entertainer.FK_agentID;
	GO