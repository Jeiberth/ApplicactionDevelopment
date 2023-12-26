USE master

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'PERSONAL_TRANSACTIONS')
BEGIN
    CREATE TABLE PERSONAL_TRANSACTIONS (
        ID VARCHAR(50),
        TRANSACTION_ VARCHAR(50),
        AMOUNT FLOAT,
        ID_OTHER_ACCOUNT_INVOLVED VARCHAR(50)
    );
END;
ELSE 
BEGIN
	DROP TABLE PERSONAL_TRANSACTIONS
	CREATE TABLE PERSONAL_TRANSACTIONS (
        ID VARCHAR(50),
        TRANSACTION_ VARCHAR(50),
        AMOUNT FLOAT,
        ID_OTHER_ACCOUNT_INVOLVED VARCHAR(50)
    );
END;





IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'PERSON')
BEGIN
    CREATE TABLE PERSON (
        ID VARCHAR(50) PRIMARY KEY,
        FULL_NAME VARCHAR(50),
        AGE INT,
        EMAIL VARCHAR(50),
        AMOUNT FLOAT,
        PASSWORD_ VARCHAR(50),
        admin INT
    );
END;
ELSE
BEGIN
	Drop table PERSON;
	CREATE TABLE PERSON (
        ID VARCHAR(50) PRIMARY KEY,
        FULL_NAME VARCHAR(50),
        AGE INT,
        EMAIL VARCHAR(50),
        AMOUNT FLOAT,
        PASSWORD_ VARCHAR(50),
        admin INT
    );
END;

INSERT INTO PERSON(ID, FULL_NAME, AGE, EMAIL, AMOUNT, PASSWORD_, admin)
VALUES
('USR001', 'John Doe', 25, 'john.doe@example.com', 100.50, 'securepass123', 0),
('USR002', 'Jane Smith', 30, 'jane.smith@example.com', 150.75, 'mypassword456', 1),
('USR003', 'Michael Johnson', 22, 'michael.johnson@example.com', 75.25, 'pass789word', 0),
('USR004', 'Emily Davis', 28, 'emily.davis@example.com', 200.00, 'password987', 1),
('USR005', 'Robert Taylor', 35, 'robert.taylor@example.com', 120.00, 'securepass654', 0),
('USR006', 'Maria Garcia', 27, 'maria.garcia@example.com', 180.50, 'mypassword321', 1),
('USR007', 'David White', 32, 'david.white@example.com', 90.75, 'securepass555', 0),
('USR008', 'Olivia Brown', 29, 'olivia.brown@example.com', 160.25, 'password111', 1),
('USR009', 'Sophia Miller', 31, 'sophia.miller@example.com', 110.50, 'mypassword777', 0),
('USR010', 'Ethan Wilson', 26, 'ethan.wilson@example.com', 130.75, 'securepass888', 1),
('USR011', 'Emma Turner', 24, 'emma.turner@example.com', 95.25, 'password222', 0),
('USR012', 'Daniel Parker', 33, 'daniel.parker@example.com', 170.00, 'securepass333', 1),
('USR013', 'Ava Adams', 28, 'ava.adams@example.com', 140.50, 'mypassword444', 0),
('USR014', 'William Harris', 36, 'william.harris@example.com', 120.75, 'securepass000', 1),
('USR015', 'Sophie Clark', 23, 'sophie.clark@example.com', 190.25, 'password999', 0);


-- Insertar datos en la tabla PERSONAL_TRANSACTION
INSERT INTO PERSONAL_TRANSACTIONS (ID, TRANSACTION_, AMOUNT, ID_OTHER_ACCOUNT_INVOLVED)
VALUES
('USR001', 'Receiving', 50.25, 'USR002'),
('USR002', 'Sending', 50.25, 'USR001'),
('USR002', 'Receiving', 30.75, 'USR003'),
('USR003', 'Sending', 30.75, 'USR002'),
('USR003', 'Receiving', 20.50, 'USR001'),
('USR001', 'Sending', 20.50, 'USR003'),
('USR004', 'Receiving', 75.00, 'USR005'),
('USR005', 'Sending', 75.00, 'USR004'),
('USR005', 'Receiving', 45.30, 'USR006'),
('USR006', 'Sending', 45.30, 'USR005'),
('USR006', 'Receiving', 60.80, 'USR007'),
('USR007', 'Sending', 60.80, 'USR006'),
('USR007', 'Receiving', 90.25, 'USR008'),
('USR008', 'Sending', 90.25, 'USR007'),
('USR008', 'Receiving', 110.75, 'USR009'),
('USR009', 'Sending', 110.75, 'USR008'),
('USR009', 'Receiving', 25.50, 'USR010'),
('USR010', 'Sending', 25.50, 'USR009'),
('USR010', 'Receiving', 70.20, 'USR011'),
('USR011', 'Sending', 70.20, 'USR010'),
('USR011', 'Receiving', 40.50, 'USR012'),
('USR012', 'Sending', 40.50, 'USR011'),
('USR012', 'Receiving', 55.75, 'USR013'),
('USR013', 'Sending', 55.75, 'USR012'),
('USR013', 'Receiving', 80.20, 'USR014'),
('USR014', 'Sending', 80.20, 'USR013'),
('USR014', 'Receiving', 95.00, 'USR015'),
('USR015', 'Sending', 95.00, 'USR014'),
('USR015', 'Receiving', 120.25, 'USR001'),
('USR001', 'Sending', 120.25, 'USR015');

select * from PERSON
select * from PERSONAL_TRANSACTIONS