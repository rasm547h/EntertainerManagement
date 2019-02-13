CREATE VIEW [dbo].[AgentEntertainerGroups]
	AS SELECT  Agent_ID, Agent_fName, Agent_lName, Contract_ID, Contract_agentFee, Contract_detail, Contract_date, Contract_expDate, EntertainerGroup_ID, Entertainer_name
	FROM [Agent] 
	INNER JOIN (SELECT Contract_ID, FK_agentID, Contract_agentFee, Contract_detail, Contract_date, Contract_expDate, EntertainerGroup.EntertainerGroup_ID, EntertainerGroup.Entertainer_name
				FROM [AgentEntertainerContract]
				INNER JOIN EntertainerGroup
				ON AgentEntertainerContract.Contract_ID = EntertainerGroup.FK_ContractID
				WHERE EntertainerGroup.EntertainmentGroup_active = 0) AS Contract_EntertainerGroup
	ON Agent.Agent_ID = Contract_EntertainerGroup.FK_agentID
	
