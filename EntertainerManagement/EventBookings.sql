CREATE TABLE [dbo].[EventBookings]
(
	EventBookings_ID INT IDENTITY NOT NULL,
	[FK_Event_ID] INT NOT NULL


	PRIMARY KEY (BookingsList_ID),
	FOREIGN KEY (FK_Event_ID) REFERENCES dbo.[Event](Event_ID)
)