Create Table Class (
	Id int identity primary key,
	Name nvarchar(20) not null
)

Create Table Student (
	Number int primary key,
	Name nvarchar(200) not null,
	ClassId int references Class(Id)
)

