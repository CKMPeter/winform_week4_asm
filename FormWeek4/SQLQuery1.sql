drop table Student;
drop table Teacher;

CREATE TABLE Student (
	stuId VarChar(100) PRIMARY KEY,
	stuName VarChar(100),
	stuAddr VarChar(100),
    stuEmail VarChar(100) unique,
    stuPhone VarChar(100) unique,
    stuGender BIT,
	stuBDay Date
);


CREATE TABLE Teacher (
	teaId VarChar(100) PRIMARY KEY,
	teaName VarChar(100),
	teaAddr VarChar(100),
    teaEmail VarChar(100) unique,
    teaPhone VarChar(100) unique,
    teaGender BIT,
	teaBDay Date
);

INSERT INTO Student (stuName, stuId, stuAddr, stuEmail, stuBDay, stuPhone, stuGender) 
VALUES 
    ('nva2', '124', 'hcm', '1@gmail.com', '2003-01-01', '1234567890', 1),
    ('nva3', '125', 'hcm', '2@gmail.com', '2003-01-01', '2345678901', 0),
    ('nva4', '126', 'hcm', '3@gmail.com', '2003-01-01', '3456789012', 1),
    ('nva5', '127', 'hcm', '4@gmail.com', '2003-01-01', '4567890123', 0),
    ('nva6', '128', 'hcm', '5@gmail.com', '2003-01-01', '5678901234', 1);


INSERT INTO Teacher(teaName, teaId, teaAddr, teaBDay) 
VALUES 
    ('nva2','124','hcm', '2003-01-01'),
    ('nva3','125','hcm', '2003-01-01'),
    ('nva4','126','hcm', '2003-01-01'),
    ('nva5','127','hcm', '2003-01-01'),
    ('nva6','128','hcm', '2003-01-01');

SELECT * FROM Student;
SELECT * FROM Teacher;

go
create trigger Age_Valid on Student
after insert, update
as
begin
     SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM inserted WHERE stuBDay >= DATEADD(YEAR, -17, GETDATE()))
    BEGIN
        RAISERROR('The student must be at least 17 years old.', 16, 1);
    END
end;

go
create trigger Phone_Valid on Student
after insert, update
as
begin
    set nocount on;

    update s
    set stuPhone = concat(substring(i.stuPhone, 1, 3), '-', substring(i.stuPhone, 5, 4), '-', substring(i.stuPhone,9,3))
    from Student s
    inner join inserted i on s.stuId = i.stuId;
end;