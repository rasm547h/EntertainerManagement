CREATE PROCEDURE [dbo].[CreateBooking]
	@sTime datetime,
	@eTime datetime,
	@agentID int,
	@entID int,
	@eventID int
AS
INSERT INTO dbo.Booking
(Booking_StartTime, Booking_EndTime, FK_Agent_ID, FK_Entertainer_ID, FK_EventBookings_ID)
VALUES (@sTime, @eTime, @agentID, @entID, @eventID);
GO

CREATE PROCEDURE [dbo].[CreateBookingWithEvent]
	@sTime datetime,
	@eTime datetime,
	@agentID int,
	@entID int,

	@eventName nvarchar(25),
	@desc nvarchar(100) = '',
	@location varchar(50),
	@custID int
AS

INSERT INTO dbo.[Event]
(Event_Name, Event_Description, Event_Location, FK_Customer_ID)
VALUES (@eventName, @desc, @location, @custID)

INSERT INTO dbo.EventBookings
(FK_Event_ID)
VALUES ((SELECT TOP(1) Event_ID FROM dbo.[Event] ORDER BY Event_ID DESC))

INSERT INTO dbo.Booking
(Booking_StartTime, Booking_EndTime, FK_Agent_ID, FK_Entertainer_ID, FK_EventBookings_ID, FK_Agent_ID)
VALUES (@sTime, @eTime, @agentID, @entID, (Select TOP(1) EventBookings_ID 
											FROM dbo.[EventBookings] 
											ORDER BY EventBookings_ID DESC));
GO
/*
dbo.CreateBookingWithEvent '01-01-2006 10:00:00 AM', 
								'01-01-2006 12:00:00 AM', 
								1, 
								1, 
								'Event Name Test', 
								'empty desc', 
								'street 1 city-9999', 
								1;

*/