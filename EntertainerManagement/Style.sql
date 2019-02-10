CREATE TABLE [Style] (
    [Style_ID] int IDENTITY(1,1) NOT NULL ,
    [Style_name] varchar(20)  NOT NULL ,
    CONSTRAINT [PK_Style] PRIMARY KEY CLUSTERED (
        [Style_ID] ASC
    )
)