
create table Person
(
pID int identity (1,1) not null,
pLast nvarchar (50) not null,
pFirst nvarchar (50) not null,
pGender nvarchar (6) not null,
pDOB smalldatetime not null,
PRIMARY KEY CLUSTERED (pID ASC)
);