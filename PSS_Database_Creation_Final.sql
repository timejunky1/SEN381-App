
CREATE DATABASE PSS;
GO

USE PSS

CREATE TABLE employee (
	employee_id INT IDENTITY(1,1) PRIMARY KEY,
    email VARCHAR(30) UNIQUE,
    name VARCHAR(15) NOT NULL,
    surname VARCHAR(15) NOT NULL,
    password VARCHAR(10) NOT NULL,
    job_title VARCHAR(30) NOT NULL
);
CREATE TABLE address (
    address_id INT IDENTITY(1,1) PRIMARY KEY,
    street_no INT,
    street VARCHAR(50),
    city VARCHAR(30),
    province VARCHAR(15),
    zipcode VARCHAR(4)
);
CREATE TABLE service (
    service_id INT IDENTITY(1,1) PRIMARY KEY,
    title VARCHAR(30) NOT NULL,
    duration INT NOT NULL Default 30,
    priority INT NOT NULL Default 0,
    cost DECIMAL(10, 2) NOT NULL Default 0,
	availability varchar(20) NOT NULL Default 'Unavailable',
	CHECK (priority BETWEEN 0 AND 5)
);
CREATE TABLE contract (
    contract_id INT IDENTITY(1,1) PRIMARY KEY,
    SLA VARCHAR(255),
    duration INT NOT NULL Default 0,
	cost DECIMAL(10, 2) NOT NULL Default 0,
    priority INT NOT NULL Default 0,
	availability varchar(20) NOT NULL Default 'Unavailable',
);

CREATE TABLE contract_ref (
    ref_id INT IDENTITY(1,1) PRIMARY KEY,
	contract_id INT NOT NULL,
    service_id INT NOT NULL,
    FOREIGN KEY (service_id) REFERENCES service(service_id),
	FOREIGN KEY (contract_id) REFERENCES contract(contract_id)
);
CREATE TABLE client (
    client_id INT IDENTITY(1,1) PRIMARY KEY,
    company_name VARCHAR(50),
	person_name VARCHAR(15) NOT NULL,
	person_surname VARCHAR(15) NOT NULL,
    address_id INT NOT NULL,
    contract_id INT NOT NULL,
    phone VARCHAR(10) NOT NULL,
	email VARCHAR(30) UNIQUE,
	password varchar(30),
	contract_initiation_date DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (address_id) REFERENCES address(address_id),
    FOREIGN KEY (contract_id) REFERENCES contract(contract_id)
);
CREATE TABLE login (
    login_id INT IDENTITY(1,1) PRIMARY KEY,
    email VARCHAR(30) UNIQUE,
    time_in DATETIME NOT NULL,
    time_out DATETIME,
    FOREIGN KEY (email) REFERENCES employee(email),
	FOREIGN KEY (email) REFERENCES client(email)
);
CREATE TABLE call_log (
    call_id INT IDENTITY(1,1) PRIMARY KEY,
    employee_id INT NOT NULL,
    client_id INT NOT NULL,
    client_name VARCHAR(255),
    role VARCHAR(255),
    description TEXT,
    call_time DATETIME NOT NULL,
    FOREIGN KEY (employee_id) REFERENCES employee(employee_id),
    FOREIGN KEY (client_id) REFERENCES client(client_id)
);
CREATE TABLE job (
    job_id INT IDENTITY(1,1) PRIMARY KEY,
    client_id INT,
    service_id INT,
    time_begin DATETIME,
    time_end DATETIME,
    status VARCHAR(255),
	notes VARCHAR(255),
    FOREIGN KEY (client_id) REFERENCES client(client_id),
    FOREIGN KEY (service_id) REFERENCES service(service_id)
);
CREATE TABLE job_call_ref(
	ref_id INT IDENTITY(1,1) PRIMARY KEY,
	call_id INT NOT NULL,
	job_id INT NOT NULL,
	FOREIGN KEY (call_id) REFERENCES call_log(call_id),
    FOREIGN KEY (job_id) REFERENCES job(job_id)
);
CREATE TABLE job_employee_ref(
	ref_id INT IDENTITY(1,1) PRIMARY KEY,
	employee_id INT NOT NULL,
	job_id INT NOT NULL,
	FOREIGN KEY (job_id) REFERENCES job(job_id),
	FOREIGN KEY (employee_id) REFERENCES employee(employee_id)
);

USE PSS


INSERT INTO employee
values
('joseph.kaur@example.com', 'Joseph', 'Kaur', 'Ruak6', 'Technician'),--1
('phillip.redwood@example.com', 'Phillip', 'Redwood', 'Doowder7', 'Technician'),
('doug.lambert@example.com', 'Doug', 'Lambert', 'Trebmal4', 'Technician'),
('melody.archer@example.com', 'Melody', 'Archer', 'Rehcra6', 'Technician'),
('danny.andrews@example.com', 'Danny', 'Andrews', 'Swerdna5', 'Technician'),
('sydney.alcroft@example.com', 'Sydney', 'Alcroft', 'Tforcla6', 'Technician'),
('britney.smith@example.com', 'Britney', 'Smith', 'Htims7', 'Technician'),
('gabriel.thornton@example.com', 'Gabriel', 'Thornton', 'Notnroht7', 'Technician'),
('judith.sherry@example.com', 'Judith', 'Sherry', 'Yrrehs6', 'Technician'),
('erick.robinson@example.com', 'Erick', 'Robinson', 'Nosnibor5', 'Technician'),
('elise.whitmore@example.com', 'Elise', 'Whitmore', 'Eromtihw5', 'Technician'),
('grace.cassidy@example.com', 'Grace', 'Cassidy', 'Ydissac5', 'Technician'),
('luke.tailor@example.com', 'Luke', 'Tailor', 'Roliat4', 'Technician'),
('william.overson@example.com', 'William', 'Overson', 'Nosrevo7', 'Technician'),
('chuck.lewis@example.com', 'Chuck', 'Lewis', 'Siwel5', 'Technician'),--15
('samara.carter@example.com', 'Samara', 'Carter', 'Retrac6', 'Call Employee'),--16
('meredith.whittle@example.com', 'Meredith', 'Whittle', 'Elttihw8', 'Call Employee'),
('martha.graves@example.com', 'Martha', 'Graves', 'Sevarg6', 'Call Employee'),
('tom.reese@example.com', 'Tom', 'Reese', 'Eseer3', 'Call Employee'),
('sarah.moore@example.com', 'Sarah', 'Moore', 'Eroom5', 'Call Employee'),
('william.truscott@example.com', 'William', 'Truscott', 'Ttocsurt7', 'Call Employee'),
('cedrick.warren@example.com', 'Cedrick', 'Warren', 'Nerraw7', 'Call Employee'),
('daniel.thompson@example.com', 'Daniel', 'Thompson', 'Nospmoht6', 'Call Employee'),--23
('lorraine.tobin@example.com', 'Lorraine', 'Tobin', 'Nibot8', 'Contract Manager'),--24
('matthew.bloom@example.com', 'Matthew', 'Bloom', 'Moolb7', 'Contract Manager'),--25
('michaela.hardwick@example.com', 'Michaela', 'Hardwick', 'Kciwdrah8', 'Client Manager'),--26
('rufus.mccall@example.com', 'Rufus', 'Mccall', 'Llaccm5', 'Client Manager'),
('ema.adams@example.com', 'Ema', 'Adams', 'Smada3', 'Client Manager'),--28
('rosalyn.asher@example.com', 'Rosalyn', 'Asher', 'Rehsa7', 'Service Manager'),--29
('sabina.rust@example.com', 'Sabina', 'Rust', 'Tsur6', 'Service Manager')--30

INSERT INTO service
values
('Service1', 30, 0, 3000.00, 'available'), --Cost = once off
('Service2', 60, 1, 6000.00, 'available'),
('Service3', 15, 3, 3000.00, 'available'),
('Service4', 30, 2, 2000.00, 'available'),
('Service5', 45, 0, 3000.00, 'available'),
('Service6', 120, 3, 8000.00, 'available'),
('Service7', 30, 2, 3000.00, 'available'),
('Service8', 120, 2, 3000.00, 'available'),
('Service9', 30, 3, 3000.00, 'available'),
('Service10', 45, 2, 3000.00, 'available')

INSERT INTO contract
values
('Contract1', 12, 0, 300.00, 'available'), --Cost = monthly
('Contract2', 12, 1, 600.00, 'available'),
('Contract3', 6, 3, 300.00, 'available'),
('Contract4', 12, 2, 200.00, 'available')

INSERT INTO address
values
(123, '1th Avenue' , 'Pretoria', 'Gauteng', '0008'),--1
(213, '2th Avenue' , 'Pretoria', 'Gauteng', '0008'),
(322, '3th Avenue' , 'Pretoria', 'Gauteng', '0008'),
(535, '4th Avenue' , 'Pretoria', 'Gauteng', '0008'),
(564, '5th Avenue' , 'Pretoria', 'Gauteng', '0008'),
(375, '6th Avenue' , 'Pretoria', 'Gauteng', '0008'),
(870, '7th Avenue' , 'Pretoria', 'Gauteng', '0008'),
(534, '8th Avenue' , 'Pretoria', 'Gauteng', '0008'),
(324, '9th Avenue' , 'Pretoria', 'Gauteng', '0008'),
(566, '10th Avenue' , 'Pretoria', 'Gauteng', '0008')--10

INSERT INTO client(company_name, person_name, person_surname, address_id, contract_id, phone, email, password)
values
('Company1', 'Greta', 'Dickson', 1, 2,'7633495798', 'greta.dickson@example.com', 'Noskcid5'),
('Company2', 'Ramon', 'Varley', 2, 3,'2645706296', 'ramon.varley@example.com', 'Yelrav5'),
('Company3', 'Angel', 'Fields', 3, 4,'7556361568', 'angel.fields@example.com', 'Sdleif5'),
('Company4','Chuck', 'Edler', 4, 1,'4489668166', 'chuck.edler@example.com', 'Relde5'),
('Company5', 'Aisha', 'Scott', 5, 2,'1163597247', 'aisha.scott@example.com', 'Ttocs5'),
('Company6', 'Estrella', 'Bradshaw', 6, 2,'2791072422', 'estrella.bradshaw@example.com', 'Wahsdarb8'),
('Company7', 'Emely', 'Fox', 7, 4,'3878171680', 'emely.fox@example.com', 'Xof5'),
('Company8', 'Celia', 'Simpson', 8, 3,'6434742681', 'celia.simpson@example.com', 'Nospmis5'),
('Company9', 'Alan', 'Alldridge', 9, 2,'1063848642', 'alan.alldridge@example.com', 'Egdirdlla4'),
('Company10', 'Sofia', 'Woodley', 10, 1,'6031541174', 'sofia.woodley@example.com', 'Yeldoow5')

INSERT INTO job
values
(9, 3, '2023-06-26 06:24:01', '2023-06-26 07:24:01', 'Finished',''),
(5, 9, '2023-11-20 07:57:09', '2023-11-20 08:57:09', 'Finished',''),
(8, 3, '2023-07-01 01:00:40', '2023-07-01 02:00:40', 'Finished',''),
(4, 4, '2023-09-24 21:31:30', '2023-09-24 22:31:30', 'Pending',''),
(5, 8, '2023-03-21 20:30:33', '2023-03-21 21:30:33', 'Pending',''),
(9, 1, '2023-12-16 02:01:26', '2023-12-16 03:01:26', 'Finished',''),
(1, 6, '2023-12-21 07:26:17', '2023-12-21 08:26:17', 'Finished',''),
(8, 7, '2023-09-10 12:37:37', '2023-09-10 13:37:37', 'Pending',''),
(4, 10, '2023-06-22 17:30:44', '2023-06-22 18:30:44', 'Pending',''),
(1, 4, '2023-12-10 00:11:11', '2023-12-10 01:11:11', 'Finished',''),
(3, 3, '2023-03-11 12:26:00', '2023-03-11 13:26:00', 'Pending',''),
(7, 6, '2023-05-16 23:48:12', '2023-05-17 00:48:12', 'Pending',''),
(8, 3, '2023-02-25 13:15:48', '2023-02-25 14:15:48', 'Pending',''),
(6, 1, '2023-10-05 05:44:09', '2023-10-05 06:44:09', 'Finished',''),
(5, 1, '2023-12-23 17:17:43', '2023-12-23 18:17:43', 'Pending',''),
(8, 6, '2023-04-15 22:11:49', '2023-04-15 23:11:49', 'Pending',''),
(8, 3, '2023-09-29 17:09:59', '2023-09-29 18:09:59', 'Pending',''),
(4, 7, '2023-04-10 11:37:24', '2023-04-10 12:37:24', 'Pending',''),
(6, 2, '2023-09-11 13:15:54', '2023-09-11 14:15:54', 'Pending',''),
(7, 5, '2023-08-16 16:41:25', '2023-08-16 17:41:25', 'Pending','')

INSERT INTO call_log
values
(22, 7, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-05-29 23:29:38'),--1
(20, 7, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-01-28 07:42:16'),
(20, 4, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-10-12 18:21:37'),
(23, 9, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-12-17 10:12:29'),
(16, 7, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-03-20 04:11:13'),
(21, 4, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-10-29 10:08:42'),
(22, 10, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-01-26 03:00:14'),
(17, 5, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-10-27 08:34:08'),
(16, 6, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-12-04 12:52:38'),
(18, 7, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-05-19 09:35:41'),
(17, 10, null, null,'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-02-15 13:07:52'),
(21, 4, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-10-26 00:39:42'),
(20, 9, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-02-05 15:06:32'),
(18, 9, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-03-26 00:21:16'),
(18, 8, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-02-10 00:32:05'),
(22, 9, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-01-06 08:09:31'),
(20, 4, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-02-21 21:53:21'),
(22, 9, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-11-04 08:13:34'),
(17, 4, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-06-30 21:25:12'),
(16, 5, null, null, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum integer enim neque volutpat ac tincidunt.', '2023-04-27 12:00:36')--20


INSERT INTO contract_ref
values
(3, 3),--1
(1, 3),
(4, 7),
(1, 6),
(1, 9),
(3, 7),
(4, 9),
(3, 5),
(3, 10),
(2, 2),
(1, 10),
(1, 1),
(4, 4),
(2, 5),
(1, 1),
(4, 7),
(2, 1),
(1, 5),
(2, 2),
(3, 9)--20


INSERT INTO job_call_ref
values
(3, 3),
(5, 7),
(18, 10),
(1, 5),
(6, 4),
(3, 14),
(5, 5),
(16, 19),
(2, 16),
(20, 19),
(8, 8),
(3, 13),
(18, 6),
(4, 8),
(20, 10),
(9, 10),
(10, 16),
(14, 12),
(19, 1),
(4, 15)


INSERT INTO job_employee_ref
values
(10, 14),
(11, 11),
(15, 19),
(13, 14),
(2, 16),
(10, 13),
(12, 18),
(5, 19),
(1, 14),
(1, 11),
(15, 18),
(15, 14),
(15, 16),
(10, 4),
(13, 20),
(13, 4),
(7, 3),
(12, 16),
(8, 4),
(5, 1),
(6, 12),
(15, 8),
(15, 5),
(10, 17),
(6, 3),
(15, 7),
(5, 2),
(7, 14),
(2, 8),
(3, 1)

--------------------------------------------------------------------------------------------------LoginPortal---------------------------------------------------------------------------------------------

-- Check if the schema exists
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'LogInProcedures')
BEGIN
    -- Create the schema if it does not exist
    EXEC('CREATE SCHEMA LogInProcedures')
END;
GO


--procedure to see if user with the password and username/email combenation exists
CREATE PROCEDURE LogInProcedures.AuthenticateUser
    @Username NVARCHAR(30),
    @Password VARCHAR(10),
    @UserRole NVARCHAR(50) OUTPUT,
    @EmployeeID INT OUTPUT
AS
BEGIN
    DECLARE @HashedPassword VARCHAR(100)

    SELECT @EmployeeID = employee_id,
           @UserRole = job_title,
           @HashedPassword = [password]
    FROM employee
    WHERE email = @Username

 

    IF @HashedPassword IS NOT NULL
    BEGIN
        IF HASHBYTES('SHA2_256', @Password) = @HashedPassword
        BEGIN
			INSERT INTO login (email, time_in)
			VALUES (@Username, GETDATE());
            -- Authentication successful
            RETURN 0
        END
    END

 

    -- Invalid credentials
    SET @UserRole = 'Invalid'
    SET @EmployeeID = NULL
    RETURN 1
END
GO

--procedure to get a user role
CREATE PROCEDURE LogInProcedures.GetUserRole
    @Username VARCHAR(30),
    @Role VARCHAR(30) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

 

    -- Retrieve the role of the user associated with the provided username
    SELECT @Role = job_title
    FROM employee
    WHERE email = @Username
END
GO
--procedure to logout
CREATE PROCEDURE LogInProcedures.RecordLogoutTime
	@email VARCHAR(30)
AS
BEGIN
	UPDATE login
	SET time_out = GETDATE()
	WHERE login_id IN (SELECT TOP 1 login_id FROM login WHERE email = @email ORDER BY time_in DESC)
END
GO
------------------------------------------------------------------------------------------------TechnicalPortal-----------------------------------------------------------------------------

-- Check if the schema exists
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'TechnicalPortalProcedures')
BEGIN
    -- Create the schema if it does not exist
    EXEC('CREATE SCHEMA TechnicalPortalProcedures')
END;
GO
-- Create View for expencive join opperation
CREATE VIEW JobServiceClientEmployee
As
	SELECT j.job_id, c.company_name, s.title, j.time_begin, j.time_end, j.status, jer.employee_id
    FROM job j
    INNER JOIN client c ON j.client_id = c.client_id
    INNER JOIN service s ON j.service_id = s.service_id
    INNER JOIN job_employee_ref jer ON j.job_id = jer.job_id

GO



-- Create Stored Procedure to Get Technician's Task List under the TechnicalPortalProcedures schema
CREATE PROCEDURE TechnicalPortalProcedures.GetTechnicianTaskList
    @employeeId INT -- Input parameter: Technician's employee_id
AS
BEGIN
    SELECT job_id,company_name, title, time_begin, time_end, status
	FROM JobServiceClientEmployee
    WHERE employee_id = @employeeId
	ORDER BY time_begin
END;
GO

-- Create Stored Procedure to Update Job Notes and Status for a Client
CREATE PROCEDURE TechnicalPortalProcedures.UpdateJobNotesAndStatus
    @clientId INT,
    @jobNotes NVARCHAR(MAX),
    @jobStatus NVARCHAR(255)
AS
BEGIN
    UPDATE job
    SET notes = @jobNotes,
        status = @jobStatus
    WHERE client_id = @clientId;
END;
GO

-- Create Stored Procedure to Get Client Details by Client ID
CREATE PROCEDURE TechnicalPortalProcedures.GetClientDetails
    @clientId INT
AS
BEGIN
    SELECT c.client_id, c.company_name, c.person_name, c.person_surname, 
           a.street_no, a.street, a.city, a.province, a.zipcode
    FROM client c
    INNER JOIN address a ON c.address_id = a.address_id
    WHERE c.client_id = @clientId;
END;
GO

-- Create Stored Procedure to Get Service Overview by Client ID
CREATE PROCEDURE TechnicalPortalProcedures.GetServiceOverview
    @clientId INT
AS
BEGIN
    SELECT s.service_id, s.title, s.duration, s.priority, s.cost
    FROM job j
    INNER JOIN service s ON j.service_id = s.service_id
    WHERE j.client_id = @clientId;
END;
GO

-- Create Stored Procedure to Get Technician Schedule
CREATE PROCEDURE TechnicalPortalProcedures.GetTechnicianSchedule
    @employeeId INT -- Input parameter: Technician's employee_id
AS
BEGIN
    SELECT job_id,company_name, title, time_begin, time_end, status
	FROM JobServiceClientEmployee
    WHERE employee_id = @employeeId and status = 'In Process'
    ORDER BY time_begin, time_end
END;
GO

-----------------------------------------------------------------------------------------ServiceManagement------------------------------------------------------------------------------------

-- Check if the schema exists
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'ServicePortalProcedures')
BEGIN
    -- Create the schema if it does not exist
    EXEC('CREATE SCHEMA ServicePortalProcedures')
END;
GO

------------------------------------------------------------------------------Views---------------------------------------------------------------------------------------
-- View and stored procedure to view the technician schedule
CREATE VIEW JobSchedule 
AS
	SELECT
		j.job_id,
		j.client_id,
		c.company_name,
		j.service_id,
		s.title,  
		j.time_begin,
		j.time_end,
		j.status
	FROM job j
	LEFT JOIN client c ON j.client_id = c.client_id
	LEFT JOIN service s ON j.service_id = s.service_id;
GO

-- View for updated Jobs for Employees
CREATE VIEW UpdatedJobEmployeeReferences AS
SELECT
    j.job_id,
    j.client_id,
    c.company_name,  
    j.service_id,
    s.title,  
    j.time_begin,
    j.time_end,
    j.status,
    jer.ref_id,
    jer.employee_id,
    e.name,
	e.surname
FROM job j
INNER JOIN job_employee_ref jer ON j.job_id = jer.job_id
LEFT JOIN client c ON j.client_id = c.client_id
LEFT JOIN service s ON j.service_id = s.service_id
LEFT JOIN employee e ON jer.employee_id = e.employee_id
Go


-- view to display jobs from highest to lowst priority
CREATE VIEW ViePriorityDesc AS
SELECT
    j.job_id,
    c.client_id,
    c.company_name,
    s.service_id,
    s.title AS service_title,
    j.time_begin,
    j.time_end,
    s.priority
FROM
    job j
JOIN
    client c ON j.client_id = c.client_id
JOIN
    service s ON j.service_id = s.service_id
GO

	-- View to display unassigned jobs
CREATE VIEW UnassignedJobs AS
SELECT
    j.job_id,
    c.client_id,
    c.company_name,
    s.service_id,
    s.title AS service_title,
    j.time_begin,
    j.time_end
FROM
    job j
JOIN
    client c ON j.client_id = c.client_id
JOIN
    service s ON j.service_id = s.service_id
LEFT JOIN
    job_employee_ref jer ON j.job_id = jer.job_id
WHERE
    jer.ref_id IS NULL OR status = 'pending'

GO

--view to display jobs of a certaim technician
CREATE VIEW JobsAssignedToEmployee AS
SELECT
    j.job_id,
    c.client_id,
    c.company_name,
    s.service_id,
    s.title AS service_title,
    j.time_begin,
    j.time_end,
    e.name AS employee_name,
    e.surname AS employee_surname
FROM
    job j
JOIN
    client c ON j.client_id = c.client_id
JOIN
    service s ON j.service_id = s.service_id
JOIN
    job_employee_ref jer ON j.job_id = jer.job_id
JOIN
    employee e ON jer.employee_id = e.employee_id;

GO
------------------------------------------------------------------------------Procedures---------------------------------------------------------------------------------------
CREATE PROCEDURE ServicePortalProcedures.GetJobSchedule
AS
BEGIN
    SELECT * FROM JobSchedule
	ORDER BY time_begin
END;

GO

-- stored procedure to assign a job to the technician
CREATE PROCEDURE ServicePortalProcedures.AssignJob
    @employee_id INT,
    @job_id INT
AS
BEGIN
    INSERT INTO job_employee_ref (employee_id, job_id)
    VALUES (@employee_id, @job_id);
END

GO

-- procedure to update an assigned job to the technician
CREATE PROCEDURE ServicePortalProcedures.UpdateAssignedJob
    @job_id INT,
    @new_employee_id INT
AS
BEGIN
    UPDATE job_employee_ref
    SET employee_id = @new_employee_id
    WHERE job_id = @job_id;
END;

GO

--procedure to display unassigned jobs for spisific date
CREATE PROCEDURE ServicePortalProcedures.UnassignedJobsOnDate
    @specificDate DATETIME
AS
BEGIN
    SELECT *
    FROM UnassignedJobs
    WHERE DATEADD(DAY, DATEDIFF(DAY, 0, time_begin), 0) = DATEADD(DAY, DATEDIFF(DAY, 0, @specificDate), 0)
END;

GO

---stored procedure to display jobs of a certaim technician
CREATE PROCEDURE ServicePortalProcedures.GetJobsAssignedToEmployeeByName
    @employeeName VARCHAR(30)
AS
BEGIN
    SELECT *
    FROM JobsAssignedToEmployee
    WHERE employee_name = @employeeName
END;


---------------------------------------------------------------------------------------ContractManagement---------------------------------------------------------------------------------------

-- Check if the schema exists
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'ContractPortalProcedures')
BEGIN
    -- Create the schema if it does not exist
    EXEC('CREATE SCHEMA ContractPortalProcedures')
END;
GO

---------------------------------------------------------------------------------------Views---------------------------------------------------------
--create a custom view with all the joins
CREATE VIEW ContractService
AS
	SELECT s.service_id as s_id,title, s.duration as s_duration, s.priority as s_priority, s.cost as s_cost, s.availability as s_availability,
	c.contract_id as c_id, SLA, c.duration as c_duration, c.priority as c_priority, c.cost as c_cost, c.availability as c_availability
	FROM service s
	inner join contract_ref cr ON cr.service_id = s.service_id inner join contract c on c.contract_id = cr.contract_id

GO

--View to see all jobs associated with the contract
CREATE view ContractJob 
AS 
	SELECT contract.contract_id as c_id, contract.availability as c_availability, job_id, time_begin 
	FROM contract
	inner join contract_ref ON contract_ref.contract_id = contract.contract_id 
	inner join service on service.service_id = contract_ref.service_id
	inner join job on job.service_id = service.service_id


GO
--------------------------------------------------------------------------------------------------Procedures------------------------------------------------------------------------
CREATE PROCEDURE ContractPortalProcedures.GetContracts
AS
	SELECT c.contract_id, SLA, duration, priority, cost, availability , count(client_id) AS client_count
	FROM contract c
	inner join client cl on cl.contract_id = c.contract_id
	GROUP BY availability, c.contract_id, SLA, duration, [priority], cost
	ORDER BY client_count DESC


GO

--procedure to get all the services associated with each contract
CREATE PROCEDURE ContractPortalProcedures.GetContractServices @contract int
AS
	SELECT title, s_id
	FROM contract_service
	WHERE c_id = @contract

GO

--procedure to get all the services
CREATE PROCEDURE ContractPortalProcedures.GetServices
AS
	SELECT s_id,title, s_duration, s_priority, s_cost, s_availability, count(c_id) AS contract_count
	FROM contract_service
	GROUP BY s_availability, s_priority, s_duration, s_cost ,title, s_id
	ORDER BY contract_count DESC

GO

--procedure toget the contract statistics
CREATE PROCEDURE ContractPortalProcedures.GetContractStats @period int, @c_id int
AS 
	Select c_id, c_availability, count(job_id) as num_jobs, time_begin
	from contract_job
	where time_begin < CURRENT_TIMESTAMP and DATEDIFF(MONTH, time_begin, CURRENT_TIMESTAMP) < @period and c_id = @c_id
	group by c_availability, c_id, time_begin
	order by c_availability, c_id, time_begin asc

GO

--procedure to create a contract
CREATE PROCEDURE ContractPortalProcedures.CreateContract @SLA varchar(255), @duration int, @priority int, @cost decimal(10,2), @availability varchar(10)
AS 
	INSERT INTO contract
	values
	(@SLA, @duration, @priority, @cost, @availability)

	SELECT TOP 1 contract_id
	FROM contract
	ORDER BY contract_id DESC

GO

--procedure to update a contract
CREATE PROCEDURE ContractPortalProcedures.UpdateContract @c_id int, @SLA varchar(255), @duration int, @priority int, @cost decimal(10,2), @availability varchar(10)
AS
	UPDATE contract
	SET SLA = @SLA,
		duration = @duration,
		priority = @priority,
		cost = @cost,
		availability = @availability
	WHERE contract_id = @c_id

GO

--procedure to delete a contract
CREATE PROCEDURE ContractPortalProcedures.DeleteContract @c_id int
AS
	UPDATE client
	set contract_id = null
	where contract_id = @c_id
	
	DELETE FROM contract_ref
	WHERE contract_id = @c_id

	DELETE FROM contract
	WHERE contract_id = @c_id


GO


CREATE PROCEDURE ContractPortalProcedures.CreateService @title varchar(30), @duration int, @priority int, @cost decimal(10,2), @availability varchar(10)
AS
	INSERT INTO service
	values
	(@title, @duration, @priority , @cost, @availability)

GO

--procedure to update a service
CREATE PROCEDURE ContractPortalProcedures.UpdateService @s_id int, @title varchar(30), @duration int, @priority int, @cost decimal(10,2), @availability varchar(10)
AS
	UPDATE service
	SET title = @title,
		duration = @duration,
		priority = @priority,
		cost = @cost,
		availability = @availability
	WHERE service_id = @s_id

GO

--procedure to delete a service
CREATE PROCEDURE ContractPortalProcedures.DeleteService @s_id int
AS
	UPDATE job
	set service_id = null
	where service_id = @s_id
	
	DELETE FROM contract_ref
	where service_id = @s_id
	
	DELETE FROM service
	WHERE service_id = @s_id

GO

--procedure to add to Contract ref
CREATE PROCEDURE ContractPortalProcedures.AddContractRef @c_id int, @s_id int
AS
	BEGIN
		IF NOT EXISTS (SELECT * FROM contract_ref WHERE contract_id = @c_id AND service_id = @s_id)
		INSERT INTO contract_ref
		values (@c_id, @s_id)
	END

GO
------------------------------------------------------------------------------CallEmployee---------------------------------------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'CallsPortalProcedures')
BEGIN
    -- Create the schema if it does not exist
    EXEC('CREATE SCHEMA CallsPortalProcedures')
END;
GO

CREATE PROCEDURE CallsPortalProcedures.GetClientOverview
	@clientID int
AS
BEGIN
	SELECT * FROM JobServiceClientEmployee
	WHERE company_name = (SELECT company_name FROM client WHERE client_id = @clientID)
END;

GO

CREATE PROCEDURE CallsPortalProcedures.GetEmployeeOverview
	@employeeID int
AS
BEGIN
	SELECT jscm.job_id, company_name, title, time_begin, time_end, status,description 
	FROM JobServiceClientEmployee jscm
	INNER JOIN job_call_ref jcr ON jcr.job_id = jscm.job_id
	INNER JOIN call_log cl ON cl.call_id = jcr.call_id
	WHERE cl.employee_id  = @employeeID
	ORDER BY time_begin DESC
END;

GO

CREATE VIEW ClientInfo
AS
SELECT email, phone, SLA, contract_initiation_date, DATEADD(MONTH,duration,contract_initiation_date) AS ExpirationDate
		FROM client c
		INNER JOIN contract co ON co.contract_id = c.contract_id
		GROUP BY SLA, contract_initiation_date, duration, email, phone
GO

CREATE PROCEDURE CallsPortalProcedures.GetClientInfo
	@clientUserName VARCHAR(30),
	@ContactNumber VARCHAR(10)
AS
	BEGIN
		SELECT * FROM ClientInfo
		WHERE email = @clientUserName AND phone = @ContactNumber 
	END;

GO


--CREATE PROCEDURE CallsPortalProcedures.RegisterClient


----------------------------------------------------------------------------ClientManagementPortal------------------------------------------------------------------------------------------------

-- Check if the schema exists
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'ClientManagementProcedures')
BEGIN
    -- Create the schema if it does not exist
    EXEC('CREATE SCHEMA ClientManagementProcedures')
END;
GO

---------------------------------------------------------------------------------------Procedures-------------------------------------------------------------------------------
--stored procedure to get client and contract info
CREATE PROCEDURE ClientManagementProcedures.GetClientAndContractInfo
    @ClientID INT
AS
BEGIN
    SELECT c.client_id, c.company_name, cc.SLA, cc.duration, cc.priority
    FROM client c
    LEFT JOIN contract cc ON c.contract_id = cc.contract_id
    WHERE c.client_id = @ClientID
END

GO
--stored procedure to get all the client info
CREATE PROCEDURE ClientManagementProcedures.GetClientInfo
    @ClientID INT
AS
BEGIN
    SELECT c.client_id, c.company_name, c.person_name, c.person_surname, c.address_id, a.street_no, a.street, a.city, a.province, a.zipcode, c.contract_id, cc.SLA, cc.duration, cc.priority, c.phone, c.email
    FROM client c
    INNER JOIN address a ON c.address_id = a.address_id
    LEFT JOIN contract cc ON c.contract_id = cc.contract_id
    WHERE c.client_id = @ClientID
END

GO
--stored procedure for to get all the jobs for a specific client
CREATE PROCEDURE ClientManagementProcedures.GetClientJobs
    @ClientID INT
AS
BEGIN
    SELECT j.job_id, j.client_id, j.service_id, s.title AS service_title, j.time_begin, j.time_end, j.status
    FROM job j
    INNER JOIN service s ON j.service_id = s.service_id
    WHERE j.client_id = @ClientID
    AND j.time_end >= GETDATE()
END
GO
----------------------------------------------------------------------------------------------------AdminPortal--------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'AdminPortalProcedures')
BEGIN
    -- Create the schema if it does not exist
    EXEC('CREATE SCHEMA AdminPortalProcedures')
END;
GO

CREATE PROCEDURE AdminPortalProcedures_InsertUsers 
		 @Username INT,
		 @Password VARCHAR(30)=NULL,
		 @Name VARCHAR(30)=NULL,
		 @Surname VARCHAR(30)=NULL,
		 @Email VARCHAR(30)=NULL,
		 @Role VARCHAR(30)=NULL,
		 @Address VARCHAR(30)=NULL,
		 @DateOfBirth DATETIME=NULL,
		 @Contact VARCHAR(30)=NULL,
		 @Street_no INT=NULL,
		 @Street VARCHAR(30)=NULL,
		 @City VARCHAR(30)=NULL,
		 @Province VARCHAR(30)=NULL,
		 @Zipcode VARCHAR(30)=NULL,
		 @UserType VARCHAR(30)=NULL,
		 @Address_id INT=NULL,
		 @Contract_id INT=NULL
		
 AS
 BEGIN
       IF @UserType='Employee'
	   BEGIN
			INSERT INTO employee(employee_id, name, surname, email, password, job_title)
			VALUES (@Username, @Name, @Surname, @Email, @Password, @Role)
	   END
	   ELSE IF @UserType='Client'
	   BEGIN 
			
			INSERT INTO client(client_id,person_name, person_surname, address_id, contract_id, phone,email, password)
			VALUES(@Username, @Name, @Surname, @Address_id, @Contract_id, @Contact, @Email, @Password)

			INSERT INTO address(street_no, street, city, province, zipcode)
			VALUES(@Street_no, @Street, @City, @Province, @Zipcode)

		    -- Get the AddressID of the inserted address
			SET @Address_id = SCOPE_IDENTITY()

			-- Update the Client table with the AddressID
			UPDATE client
			SET address_id = @Address_id
			WHERE client_id = @Username
	   END
 END

GO
			
CREATE PROCEDURE AdminPortalProcedures_DeleteUsers 
		@Username VARCHAR(30),
		@UserType VARCHAR(30)
AS
BEGIN
	IF @UserType='Employee'
	BEGIN 
		DELETE FROM employee
		WHERE employee_id=@Username
	END
	ELSE IF @UserType='Client'
	BEGIN
		DELETE FROM client
		WHERE client_id=@Username
	END	
END
GO

CREATE PROCEDURE AdminPortalProcedures_UpdateUsers 
		 @EmployeeID INT,
         @CompanyName VARCHAR(30),
		 @Password VARCHAR(30),
		 @Name VARCHAR(30),
		 @Surname VARCHAR(30),
		 @Email VARCHAR(30),
		 @Role VARCHAR(30),
		 @Address VARCHAR(30),
		 @DateOfBirth DATETIME,
		 @Phone VARCHAR(30),
		 @UserType VARCHAR(30),
		 @Address_id INT,
		 @Contract_id INT,
		 @Street_no INT,
		 @Street VARCHAR(30),
		 @City VARCHAR(30),
		 @Province VARCHAR(30),
		 @Zipcode VARCHAR(30)
AS
BEGIN 
	IF @UserType='Employee'
	BEGIN
		UPDATE employee
		SET  
			 email=@Email,
			 name=@Name,
			 surname=@Surname,
			 password=@Password,
			 job_title=@Role
		WHERE employee_id = @EmployeeID
	END
	ELSE IF @UserType='Client'
	BEGIN 
		UPDATE client
		SET 
			company_name=@CompanyName,
			person_name=@Name,
			person_surname=@Surname,
			address_id=@Address_id,
			contract_id=@Contract_id,
			phone=@Phone,
			email=@Email,
			password=@Password
		WHERE client_id=@EmployeeID
		UPDATE address
		SET
			street_no=@Street_no,
			street=@Street,
			city=@City,
			province=@Province,
			zipcode=@Zipcode
		WHERE address_id=@Address_id
	END
END
GO

CREATE PROCEDURE AdminPortalProcedures_ViewAllUsers
AS
BEGIN
    SELECT e.employee_id, e.name, e.surname, e.email, e.job_title
    FROM employee e

    UNION ALL

    SELECT c.client_id, c.person_name, c.person_surname, c.email, company_name
    FROM client c
    ORDER BY name, surname;
END;
GO

CREATE PROCEDURE AdminPortalProcedures_FilterUsers
(
    @Username VARCHAR(30)
)
AS
BEGIN
    SELECT *
    FROM (
        SELECT e.employee_id, e.name, e.surname, e.email, e.job_title
        FROM employee e
        UNION ALL
        SELECT c.client_id, c.person_name, c.person_surname, c.email, company_name
        FROM client c
    ) AS users
    WHERE users.name LIKE '%@Username%'
    ORDER BY name, surname;
END;

------------------------------------------------------------------------------ClientPortal---------------------------------------------------------------------------------------------

USE PSS;
GO

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'ClientPortalProcedures')
BEGIN
    -- Create the schema if it does not exist
    EXEC('CREATE SCHEMA ClientPortalProcedures')
END;
GO

CREATE PROCEDURE ClientPortalProcedures.GetClientsWithDetails
	@ClientID INT
AS
BEGIN
    -- Your SQL query here
    SELECT
        c.client_id,
        c.company_name,
        c.person_name,
        c.person_surname,
        a.address_id,
		a.street_no,
        a.street,
        a.city,
        a.zipcode,
        co.contract_id,
        co.duration,
        co.priority,
        co.SLA,
        c.phone,
        c.email
    FROM
        client AS c
    INNER JOIN
        address AS a ON c.address_id = a.address_id
    INNER JOIN
        contract AS co ON c.contract_id = co.contract_id
    WHERE
       c.client_id = @ClientID
END;

CREATE PROCEDURE ClientPortalProcedures.InsertClientData(
    @p_person_name VARCHAR(15),
    @p_phone VARCHAR(15),
    @p_email VARCHAR(255),
    @p_service_id INT,
    @p_service_type VARCHAR(255),
    @p_service_level INT,
    @p_description VARCHAR(255)
)
AS
BEGIN
    -- Insert the provided data into the client table
    INSERT INTO client (person_name, phone, email)
    VALUES (@p_person_name, @p_phone, @p_email);

 

    -- Insert the additional user input data into the client table
    INSERT INTO service(service_id,title, priority)
    VALUES ( @p_service_id,@p_service_type,  @p_service_level);

 

	INSERT INTO job(status)
	VALUES (@p_description)

END 