CREATE TABLE Subject
(
	id INT primary key,
	name VARCHAR,
	cntHours INT,
	semestr INT,
	rating INT
);

CREATE TABLE Kafedra
(
	id INT primary key,
	name VARCHAR,
	descr VARCHAR
);

CREATE TABLE Teachers
(
	id INT primary key,
	fio VARCHAR,
	stepen VARCHAR,
	doljnost VARCHAR,
	kafId INT,
	
	CONSTRAINT FK_KafId FOREIGN KEY (kafId) REFERENCES Kafedra (Id)
);


CREATE TABLE Sub_Teac
(
	teacherId INT,
	subjId INT,
	
	CONSTRAINT FK_TeachId FOREIGN KEY (teacherId) REFERENCES Teachers (Id),
	CONSTRAINT FK_SubjectId FOREIGN KEY (subjId) REFERENCES Subject (Id)
);

-- Процедура выводящая существующие индексы указанной таблицы
CREATE or REPLACE FUNCTION printIndexes (
	tName TEXT
) RETURNS table(tabname name, indname name, inddef text)

AS $BODY$

BEGIN
	return query
    SELECT tablename, indexname, indexdef
	FROM pg_indexes
	WHERE tablename = tName;
  
END;
$BODY$ LANGUAGE 'plpgsql';

select * from printIndexes('clinics');
