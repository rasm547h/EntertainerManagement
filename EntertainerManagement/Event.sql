CREATE TABLE [dbo].[Event]
(
	Event_ID INT IDENTITY NOT NULL,
	Event_Name varchar(25),
	Event_Description varchar(280),
	Event_Location varchar(50) NOT NULL,
	FK_Customer_ID INT NOT NULL
	
	PRIMARY KEY (Event_ID),
	FOREIGN KEY (FK_Customer_ID) REFERENCES Customer(Customer_ID)
)