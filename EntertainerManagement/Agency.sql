CREATE TABLE [Agency] (
    [Agency_ID] int IDENTITY(1,1) NOT NULL ,
    [Agency_name] varchar(100)  NOT NULL ,
    CONSTRAINT [PK_Agency] PRIMARY KEY CLUSTERED (
        [Agency_ID] ASC
    ),
	CONSTRAINT [Agency_name] CHECK(LEN([Agency_name]) > 0)
)