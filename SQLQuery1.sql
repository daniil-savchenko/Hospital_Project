Create table Position(
	ID int not null primary key,
	posname varchar(20)
)

create table Worker(
	ID int not null primary key,
	name_ varchar(20),
	phone varchar(20),
	email varchar(20),
	position int,
	salary int,

	Foreign key (position) REFERENCES Position(ID)
)

create table Parent(
	ID int not null primary key,
	name_ varchar(20),
	phone varchar(20),
	egn varchar(10)
)

create table Napravlenie(
	ID int not null primary key,
	name_ varchar(20)
)

create table Doctor(
	ID int not null primary key,
	name_ varchar(20),
	phone varchar(20),
	email varchar(20),
	salary int,
	Pacient int
)

alter table Doctor
Add Foreign key (Pacient) REFERENCES Pacient(ID);

create table Pacient(
	ID int not null primary key,
	name_ varchar(20),
	phone varchar(20),
	egn varchar(10),
	parent int,
	doctor int

	Foreign key (doctor) REFERENCES Doctor(ID),
	Foreign key (parent) REFERENCES Parent(ID)
)
