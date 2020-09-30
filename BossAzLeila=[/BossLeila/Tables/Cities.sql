CREATE TABLE [BossLeila].[Cities]
(
	[Id] INT NOT NULL IDENTITY,
	[name] nvarchar(200)not null,

	[CreatedDate]datetime not null default SYSDATETIME(),
	[CreatedUserId]int not null ,
	[UpdatedDate]datetime  null ,
	[UpdatedUserId]int not null ,
    [DeletedDate]datetime  null ,
	[DeletedUserId]int  null ,

	constraint Pk_BossLeila_Cities PRIMARY KEY(	[Id])
)
