use ProjectB
-----------------------------------------------------------Mid Project---------------------------------------------------
SELECT * FROM Student

INSERT INTO Student VALUES(12, 'Saqlain', 'Mansab', '321-7137316', LTRIM(RTRIM('saqlainmansab786@gmail.com')), '2022-CS-80');

INSERT INTO Student (FirstName, LastName, Contact, Email, RegistrationNumber, Status)
VALUES ('Saqlain', 'Mansab', '321-7137316', N'saqlainmansab786@gmail.com', '2022-CS-80', 1);

INSERT INTO Student (FirstName, LastName, Contact, Email, RegistrationNumber, Status)
VALUES ('Saqlain', 'Mansab', '321-7137316', N'saqlainmansab786@gmail.com', '2022-CS-80', 1);

DELETE FROM Student
WHERE FirstName = 'Saqlain' AND  LastName = 'Mansab' AND RegistrationNumber = '2022-CS-80';

SELECT * FROM Student

INSERT INTO Student VALUES('AbdulRehman','Irfan','3194175464','abdulrehmanirfan2238@gmail.com','2022-CS-57',1);
INSERT INTO Student VALUES('Muhammad','Adnan','3327645608','madnanbirmani@gmail.com','2022-CS-59',1);
INSERT INTO Student VALUES('Aaliya','khalil','3251620682','aaliyakhalil2022@gmail.com','2022-CS-61',1);
INSERT INTO Student VALUES('Aqsa','Batool','3166766345','aqsabatool6766@gmail.com','2022-CS-62',1);
INSERT INTO Student VALUES('Faisal','Illyas','3098999180','faisalillyas2005@gmail.com','2022-CS-63',1);
INSERT INTO Student VALUES('Wali','Ahmad','3370433034','waliaslam2002@gmail.com','2022-CS-65',1);
INSERT INTO Student VALUES('Bisma','Fajar','3203654518','bismafajar816@gmail.com','2022-CS-66',1);
INSERT INTO Student VALUES('Hamid','Ali','3114374591','hamidali786offiun@gamil.com','2022-CS-67',1);
INSERT INTO Student VALUES('Ruhab','Fatima','3258685572','ruhab0907@gmail.com','2022-CS-69',1);
INSERT INTO Student VALUES('Laiba','Tanveer','3160210724','lk5762721@gmail.com','2022-CS-70',1);
INSERT INTO Student VALUES('Fasi','Tahir','3030904069','fasitahir2019@gmail.com','2022-CS-71',1);
INSERT INTO Student VALUES('Leena','Zaheer','3344907146','leenazaheer734@gmail.com','2022-CS-72',1);
INSERT INTO Student VALUES('Muhammad','Asghar','3017512317','asgharrind2580@gmail.com','2022-CS-73',1);
INSERT INTO Student VALUES('Alishba','Mazhar','3010966661','sheikhalishba878@gmail.com','2022-CS-74',1);
INSERT INTO Student VALUES('Gul-e-Zahra',NULL,'3354373016','gulezahrasyeda980@gmail.com','2022-CS-75',1);
INSERT INTO Student VALUES('Jaffer','Hussain','3091476620','jaffer1272hussain@gmail.com','2022-CS-76',1);
INSERT INTO Student VALUES('Mudasir','Ahmad','3058111211','mudasirofficially@gmail.com','2022-CS-77',1);
INSERT INTO Student VALUES('Muhammd','Tabish','3096358926','tabishakhtar007860@gmail.com','2022-CS-78',1);
INSERT INTO Student VALUES('Abdul','Rehman','3124647314','abrehman1748@gmail.com','2022-CS-79',1);
INSERT INTO Student VALUES('Saqlain','Mansab','3217137316','saqlainmansab786@gmail.com','2022-CS-80',1);
INSERT INTO Student VALUES('Sami','Ullah','3176546520','sami03136424477@gmail.com','2022-CS-82',1);
INSERT INTO Student VALUES('Shammas','Ahmad','3441850394','shammasahmad90@gmail.com','2022-CS-83',1);
INSERT INTO Student VALUES('Zulqarnain','Akram','3186626748','zulqarzulqar07@gmail.com','2022-CS-84',1);
INSERT INTO Student VALUES('Abdul','Moeed','3072843636','abdulmoeed713@gmail.com','2022-CS-88',1);
INSERT INTO Student VALUES('Usman','Kibria','3269841349','usmankibria@gmail.com','2022-CS-90',1);
INSERT INTO Student VALUES('Noman','Ahmad','3214399336','mr.noman0095@gmail.com','2022-CS-91',1);
INSERT INTO Student VALUES('Misbah','sultan','3262580618','misbahh77777@gmail.com','2022-CS-92',1);
INSERT INTO Student VALUES('Khalil','Ahmad','322060132','iamkhalil2005@gmail.com','2022-CS-93',1);
INSERT INTO Student VALUES('Malik Muhammad','Saad','3146968827','maliksaadrafi@gmail.com','2022-CS-94',1);
INSERT INTO Student VALUES('Abdullah','Ahmed','3354848355','0.abdull.ah.med@gmail.com','2022-CS-95',1);
INSERT INTO Student VALUES('Abdul','Sabur','3060020007','alsabur20@gmail.com','2022-CS-98',1);
INSERT INTO Student VALUES('Fatima','Raees','3221418888','fatima.R168@gmail.com','2022-CS-100',1);
INSERT INTO Student VALUES('Maryam','Waseem','3184121151','maryamw1124@gmail.com','2022-CS-101',1);


-- to insert data in a table from table
INSERT INTO table2 (column1, column2, column3)
SELECT column1, column2, column3
FROM table1
WHERE condition;

SELECT * FROM Student
SELECT * FROM Clo

INSERT INTO Assessment VALUES('Mid-Exams', '2024-02-28', 30, 30);
INSERT INTO Assessment VALUES('Final-Exams', '2024-02-28', 40, 40);
INSERT INTO Assessment VALUES('Quiz1', '2024-02-28', 10, 10);
INSERT INTO Assessment VALUES('Quiz2', '2024-02-28', 10, 10);
INSERT INTO Assessment VALUES('Quiz3', '2024-02-28', 10, 10);
INSERT INTO Assessment VALUES('Quiz4', '2024-02-28', 10, 10);

INSERT INTO Clo VALUES('CLO1', '2024-02-28', '2024-02-28');
INSERT INTO Clo VALUES('CLO2', '2024-02-28', '2024-02-28');
INSERT INTO Clo VALUES('CLO3', '2024-02-28', '2024-02-28');

UPDATE Student
SET FirstName = 'NewFirstName', LastName = 'NewLastName', RegistrationNumber = 'NewRegistrationNumber'
WHERE FirstName = 'Saqlain' AND  LastName = 'Mansab' AND RegistrationNumber = '2022-CS-80';


UPDATE Student
SET Status = 5
--WHERE Status = 6
where RegistrationNumber > '2022-CS-60'

select * from StudentAttendance
select * from ClassAttendance
select * from student
select * from RubricLevel
select * from Rubric
select * from AssessmentComponent
select * from Assessment
select * from clo

SELECT Id, CONCAT(FirstName, ' ', LastName) AS Name, Contact, Email, RegistrationNumber FROM Student WHERE Status = 5;

DELETE FROM Rubric WHERE Id = 1;

update assessment
set TotalWeightage = 5
where TotalMarks = 10
	
INSERT INTO ClassAttendance VALUES ('2024-03-06 00:00:00.000');
SELECT Id FROM ClassAttendance WHERE AttendanceDate = '2024-03-06 00:00:00.000';
INSERT INTO Rubric VALUES(1, 'Design', 2);
INSERT INTO Rubric VALUES(2, 'Execution', 2);
INSERT INTO Rubric VALUES(3, 'Testing', 2);

INSERT INTO RubricLevel VALUES(1, 'Program should be properly decomposed in reusable components.', 4);

UPDATE AssessmentComponent
SET Name = 'NewIMP'
WHERE Id = 1;


SELECT sa.AttendanceId, AttendanceDate, l.Name AS Status, sa.StudentId, CONCAT(FirstName, ' ', LastName) AS Name, Email, RegistrationNumber
FROM StudentAttendance sa
INNER JOIN Student s
ON sa.StudentId = s.Id
INNER JOIN ClassAttendance ca
ON ca.Id = sa.AttendanceId
INNER JOIN Lookup l
ON l.LookupId = sa.AttendanceStatus
WHERE s.Id = 5001



SELECT
    TT.StudentName,
    TT.Assessment,
    SUM(TT.[Obtained Marks]) AS ObtainedTotal,
    CAST((SUM(TT.[Obtained Marks]) * TT.TotalWeightage / SUM(TT.TotalMarks)) AS DECIMAL(16, 2)) AS WeightedMarks
FROM
    (SELECT
        --CONCAT(S.FirstName, ' ', S.LastName) AS StudentName,
        CONCAT(C.Id, '-', C.Name) AS [CLO Title],
        CONVERT(DATE, SR.EvaluationDate) AS [Evaluation Date],
        A.Title AS Assessment,
        AC.Name AS Component,
        AC.TotalMarks,
        RL.MeasurementLevel AS [Examiners Measure],
        (SELECT MAX(RLP.MeasurementLevel) FROM RubricLevel RLP WHERE RLP.RubricId = R.Id) AS [Max Measure],
        CAST(((CAST(RL.MeasurementLevel AS FLOAT) / CAST((SELECT MAX(RLP.MeasurementLevel) FROM RubricLevel RLP WHERE RLP.RubricId = R.Id) AS FLOAT))) * CAST(AC.TotalMarks AS FLOAT) AS DECIMAL(16, 2)) AS [Obtained Marks],
        A.TotalWeightage
    FROM
        Assessment A
		JOIN Student S ON S.Id = A.Id
        JOIN AssessmentComponent AC ON AC.AssessmentId = A.Id
        JOIN StudentResult SR ON SR.AssessmentComponentId = AC.Id
        JOIN RubricLevel RL ON SR.RubricMeasurementId = RL.Id
        JOIN Rubric R ON RL.RubricId = R.Id
        JOIN Clo C ON R.CloId = C.Id
    GROUP BY
        A.Title,
        SR.StudentID,
        AC.Name,
        AC.TotalMarks,
        RL.Id,
        RL.MeasurementLevel,
        SR.RubricMeasurementId,
        R.Id,
        C.Name,
        C.Id,
        SR.EvaluationDate,
        A.TotalWeightage) TT
GROUP BY
    --TT.StudentName,
    TT.Assessment,
    TT.TotalWeightage;

BACKUP DATABASE tempdb
TO DISK = 'C:\Users\HP\Desktop'
WITH FORMAT, NAME = 'Full Database Backup';