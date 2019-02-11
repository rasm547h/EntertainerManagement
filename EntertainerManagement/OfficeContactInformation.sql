CREATE TABLE [dbo].[OfficeContactInformation]
(
	ContactInfo_ID int identity not null,
	ContactInfo_phoneNo varchar(15) null,
	ContactInfo_phoneNoExt varchar(11) null,
	ContactInfo_email varchar(254) null,
	ContactInfo_type char(1) not null,
	
);
GO

ALTER TABLE OfficeContactInformation ADD
	CONSTRAINT [PK_ContactInfo_ID] PRIMARY KEY (ContactInfo_ID)
GO
