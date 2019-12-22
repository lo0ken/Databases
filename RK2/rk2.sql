CREATE DATABASE RK2 OWNER postgres;

CREATE TABLE Child
(
	Id INT Primary key,
	FIO varchar(50),
	BirthYear varchar(50),
	Address varchar(50),
	PhoneNumber varchar(50)
);

CREATE TABLE Clinics
(
	Id int primary key,
	Name varchar(50),
	BuildYear varchar(50),
	Description varchar(50)
);

CREATE TABLE Vaccine 
(
	Id int primary key,
	Name varchar(50),
	Description varchar (50)
);

CREATE TABLE Child_Vacine
(
	Child_Id int,
	Vaccine_Id int,
	
	CONSTRAINT FK_ChildId FOREIGN KEY (Child_Id) REFERENCES Child (Id),
	CONSTRAINT FC_VaccineId FOREIGN KEY (Vaccine_Id) REFERENCES Vaccine (Id)
);

CREATE TABLE Clinics_Vaccine
(
	Clinic_Id int,
	Vaccine_Id int,
	
	CONSTRAINT FK_ClinicId FOREIGN KEY (Clinic_Id) REFERENCES Clinics (Id),
	CONSTRAINT FC_VaccineId FOREIGN KEY (Vaccine_Id) REFERENCES Vaccine (Id)
);

INSERT INTO Child VALUES (1, 'FIO1', '2000', 'ChildAddress1', '79777777777');
INSERT INTO Child VALUES (2, 'FIO1', '2000', 'ChildAddress2', '79777777773');
INSERT INTO Child VALUES (3, 'FIO1', '2001', 'ChildAddress3', '79777777774');
INSERT INTO Child VALUES (4, 'FIO1', '2000', 'ChildAddress4', '79777777775');
INSERT INTO Child VALUES (5, 'FIO1', '2001', 'ChildAddress5', '79777777776');

INSERT INTO Clinics VALUES (1, 'ClinicName1', '1993', 'Description1');
INSERT INTO Clinics VALUES (2, 'ClinicName2', '1991', 'Description2');
INSERT INTO Clinics VALUES (3, 'ClinicName3', '1992', 'Description3');
INSERT INTO Clinics VALUES (4, 'ClinicName4', '1993', 'Description4');
INSERT INTO Clinics VALUES (5, 'ClinicName5', '1994', 'Description5');

INSERT INTO Vaccine VALUES (1, 'Vacine1', 'Vacine1Descr');
INSERT INTO Vaccine VALUES (2, 'Vacine2', 'Vacine2Descr');
INSERT INTO Vaccine VALUES (3, 'Vacine3', 'Vacine3Descr');
INSERT INTO Vaccine VALUES (4, 'Vacine4', 'Vacine4Descr');
INSERT INTO Vaccine VALUES (5, 'Vacine5', 'Vacine5Descr');

INSERT INTO Child_Vacine VALUES (1, 1);
INSERT INTO Child_Vacine VALUES (2, 2);
INSERT INTO Child_Vacine VALUES (3, 3);
INSERT INTO Child_Vacine VALUES (4, 4);
INSERT INTO Child_Vacine VALUES (5, 5);
INSERT INTO Child_Vacine VALUES (1, 2);
INSERT INTO Child_Vacine VALUES (2, 3);
INSERT INTO Child_Vacine VALUES (4, 5);
INSERT INTO Child_Vacine VALUES (5, 1);

INSERT INTO Clinics_Vaccine VALUES (1, 1);
INSERT INTO Clinics_Vaccine VALUES (2, 2);
INSERT INTO Clinics_Vaccine VALUES (3, 3);
INSERT INTO Clinics_Vaccine VALUES (4, 4);
INSERT INTO Clinics_Vaccine VALUES (5, 5);
INSERT INTO Clinics_Vaccine VALUES (1, 2);
INSERT INTO Clinics_Vaccine VALUES (2, 3);
INSERT INTO Clinics_Vaccine VALUES (4, 5);
INSERT INTO Clinics_Vaccine VALUES (5, 1);*/

------- TASK 2 ----------------------------------------------

-- Найти клиники построенные в 1993 году
select *
from Clinics C
where C.buildYear = '1993';

-- Найти количество вакцин всех типов
select *, count(Vaccine_id)
over(partition by Vaccine_id)
as Count_Vaccine_This_Type
from Clinics_Vaccine

-- Вывести всех детей, которым была сделана вакцина 3
select child_id
from (
	select Child_id, Vaccine_id
	from Child_Vacine
	where Vaccine_id = 3
) as tmp
inner join Child on Child_id = Child.id

---------------------------- TASK 3 ---------------------------------
-- Процедура которая удаляет таблицы с заданным названием

CREATE TABLE TableName();

CREATE or REPLACE PROCEDURE dropTables (
	IN _schema TEXT, IN _parttionbase TEXT
) LANGUAGE 'plpgsql'

AS $BODY$
DECLARE
    row     record;
BEGIN
    FOR row IN 
        SELECT
            table_schema,
            table_name
        FROM
            information_schema.tables
        WHERE
            table_type = 'BASE TABLE'
        AND
            table_schema = _schema
        AND
            table_name ILIKE (_parttionbase || '%')
    LOOP
        EXECUTE 'DROP TABLE ' || quote_ident(row.table_schema) || '.' || quote_ident(row.table_name);
        RAISE INFO 'Dropped table: %', quote_ident(row.table_schema) || '.' || quote_ident(row.table_name);
    END LOOP;
END;
$BODY$;

call dropTables('public', 'TableName');