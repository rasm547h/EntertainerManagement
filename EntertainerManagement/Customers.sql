CREATE TABLE [dbo].[Customer]
(
	Customer_ID INT IDENTITY NOT NULL, 
    Customer_fName NVARCHAR(50) NOT NULL, 
    Customer_lName NVARCHAR(50) NOT NULL,
	Customer_Mobile INT NOT NULL,
	Customer_Mail VARCHAR(50) NOT NULL

	PRIMARY KEY (Customer_ID),
	CONSTRAINT Customer_fName CHECK(LEN(Customer_fName) > 0),
	CONSTRAINT Customer_lName CHECK(LEN(Customer_lName) > 0)

);