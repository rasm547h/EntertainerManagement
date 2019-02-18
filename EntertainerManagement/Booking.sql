CREATE TABLE [dbo].[Booking]
(
	Booking_ID INT IDENTITY NOT NULL,
	Booking_StartTime DATETIME NOT NULL,
	Booking_EndTime DATETIME NOT NULL,
	FK_Entertainer_ID INT NOT NULL,
	FK_EventBookings_ID INT NOT NULL


	PRIMARY KEY (Booking_ID),
	FOREIGN KEY (FK_Entertainer_ID) REFERENCES EntertainerGroup([EntertainerGroup_ID]),
	FOREIGN KEY (FK_EventBookings_ID) REFERENCES EventBookings(EventBookings_ID)
)