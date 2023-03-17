Create table Positions(
	ID int not null primary key,
	posName varchar(20)
)

create table Workers(
	ID int not null primary key,
	workerName varchar(20),
	phone varchar(10),
	email varchar(20),
	Position int,
	salary float,

	Foreign key (Position) REFERENCES Positions(ID)
)

create table Parents(
	ID int not null primary key,
	parName Varchar(20),
	phone varchar(10),
	egn varchar(10)
)

create table Pacients(
	ID int not null primary key,
	pacName varchar(20),
	phone Varchar(10),
	egn varchar(10),
	Parent int,
	Doctor int,

	Foreign key (Parent) REFERENCES Parents(ID),
	Foreign key (Doctor) REFERENCES Doctors(ID)
)

Create table Doctors(
	ID int not null primary key,
	workerName varchar(20),
	phone varchar(10),
	email varchar(20),
	salary float,
)

Create table Reservations(
	ID int not null,
	thedate smalldatetime, /*YYYY-MM-DD hh:mm:ss*/
	Patient int,
	Doctor int,

	Foreign key (Patient) REFERENCES Pacients(ID),
	Foreign key (Doctor) REFERENCES Doctors(ID)
)