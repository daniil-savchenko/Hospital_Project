SELECT * FROM Pacients

INSERT INTO Parents
Values(' ', ' ', ' ', ' ')

DELETE FROM Parents
WHERE ID = 4 OR ID = 3

ALTER TABLE Pacients
ADD CONSTRAINT PacNameCheck CHECK ( LEN(pacName) > 0)

alter table Parents
DROP CONSTRAINT ParNameCheck

ALTER TABLE Parents
ADD CONSTRAINT ParNameCheck CHECK ( LEN(parName) > 0)