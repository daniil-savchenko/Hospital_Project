ALTER TABLE Pacients
ADD CONSTRAINT PacNameCheck CHECK (LEN(pacName) > 0)

ALTER TABLE Pacients
ADD CONSTRAINT phoneNameCheck CHECK (LEN(phone) > 0)

ALTER TABLE Pacients
ADD CONSTRAINT egnCheck CHECK (LEN(egn) > 0)

ALTER TABLE Positions
ADD CONSTRAINT posNameCheck CHECK (LEN(posName) > 0)

ALTER TABLE Pacients
DROP CONSTRAINT PacNameCheck

SELECT * FROM Pacients
DELETE FROM  Pacients
where pacname != 'sad'