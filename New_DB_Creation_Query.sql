CREATE DATABASE PSS1;
GO

USE PSS1

CREATE TABLE address (
    address_id INT IDENTITY(1,1) PRIMARY KEY,
    street_no INT,
    street VARCHAR(50),
    city VARCHAR(30),
    province VARCHAR(15),
    zipcode VARCHAR(5)
);
CREATE TABLE employee (
	employee_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(15) NOT NULL,
    surname VARCHAR(15) NOT NULL,
    job_title VARCHAR(30) NOT NULL,
	address_id INT NOT NULL,
    phone VARCHAR(10) NOT NULL,
	email VARCHAR(40) UNIQUE,
	password varchar(30),
    FOREIGN KEY (address_id) REFERENCES address(address_id)
);
CREATE TABLE service (
    service_id INT IDENTITY(1,1) PRIMARY KEY,
    title VARCHAR(30) NOT NULL,
    duration INT NOT NULL Default 30,
    priority INT NOT NULL Default 0,
    cost DECIMAL(10, 2) NOT NULL Default 0,
	availability VARCHAR(20) NOT NULL Default 'Unavailable',
	CHECK (priority BETWEEN 0 AND 5)
);
CREATE TABLE contract (
    contract_id INT IDENTITY(1,1) PRIMARY KEY,
	title VARCHAR(30),
    SLA VARCHAR(255),
    duration INT NOT NULL Default 0,
	cost DECIMAL(10, 2) NOT NULL Default 0,
    priority INT NOT NULL Default 0,
	availability VARCHAR(20) NOT NULL Default 'Unavailable',
	CHECK (priority BETWEEN 0 AND 5)
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
	name VARCHAR(15) NOT NULL,
	surname VARCHAR(15) NOT NULL,
	role VARCHAR(30) NOT NULL,
    address_id INT NOT NULL,
    contract_id INT NOT NULL,
    phone VARCHAR(10) NOT NULL,
	email VARCHAR(40) UNIQUE,
	password varchar(30),
	contract_initiation_date DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (address_id) REFERENCES address(address_id),
    FOREIGN KEY (contract_id) REFERENCES contract(contract_id)
);
CREATE TABLE login (
    login_id INT IDENTITY(1,1) PRIMARY KEY,
    email VARCHAR(40) UNIQUE,
    time_in DATETIME NOT NULL,
    time_out DATETIME NULL,
);
CREATE TABLE call_log (
    call_id INT IDENTITY(1,1) PRIMARY KEY,
    employee_id INT NOT NULL,
    client_id INT NOT NULL,
    call_time DATETIME NOT NULL,
	description VARCHAR(255),
    FOREIGN KEY (employee_id) REFERENCES employee(employee_id),
    FOREIGN KEY (client_id) REFERENCES client(client_id)
);
CREATE TABLE job (
    job_id INT IDENTITY(1,1) PRIMARY KEY,
    client_id INT NOT NULL,
    service_id INT NOT NULL,
    time_begin DATETIME NULL,
    time_end DATETIME NULL,
    status VARCHAR(15),
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

USE PSS1
GO

INSERT INTO address
values
(39819, 'Elsie Harbors', ' Port Elizabeth', ' Limpopo', '7154'),
(688, 'Maggie Ridge', ' Stellenbosch', ' Free State', '86415'),
(057, 'Josh Knolls', ' Port Elizabeth', ' Limpopo', '0077'),
(5719, 'Williamson Isle', ' Polokwane', ' North West', '31229'),
(992, 'Tyrone Islands', ' East London', ' KwaZulu-Natal', '0033'),
(6153, 'Grady Curve', ' Tshwane', ' Western Cape', '7072'),
(181, 'Pollock Branch', ' Nelspruit', ' Western Cape', '8795'),
(65526, 'Erma Way', ' Pretoria', ' KwaZulu-Natal', '54642'),
(5211, 'Tiffany Stream', ' Durban', ' Mpumalanga', '88831'),
(8349, 'Johnnie Stream', ' Cape Town', ' KwaZulu-Natal', '64213'),
(397, 'Thompson Rue', ' Port Elizabeth', ' Northern Cape', '15564'),
(23593, 'Maseko Gateway', ' Cape Town', ' KwaZulu-Natal', '24531'),
(1744, 'Lorene Roads', ' Stellenbosch', ' Free State', '41858'),
(818, 'Roy Station', ' Durban', ' North West', '92862'),
(52210, 'Tuckett Ports', ' Durban', ' North West', '10873'),
(37898, 'Jimmy Inlet', ' Pretoria', ' North West', '6588'),
(703, 'Kuhn Spur', ' Polokwane', ' North West', '78042'),
(528, 'Adcock Fall', ' Durban', ' Gauteng', '7001'),
(76735, 'Miller Streets', ' East London', ' KwaZulu-Natal', '2333'),
(8621, 'Kristie Route', ' East London', ' Mpumalanga', '8987'),
(1696, 'Munsamy Islands', ' Pretoria', ' Limpopo', ' 2926'),
(089, 'Nthabiseng Creek', ' Bloemfontein ', ' Eastern Cape', '10474'),
(497, 'Kuhn Radial', ' Polokwane', ' Mpumalanga', '67989'),
(19285, 'Matt Summit', ' Johannesburg', ' Gauteng', '94410'),
(95979, 'Timothy Drive', ' Johannesburg', ' Limpopo', '0860'),
(355, 'Sean Pike', ' Bloemfontein ', ' KwaZulu-Natal', '14458'),
(2019, 'Mphahlele Plain', ' Durban', ' KwaZulu-Natal', '2007'),
(688, 'Nolan Inlet', ' Pietermaritzburg', ' Northern Cape', '17042'),
(99475, 'Anthony Point', ' Pretoria', ' Northern Cape', '1792'),
(23480, 'Sherri Court', ' Tshwane', ' Northern Cape', '23966'),
(3472, 'Heller Summit', ' Rustenburg', ' North West', '3257'),
(784, 'Lynda Island', ' Stellenbosch', ' Gauteng', '1242'),
(7469, 'Mhlanga Village', ' Nelspruit', ' Free State', '2614'),
(0603, 'Carla Mountains', ' Rustenburg', ' Eastern Cape', '5501'),
(00738, 'Abbott Plains', ' East London', ' Northern Cape', '1356'),
(12622, 'Sara Falls', ' Pretoria', ' KwaZulu-Natal', '43120'),
(43074, 'Bromfield Isle', ' Johannesburg', ' Northern Cape', '08787'),
(7838, 'Parnell Passage', ' Pietermaritzburg', ' Northern Cape', '6483'),
(156, 'Charlotte Squares', ' Bloemfontein ', ' Gauteng', '63996'),
(4194, 'Moloi Roads', ' Kimberley', ' North West', '3579'),
(63881, 'Lynda Shores', ' Pietermaritzburg', ' Mpumalanga', '63799'),
(79562, 'Albertyn Garden', ' Pietermaritzburg', ' Western Cape', '3342'),
(67272, 'Tyler Summit', ' Bloemfontein ', ' Gauteng', '81223'),
(037, 'Juanita Flats', ' Stellenbosch', ' Northern Cape', '4383'),
(981, 'Mazibuko Oval', ' Johannesburg', ' Mpumalanga', '49014'),
(30510, 'Thompson Field', ' Rustenburg', ' Eastern Cape', '8235'),
(4048, 'Mitchell Underpass', ' Stellenbosch', ' Northern Cape', '43415'),
(47550, 'Leah Light', ' Rustenburg', ' Eastern Cape', '73764'),
(91935, 'Tsotetsi Green', ' Cape Town', ' Northern Cape', '17311'),
(45735, 'Jamie Lock', ' Port Elizabeth', ' North West', '65240'),
(3661, 'Rose Land', ' Port Elizabeth', ' KwaZulu-Natal', '4560'),
(81182, 'Horne Roads', ' Polokwane', ' Limpopo', '83813'),
(38774, 'Molefe Parkway', ' Port Elizabeth', ' Eastern Cape', '16526'),
(48769, 'Hlatshwayo Pine', ' East London', ' North West', '98434'),
(76796, 'Kempis Roads', ' Pretoria', ' Free State', '30390'),
(98957, 'Graham Way', ' Durban', ' North West', '2304'),
(9686, 'Frank Forest', ' East London', ' Eastern Cape', '7993'),
(100, 'Ntuli Stravenue', ' Johannesburg', ' Mpumalanga', '4331'),
(226, 'Mayer Corner', ' Cape Town', ' Free State', '2619'),
(60159, 'Tommy Unions', ' East London', ' North West', '3535')
GO

INSERT INTO contract
values
('Contract1','Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.', 12,300.00, 1, 'available'), --Cost = monthly
('Contract2','Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.', 12,600.00, 2, 'available'),
('Contract3','Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.', 6, 300.00, 1, 'available'),
('Contract4','Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.', 12, 200.00, 2, 'available'),
('Contract5','Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.', 12, 500.00, 3, 'available')
GO

INSERT INTO service
values
('Service1',30 , 1, 3000.00,'available'), --Cost = once off
('Service2', 60, 2, 6000.00,'available'),
('Service3', 15, 1, 3000.00,'available'),
('Service4', 30, 3, 2000.00,'available'),
('Service5', 45, 4, 3000.00,'available'),
('Service6', 120, 2, 8000.00,'available'),
('Service7', 30, 1, 3000.00,'available'),
('Service8', 120, 4, 3000.00,'available'),
('Service9', 30, 1, 3000.00,'available'),
('Service10', 45, 3, 3000.00,'available')
GO

INSERT INTO employee
values
('Josephine', 'Henderson', 'Technician', 1, '9702773512', 'josephine.henderson@example.com', 'Nosredneh&9'),
('Chloe', 'Freeburn', 'Technician', 2, '3805351451', 'chloe.freeburn@example.com', 'Nrubeerf$5'),
('Piper', 'Brock', 'Technician', 3, '6005752696', 'piper.brock@example.com', 'Kcorb!5'),
('Savannah', 'Thompson', 'Technician', 4, '9923928649', 'savannah.thompson@example.com', 'Nospmoht$8'),
('Erick', 'Boden', 'Technician', 5, '3501628006', 'erick.boden@example.com', 'Nedob$5'),
('Tom', 'Hope', 'Technician', 6, '6396009995', 'tom.hope@example.com', 'Epoh*3'),
('Kenzie', 'Walsh', 'Technician', 7, '2613932118', 'kenzie.walsh@example.com', 'Hslaw$6'),
('Lucy', 'Norris', 'Technician', 8, '4272647890', 'lucy.norris@example.com', 'Sirron*4'),
('Freya', 'Sherwood', 'Technician', 9, '7157985052', 'freya.sherwood@example.com', 'Doowrehs$5'),
('Mark', 'Parr', 'Technician', 10, '6117221713', 'mark.parr@example.com', 'Rrap@4'),
('John', 'Hopkinson', 'Technician', 11, '4847193424', 'john.hopkinson@example.com', 'Nosnikpoh*4'),
('Jenna', 'Graham', 'Technician', 12, '4816405898', 'jenna.graham@example.com', 'Maharg%5'),
('Remy', 'Norris', 'Technician', 13, '3145228527', 'remy.norris@example.com', 'Sirron^4'),
('George', 'Lyon', 'Technician', 14, '1759069605', 'george.lyon@example.com', 'Noyl^6'),
('Chadwick', 'Gates', 'Technician', 15, '4434465548', 'chadwick.gates@example.com', 'Setag^8'),
('Dakota', 'Oatway', 'Technician', 16, '2427371262', 'dakota.oatway@example.com', 'Yawtao$6'),
('Henry', 'Clarke', 'Technician', 17, '4861428674', 'henry.clarke@example.com', 'Ekralc&5'),
('Boris', 'Jefferson', 'Technician', 18, '1115464888', 'boris.jefferson@example.com', 'Nosreffej&5'),
('Karen', 'Saunders', 'Technician', 19, '3771293371', 'karen.saunders@example.com', 'Srednuas*5'),
('Emely', 'Newton', 'Technician', 20, '8882953223', 'emely.newton@example.com', 'Notwen%5'),
('Leroy', 'Baker', 'Call Employee', 21, '3525202710', 'leroy.baker@example.com', 'Rekab$5'),
('Percy', 'Gordon', 'Call Employee', 22, '9114326874', 'percy.gordon@example.com', 'Nodrog%5'),
('Jacqueline', 'Pierce', 'Call Employee', 23, '2947573083', 'jacqueline.pierce@example.com', 'Ecreip*10'),
('Hailey', 'Redwood', 'Call Employee', 24, '7457642237', 'hailey.redwood@example.com', 'Doowder%6'),
('Ema', 'Bradley', 'Call Employee', 25, '5933225608', 'ema.bradley@example.com', 'Yeldarb*3'),
('Nick', 'Stewart', 'Call Employee', 26, '4754166500', 'nick.stewart@example.com', 'Trawets@4'),
('Willow', 'Uttridge', 'Call Employee', 27, '4644849731', 'willow.uttridge@example.com', 'Egdirttu!6'),
('Makena', 'Ventura', 'Call Employee', 28, '8792951334', 'makena.ventura@example.com', 'Arutnev^6'),
('Sadie', 'Oswald', 'Call Employee', 29, '3612769339', 'sadie.oswald@example.com', 'Dlawso%5'),
('Russel', 'Harper', 'Call Employee', 30, '2391723909', 'russel.harper@example.com', 'Reprah%6'),
('Abdul', 'Walsh', 'Service Manager', 31, '7583424414', 'abdul.walsh@example.com', 'Hslaw$5'),
('Sage', 'Dyson', 'Service Manager', 32, '3715358164', 'sage.dyson@example.com', 'Nosyd^4'),
('Percy', 'Lee', 'Service Manager', 33, '6105444542', 'percy.lee@example.com', 'Eel$5'),
('Carina', 'Johnson', 'Contract Manager', 34, '5984868666', 'carina.johnson@example.com', 'Nosnhoj#6'),
('Michael', 'Blackburn', 'Contract Manager', 35, '1354932682', 'michael.blackburn@example.com', 'Nrubkcalb!7'),
('Wade', 'Needham', 'Contract Manager', 36, '8556281989', 'wade.needham@example.com', 'Mahdeen!4'),
('Teagan', 'Poole', 'Client Manager', 37, '3743378494', 'teagan.poole@example.com', 'Eloop*6'),
('Caitlyn', 'Waterson', 'Client Manager', 38, '9518153321', 'caitlyn.waterson@example.com', 'Nosretaw^7'),
('Ramon', 'Coll', 'Client Manager', 39, '8544306451', 'ramon.coll@example.com', 'Lloc@5'),
('Brad', 'Davies', 'Admin', 40, '9674365871', 'brad.davies@example.com', 'Seivad#4')
GO

INSERT INTO client
values
('Company 41','Chuck', 'Blackwall', 'It Manager', 41, 1, '9575172013', 'chuck.blackwall@example.com', 'Llawkcalb&5', GETDATE()),
('Company 42','Domenic', 'Abbey', 'Technical', 42, 4, '8094997862', 'domenic.abbey@example.com', 'Yebba$7', GETDATE()),
('Company 43','Tess', 'Pearce', 'Technical', 43, 1, '4335279445', 'tess.pearce@example.com', 'Ecraep*4', GETDATE()),
('Company 44','Eve', 'Aldridge', 'Technical', 44, 2, '6914367677', 'eve.aldridge@example.com', 'Egdirdla*3', GETDATE()),
('Company 45','Kieth', 'Mccormick', 'It Manager', 45, 4, '6718066514', 'kieth.mccormick@example.com', 'Kcimroccm@5', GETDATE()),
('Company 46','Aiden', 'Windsor', 'It Manager', 46, 1, '2276675618', 'aiden.windsor@example.com', 'Rosdniw!5', GETDATE()),
('Company 47','Rebecca', 'Tutton', 'Technical', 47, 1, '1121624831', 'rebecca.tutton@example.com', 'Nottut&7', GETDATE()),
('Company 48','Hayden', 'Flynn', 'Technical', 48, 4, '7557849314', 'hayden.flynn@example.com', 'Nnylf&6', GETDATE()),
('Company 49','Denny', 'Lane', 'Technical', 49, 1, '7898744443', 'denny.lane@example.com', 'Enal&5', GETDATE()),
('Company 50','Madelyn', 'Attwood', 'It Manager', 50, 2, '6093878242', 'madelyn.attwood@example.com', 'Doowtta@7', GETDATE()),
('Company 51','Trisha', 'Clifford', 'It Manager', 51, 4, '9745998794', 'trisha.clifford@example.com', 'Droffilc!6', GETDATE()),
('Company 52','Catherine', 'Torres', 'It Manager', 52, 2, '2137998398', 'catherine.torres@example.com', 'Serrot^9', GETDATE()),
('Company 53','Ron', 'Spencer', 'Technical', 53, 2, '3754832672', 'ron.spencer@example.com', 'Recneps%3', GETDATE()),
('Company 54','Tania', 'Atkinson', 'Technical', 54, 4, '5405296003', 'tania.atkinson@example.com', 'Nosnikta$5', GETDATE()),
('Company 55','David', 'Rowlands', 'It Manager', 55, 2, '9456121213', 'david.rowlands@example.com', 'Sdnalwor!5', GETDATE()),
('Company 56','Benjamin', 'Baker', 'Technical', 56, 2, '9922346789', 'benjamin.baker@example.com', 'Rekab&8', GETDATE()),
('Company 57','Rosalee', 'Atkinson', 'It Manager', 57, 2, '3117278772', 'rosalee.atkinson@example.com', 'Nosnikta*7', GETDATE()),
('Company 58','Martin', 'Gordon', 'It Manager', 58, 3, '2356264540', 'martin.gordon@example.com', 'Nodrog!6', GETDATE()),
('Company 59','Barney', 'Gilmour', 'It Manager', 59, 4, '2928426259', 'barney.gilmour@example.com', 'Ruomlig@6', GETDATE()),
('Company 60','Matt', 'Farmer', 'It Manager', 60, 1, '8337894118', 'matt.farmer@example.com', 'Remraf*4', GETDATE())


INSERT INTO job
values
(9, 3, '2023-02-17 09:14:20', '2023-02-17 10:14:20', 'Finished', 'notes'),
(1, 7, '2023-08-21 15:04:18', '2023-08-21 16:04:18', 'Finished', 'notes'),
(7, 9, '2023-08-24 13:47:06', '2023-08-24 14:47:06', 'Canceled', 'notes'),
(8, 10, '2023-08-09 03:47:20', '2023-08-09 04:47:20', 'Finished', 'notes'),
(8, 2, '2023-07-19 05:06:18', '2023-07-19 06:06:18', 'Canceled', 'notes'),
(4, 3, '2023-05-09 02:22:07', '2023-05-09 03:22:07', 'Canceled', 'notes'),
(2, 9, '2023-06-13 03:52:14', '2023-06-13 04:52:14', 'Finished', 'notes'),
(1, 10, '2023-03-31 12:56:08', '2023-03-31 13:56:08', 'Canceled', 'notes'),
(5, 6, '2023-04-06 21:26:34', '2023-04-06 22:26:34', 'Canceled', 'notes'),
(1, 9, '2023-04-15 06:33:35', '2023-04-15 07:33:35', 'Canceled', 'notes'),
(7, 10, '2023-05-11 11:07:11', '2023-05-11 12:07:11', 'Canceled', 'notes'),
(6, 6, '2023-08-21 10:59:20', '2023-08-21 11:59:20', 'Finished', 'notes'),
(10, 1, '2023-05-24 12:54:32', '2023-05-24 13:54:32', 'Canceled', 'notes'),
(5, 8, '2023-02-01 23:39:20', '2023-02-02 00:39:20', 'Canceled', 'notes'),
(2, 6, '2023-08-08 16:53:28', '2023-08-08 17:53:28', 'Canceled', 'notes'),
(8, 2, '2023-03-10 07:58:45', '2023-03-10 08:58:45', 'Canceled', 'notes'),
(3, 5, '2023-01-03 20:18:26', '2023-01-03 21:18:26', 'Canceled', 'notes'),
(7, 6, '2023-06-15 22:20:26', '2023-06-15 23:20:26', 'Finished', 'notes'),
(1, 4, '2023-04-11 12:37:24', '2023-04-11 13:37:24', 'Canceled', 'notes'),
(8, 3, '2023-04-22 06:38:26', '2023-04-22 07:38:26', 'Canceled', 'notes'),
(6, 4, '2023-10-09 00:43:24', '2023-10-09 01:43:24', 'Finished', 'notes'),
(4, 3, '2023-10-01 02:05:06', '2023-10-01 03:05:06', 'Finished', 'notes'),
(2, 1, '2023-10-05 14:47:15', '2023-10-05 15:47:15', 'Finished', 'notes'),
(4, 5, '2023-01-20 17:53:41', '2023-01-20 18:53:41', 'Canceled', 'notes'),
(8, 10, '2023-03-05 23:02:45', '2023-03-06 00:02:45', 'Finished', 'notes'),
(10, 4, '2023-05-28 22:42:21', '2023-05-28 23:42:21', 'Canceled', 'notes'),
(9, 6, '2023-05-07 10:49:53', '2023-05-07 11:49:53', 'Finished', 'notes'),
(5, 5, '2023-04-07 22:28:15', '2023-04-07 23:28:15', 'Finished', 'notes'),
(9, 8, '2023-02-22 08:09:40', '2023-02-22 09:09:40', 'Finished', 'notes'),
(7, 5, '2023-05-10 05:47:19', '2023-05-10 06:47:19', 'Finished', 'notes'),
(4, 7, '2023-01-03 10:43:20', '2023-01-03 11:43:20', 'Canceled', 'notes'),
(5, 9, '2023-09-05 09:47:36', '2023-09-05 10:47:36', 'Finished', 'notes'),
(3, 2, '2023-09-09 17:53:16', '2023-09-09 18:53:16', 'Canceled', 'notes'),
(4, 2, '2023-06-05 15:03:52', '2023-06-05 16:03:52', 'Canceled', 'notes'),
(8, 8, '2023-07-17 01:12:38', '2023-07-17 02:12:38', 'Canceled', 'notes'),
(5, 9, '2023-03-15 00:15:39', '2023-03-15 01:15:39', 'Finished', 'notes'),
(4, 9, '2023-02-18 03:31:04', '2023-02-18 04:31:04', 'Finished', 'notes'),
(10, 7, '2023-04-10 23:54:58', '2023-04-11 00:54:58', 'Finished', 'notes'),
(10, 10, '2023-10-10 20:53:26', '2023-10-10 21:53:26', 'Finished', 'notes'),
(6, 3, '2023-05-30 06:10:34', '2023-05-30 07:10:34', 'Canceled', 'notes')
GO
SELECT * FROM job
INSERT INTO call_log
values
(23, 7, '2023-10-14 15:33:24', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(23, 14, '2023-10-18 14:44:26', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(19, 5, '2023-10-01 12:40:28', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(16, 8, '2023-10-16 20:44:42', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(20, 17, '2023-10-25 22:38:27', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(19, 1, '2023-10-16 04:25:21', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(22, 14, '2023-10-04 18:09:03', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(23, 18, '2023-10-20 05:38:00', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(18, 18, '2023-10-03 15:31:36', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(17, 17, '2023-10-18 04:15:40', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(21, 20, '2023-10-19 23:59:51', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(20, 3, '2023-11-01 06:45:23', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(22, 19, '2023-11-01 12:19:28', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(19, 15, '2023-10-08 08:16:49', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(20, 2, '2023-10-16 05:52:44', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(23, 19, '2023-10-06 00:53:09', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(17, 11, '2023-10-26 21:18:09', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(21, 16, '2023-10-27 17:57:02', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(21, 7, '2023-10-20 23:57:08', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(19, 18, '2023-10-30 04:17:08', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(16, 18, '2023-10-22 10:33:17', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(19, 11, '2023-10-25 23:57:37', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(17, 13, '2023-10-23 07:39:27', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(17, 4, '2023-10-18 23:15:16', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(21, 17, '2023-10-01 11:13:45', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(21, 16, '2023-10-03 05:22:37', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(21, 6, '2023-10-14 19:06:57', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(16, 12, '2023-10-31 22:40:30', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(17, 4, '2023-10-31 03:10:33', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(21, 16, '2023-10-20 22:08:23', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(17, 12, '2023-10-19 05:48:42', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(21, 14, '2023-10-21 19:10:52', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(16, 18, '2023-10-06 01:10:07', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(20, 7, '2023-10-21 00:10:51', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(19, 15, '2023-10-05 11:23:26', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(17, 7, '2023-10-27 20:26:26', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(17, 1, '2023-10-04 02:19:47', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(23, 3, '2023-10-26 02:58:31', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(18, 16, '2023-10-27 16:00:25', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(18, 13, '2023-10-13 22:14:25', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(16, 1, '2023-10-12 21:09:31', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(22, 7, '2023-10-14 05:24:59', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(20, 13, '2023-10-25 09:56:04', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(23, 16, '2023-10-06 21:59:03', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(18, 4, '2023-10-24 23:48:23', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(22, 4, '2023-10-20 11:36:09', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(19, 6, '2023-10-21 09:39:42', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(21, 20, '2023-10-02 09:46:35', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(21, 9, '2023-10-18 17:15:25', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(20, 2, '2023-10-28 02:15:45', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(23, 13, '2023-10-01 04:25:52', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(22, 17, '2023-10-09 18:25:13', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(16, 15, '2023-10-26 17:25:53', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(19, 15, '2023-10-29 14:16:43', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(20, 15, '2023-10-14 17:39:19', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(19, 16, '2023-10-26 23:44:25', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(18, 13, '2023-10-28 18:08:37', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(22, 10, '2023-10-02 04:41:08', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(16, 10, '2023-10-08 04:14:23', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.'),
(16, 7, '2023-10-04 17:08:17', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.')


INSERT INTO contract_ref
values
(1,3),
(1,4),
(1,5),
(1,6),
(1,8),
(1,9),
(2,1),
(2,3),
(2,4),
(2,8),
(2,10),
(3,1),
(3,3),
(3,4),
(3,6),
(3,8),
(3,9),
(4,5),
(4,6),
(4,7),
(4,8),
(4,10),
(5,1),
(5,2),
(5,3),
(5,5),
(5,8)


INSERT INTO job_call_ref
values
(52,1),
(37,1),
(55,1),
(4,2),
(45,2),
(7,2),
(56,3),
(13,3),
(46,3),
(18,4),
(22,4),
(23,4),
(54,5),
(30,5),
(40,6),
(19,6),
(60,6),
(38,7),
(33,7),
(22,7),
(56,8),
(13,8),
(46,8),
(19,9),
(36,9),
(39,9),
(25,10),
(60,10),
(53,10),
(18,11),
(42,11),
(55,11),
(51,12),
(19,12),
(14,12),
(1,13),
(59,13),
(29,13),
(18,14),
(43,14),
(60,14),
(16,15),
(35,15),
(47,15),
(57,16),
(51,16),
(30,16),
(26,17),
(18,17),
(55,17),
(48,18),
(25,18),
(18,18),
(24,19),
(32,19),
(5,19),
(50,20),
(12,20),
(7,20),
(26,21),
(4,21),
(18,22),
(5,22),
(49,23),
(23,23),
(17,24),
(6,24),
(60,25),
(54,25),
(18,26),
(53,26),
(9,27),
(34,27),
(8,28),
(43,28),
(8,29),
(9,29),
(34,30),
(3,30),
(10,31),
(28,31),
(32,32),
(20,32),
(57,33),
(31,33),
(51,34),
(54,34),
(51,35),
(14,35),
(40,36),
(23,36),
(57,37),
(4,37),
(9,38),
(30,38),
(28,39),
(23,39),
(8,40),
(59,40)

INSERT INTO job_employee_ref
values
(8,1),
(17,1),
(2,1),
(17,2),
(12,2),
(15,2),
(3,3),
(12,3),
(6,3),
(1,4),
(18,4),
(20,4),
(16,5),
(10,5),
(6,5),
(11,6),
(15,6),
(8,7),
(19,7),
(5,7),
(16,8),
(17,8),
(10,8),
(1,9),
(3,9),
(9,9),
(11,10),
(9,10),
(19,10),
(16,11),
(18,11),
(11,11),
(9,12),
(18,12),
(7,12),
(18,13),
(12,13),
(5,13),
(2,14),
(11,14),
(6,14),
(1,15),
(13,15),
(8,16),
(12,16),
(7,16),
(16,17),
(3,17),
(4,17),
(18,18),
(19,18),
(6,18),
(4,19),
(6,19),
(14,19),
(19,20),
(15,20),
(7,20),
(1,21),
(9,21),
(1,22),
(14,22),
(20,23),
(5,23),
(8,24),
(5,24),
(12,25),
(7,25),
(2,26),
(6,26),
(9,27),
(18,27),
(1,28),
(5,28),
(17,29),
(13,29),
(3,30),
(6,30),
(9,31),
(11,31),
(1,32),
(10,32),
(16,33),
(1,33),
(17,34),
(2,34),
(16,35),
(20,35),
(12,36),
(15,36),
(9,37),
(11,37),
(8,38),
(2,38),
(17,39),
(2,39),
(17,40),
(5,40)

GO

--loginProcedures
EXECUTE('CREATE SCHEMA loginProcedures')
GO

CREATE PROCEDURE loginProcedures.InsertLogin
    @email VARCHAR(30),
    @timeIn DATETIME
AS
BEGIN
    INSERT INTO login (email, time_in)
    VALUES (@email, @timeIn);
END;
GO

EXEC loginProcedures.InsertLogin @email = 'josephine.henderson@example.com', @timeIn = '2023-02-17 09:14:20'
GO

CREATE PROCEDURE loginProcedures.Logout
    @email VARCHAR(30)
AS
BEGIN
	DECLARE @id INT
	BEGIN TRY
		SELECT TOP 1 @id = login_id 
		FROM login 
		WHERE email = @email
		ORDER BY login_id DESC

		UPDATE login
		SET time_out = GETDATE()
		WHERE login_id = @id
	END TRY
	BEGIN CATCH
	END CATCH
END;
GO

CREATE PROCEDURE loginProcedures.ResetPassword
	@email VARCHAR(30),
	@oldPassword VARCHAR(30),
	@newPassword VARCHAR(30)
AS
BEGIN
	IF @email IN (SELECT email FROM client)
		UPDATE client
		SET password = @newPassword
		WHERE email = @email AND password = @oldPassword
	ELSE
		UPDATE employee
		SET password = @newPassword
		WHERE email = @email AND password = @oldPassword
END;
GO

CREATE PROCEDURE loginProcedures.AuthenticateUser
    @username NVARCHAR(30),
    @password VARCHAR(10),
    @userRole VARCHAR(50) = '' OUTPUT,
	@result INT = 0 OUTPUT
AS
BEGIN
    DECLARE @hashedPassword VARCHAR(100)
	DECLARE @date DATETIME
	SET @date = GETDATE()

    SELECT @userRole = job_title,
           @hashedPassword = [password]
    FROM employee
    WHERE email = @username

    IF @hashedPassword IS NOT NULL
    BEGIN
        IF @password = @hashedPassword
        BEGIN
            SET @result = 1
			EXEC loginProcedures.InsertLogin @email = @username, @timeIn = @date
        END
		ELSE
		BEGIN
			SET @result = 0
			SET @userRole = 'Invalid'
		END
    END 
END
GO

CREATE PROCEDURE loginProcedures.GetUserInformation 
	@username VARCHAR(30),
	@name VARCHAR(15) = '' OUTPUT,
	@surname VARCHAR(15) = '' OUTPUT,
	@role VARCHAR(30) = '' OUTPUT,
	@userId INT = 0 OUTPUT

AS
BEGIN
	SELECT @name = name, @surname = surname, @role = job_title, @userId = employee_id FROM employee
	WHERE email = @username

	IF @username NOT IN (SELECT email FROM employee)
		SELECT @name = name, @surname = surname, @role = 'Client', @userId = client_id FROM client
		WHERE email = @username
END		
GO

--GetAddress
CREATE PROCEDURE GetAddress
    @addressId INT,
    @streetNo INT = 0 OUTPUT,
    @street VARCHAR(50) = '' OUTPUT,
    @city VARCHAR(30) = '' OUTPUT,
    @province VARCHAR(15) = '' OUTPUT,
    @zipcode VARCHAR(4) = '' OUTPUT
AS
BEGIN
    SELECT @streetNo = street_no,
           @street = street,
           @city = city,
           @province = province,
           @zipcode = zipcode
    FROM address
    WHERE address_id = @addressId;
END;
GO

CREATE PROCEDURE InsertAddress
    @streetNo INT,
    @street VARCHAR(50),
    @city VARCHAR(30),
    @province VARCHAR(15),
    @zipcode VARCHAR(4)
AS
BEGIN
	INSERT INTO address
    VALUES( @streetNo, @street,@city,@province,@zipcode)

	Select MAX(address_id) 
	from address
END;
GO

CREATE PROCEDURE UpdateAddress
	@addressId INT,
    @streetNo INT,
    @street VARCHAR(50),
    @city VARCHAR(30),
    @province VARCHAR(15),
    @zipcode VARCHAR(4)
AS
BEGIN
	UPDATE address
	SET street_no = @streetNo,
	    street = @street,
		city = @city,
		province = @province,
		zipcode = @zipcode
    WHERE address_id = @addressId

	Select MAX(address_id) 
	from address
END;
GO

create procedure DeleteAddress @addressId INT
AS
BEGIN
	DELETE FROM address
	WHERE address_id = @addressid
END
GO

-- employeeProcedures
EXECUTE('CREATE SCHEMA employeeProcedures')
GO

CREATE PROCEDURE employeeProcedures.InsertEmployee
(
    @name VARCHAR(15),
    @surname VARCHAR(15),
    @role VARCHAR(30),
    @phone VARCHAR(10),
	@email VARCHAR(30),
	@streetNo INT,
    @street VARCHAR(50),
    @city VARCHAR(30),
    @province VARCHAR(15),
    @zipcode VARCHAR(5)
)
AS
BEGIN
		DECLARE @addressId INT

		INSERT INTO address(
		street_no,
		street,
		city,
		province,
		zipcode)
		VALUES(
		@streetNo,
		@street,
		@city,
		@province,
		@zipcode
		)

		SET @addressId = SCOPE_IDENTITY()

		INSERT INTO employee(
		name,
		surname,
		job_title,
		address_id,
		phone,
		email)
		VALUES(
		@name,
		@surname,
		@role,
		@addressId,
		@phone,
		@email
		)
END
GO


CREATE PROCEDURE employeeProcedures.UpdateEmployee
    @employeeId INT,
    @name VARCHAR(15),
    @surname VARCHAR(15),
    @role VARCHAR(30),
    @phone VARCHAR(10),
    @email VARCHAR(30),
	@streetNo INT,
    @street VARCHAR(50),
    @city VARCHAR(30),
    @province VARCHAR(15),
    @zipcode VARCHAR(5)
AS
BEGIN
	DECLARE @addressId INT
	DECLARE @oldAddressId INT
	SELECT @oldAddressId = address_id FROM employee WHERE employee_id = @employeeId

	INSERT INTO address(
		street_no,
		street,
		city,
		province,
		zipcode)
		VALUES(
		@streetNo,
		@street,
		@city,
		@province,
		@zipcode
		)

	SET @addressId = SCOPE_IDENTITY()

    UPDATE employee
    SET name = @name,
        surname = @surname,
        job_title = @role,
        address_id = @addressId,
        phone = @phone,
        email = @email
    WHERE employee_id = @employeeId;

	DELETE FROM address WHERE address_id = @oldAddressId
END;
GO

CREATE PROCEDURE employeeProcedures.GetEmployee
    @employeeId INT
AS
BEGIN
	SELECT employee_id, name, surname, job_title, phone, email, street_no, street, city, province, zipcode
	FROM employee
	INNER JOIN address ON address.address_id = employee.address_id
	WHERE employee_id = @employeeId
END;
GO

CREATE PROCEDURE employeeProcedures.DeleteEmployee
    @employeeId INT
AS
BEGIN
	DECLARE @addressId INT
	SELECT @addressId = address_id FROM employee WHERE employee_id = @employeeId

    DELETE FROM employee
    WHERE employee_id = @employeeId;

	DELETE FROM address
	WHERE address_id = @addressId
END;
GO

CREATE PROCEDURE employeeProcedures.GetEmployees
AS
BEGIN
	SELECT employee_id, name, surname, job_title, phone, email, street_no, street, city, province, zipcode
	FROM employee
	INNER JOIN address ON address.address_id = employee.address_id
END;
GO
-- clientProcedures
EXECUTE('CREATE SCHEMA clientProcedures')
GO

CREATE PROCEDURE clientProcedures.InsertClient
(
    @companyName VARCHAR(50),
	@name VARCHAR(15),
	@surname VARCHAR(15),
	@role VARCHAR(30),
    @contractId INT,
    @phone VARCHAR(10),
	@email VARCHAR(30),
	@contractInitiationDate DATETIME,
	@streetNo INT,
    @street VARCHAR(50),
    @city VARCHAR(30),
    @province VARCHAR(15),
    @zipcode VARCHAR(4)
)
AS
BEGIN
		DECLARE @addressId INT

		INSERT INTO address(
		street_no,
		street,
		city,
		province,
		zipcode)
		VALUES(
		@streetNo,
		@street,
		@city,
		@province,
		@zipcode
		)

		SET @addressId = SCOPE_IDENTITY()

		INSERT INTO client(
		company_name,
		name,
		surname,
		role,
		contract_id,
		address_id,
		phone,
		email,
		contract_initiation_date)
		VALUES(
		@companyName,
		@name,
		@surname,
		@role,
		@contractId,
		@addressId,
		@phone,
		@email,
		@contractInitiationDate
		)
END
GO

CREATE PROCEDURE clientProcedures.UpdateClient
    @clientId INT,
    @companyName VARCHAR(50),
    @name VARCHAR(15),
    @surname VARCHAR(15),
    @role VARCHAR(30),
    @contractId INT,
    @phone VARCHAR(10),
    @email VARCHAR(30),
    @contractInitiationDate DATETIME,
	@streetNo INT,
	@street VARCHAR(50),
	@city VARCHAR(30),
	@province VARCHAR(15),
	@zipcode VARCHAR(4)
AS
BEGIN
	DECLARE @addressId INT
	DECLARE @oldAddressId INT
	SELECT @oldAddressId = address_id FROM client WHERE client_id = @clientId

	INSERT INTO address(
		street_no,
		street,
		city,
		province,
		zipcode)
		VALUES(
		@streetNo,
		@street,
		@city,
		@province,
		@zipcode
		)

	SET @addressId = SCOPE_IDENTITY()

    UPDATE client
    SET company_name = @companyName,
        name = @name,
        surname = @surname,
        role = @role,
        address_id = @addressId,
        contract_id = @contractId,
        phone = @phone,
        email = @email,
        contract_initiation_date = @contractInitiationDate
    WHERE client_id = @clientId;

	DELETE FROM address
	WHERE address_id = @oldAddressId
END;
GO

CREATE PROCEDURE clientProcedures.GetClient
    @clientId INT
AS
BEGIN
	SELECT client_id, company_name, name, surname, role, contract_id, phone, email,contract_initiation_date, street_no, street, city, province, zipcode
	FROM client
	INNER JOIN address ON address.address_id = client.address_id
	WHERE client_id = @clientId
END;
GO

CREATE PROCEDURE clientProcedures.DeleteClient
    @clientId INT
AS
BEGIN
	DECLARE @addressId INT
	SELECT @addressId = address_id FROM client WHERE client_id = @clientId

    DELETE FROM client
    WHERE client_id = @clientId;

	DELETE FROM address
	WHERE address_id = @addressId
END;
GO

CREATE PROCEDURE clientProcedures.GetClients
AS
BEGIN
	SELECT client_id, company_name, name, surname, role, contract_id, phone, email,contract_initiation_date, street_no, street, city, province, zipcode
	FROM client
	INNER JOIN address ON address.address_id = client.address_id
END;
GO

-- serviceprocedures
EXECUTE('CREATE SCHEMA serviceProcedures')
GO

CREATE PROCEDURE serviceProcedures.InsertService
    @title VARCHAR(30),
    @duration INT = 30,
    @priority INT = 0,
    @cost DECIMAL(10, 2) = 0,
    @availability VARCHAR(20) = 'Unavailable'
AS
BEGIN
    INSERT INTO service (title, duration, priority, cost, availability)
    VALUES (@title, @duration, 
    CASE 
        WHEN @priority < 0 THEN 0 
        WHEN @priority > 5 THEN 5 
        ELSE @priority 
    END, 
    @cost, @availability);
END;
GO

CREATE PROCEDURE serviceProcedures.UpdateService
    @serviceId INT,
    @title VARCHAR(30),
    @duration INT,
    @priority INT,
    @cost DECIMAL(10, 2),
    @availability VARCHAR(20)
AS
BEGIN
    UPDATE service
    SET title = @title,
        duration = @duration,
        priority = @priority,
        cost = @cost,
        availability = @availability
    WHERE service_id = @serviceId;
END;
GO

CREATE PROCEDURE serviceProcedures.DeleteService
    @serviceId INT
AS
BEGIN
	DELETE FROM contract_ref
	WHERE service_id = @serviceId

	DELETE FROM service
	WHERE service_id = @serviceId
END;
GO

CREATE PROCEDURE serviceProcedures.GetService
    @serviceId INT
AS
BEGIN
    SELECT * FROM service
    WHERE service_id = @serviceId;
END;
GO

CREATE PROCEDURE serviceProcedures.GetServices
AS
BEGIN
	SELECT * FROM service
END;
GO

-- callProcedures
EXECUTE('CREATE SCHEMA callProcedures')
GO

CREATE PROCEDURE callProcedures.InsertCallLog
    @employeeId INT,
    @clientId INT,
    @callTime DATETIME,
	@description VARCHAR(255)
AS
BEGIN
    INSERT INTO call_log (employee_id, client_id, call_time, description)
    VALUES (@employeeId, @clientId, @callTime, @description);
END;
GO

CREATE PROCEDURE callProcedures.GetCall
    @id INT
AS
BEGIN
    SELECT * FROM call_log
    WHERE employee_id = @id;
END;
GO

CREATE PROCEDURE callProcedures.GetCalls
AS
BEGIN
	SELECT * FROM call_log
END
GO
--contractProcedures
EXECUTE('CREATE SCHEMA contractProcedures')
GO

CREATE PROCEDURE contractProcedures.InsertContract
    @title VARCHAR(30),
    @SLA VARCHAR(255),
    @duration INT = 0,
    @cost DECIMAL(10, 2) = 0,
    @priority INT = 0,
    @availability VARCHAR(20) = 'Unavailable'
AS
BEGIN
    INSERT INTO contract (title, SLA, duration, cost, priority, availability)
    VALUES (@title, @SLA, 
    CASE 
        WHEN @duration < 0 THEN 0 
        ELSE @duration 
    END, 
    @cost, 
    CASE 
        WHEN @priority < 0 THEN 0 
        WHEN @priority > 5 THEN 5 
        ELSE @priority 
    END, 
    @availability);
END;
GO

CREATE PROCEDURE contractProcedures.UpdateContract
    @contractId INT,
    @title VARCHAR(30),
    @SLA VARCHAR(255),
    @duration INT,
    @cost DECIMAL(10, 2),
    @priority INT,
    @availability VARCHAR(20)
AS
BEGIN
    UPDATE contract
    SET title = @title,
        SLA = @SLA,
        duration = @duration,
        cost = @cost,
        priority = @priority,
        availability = @availability
    WHERE contract_id = @contractId;
END;
GO

CREATE PROCEDURE contractProcedures.DeleteContract
    @contractId INT
AS
BEGIN
	DELETE FROM contract_ref
	WHERE contract_id = @contractId

	DELETE FROM contract
	WHERE contract_id = @contractId
END;
GO

CREATE PROCEDURE contractProcedures.GetContract
    @contractId INT
AS
BEGIN
    SELECT * FROM contract
    WHERE contract_id = @contractId;
END;
GO

CREATE PROCEDURE contractProcedures.GetContracts
AS
BEGIN
	SELECT * FROM contract
END;
GO
--jobProcedures
EXECUTE('CREATE SCHEMA jobProcedures')
GO

CREATE PROCEDURE jobProcedures.InsertJob
    @clientId INT,
    @serviceId INT,
    @timeBegin DATETIME = NULL,
    @timeEnd DATETIME = NULL,
    @status VARCHAR(15),
    @notes VARCHAR(255)
AS
BEGIN
    INSERT INTO job (client_id, service_id, time_begin, time_end, status, notes)
    VALUES (@clientId, @serviceId, @timeBegin, @timeEnd, @status, @notes);
END;
GO

CREATE PROCEDURE jobProcedures.UpdateJob
    @jobId INT,
    @clientId INT,
    @serviceId INT,
    @timeBegin DATETIME,
    @timeEnd DATETIME,
    @status VARCHAR(15),
    @notes VARCHAR(255)
AS
BEGIN
    UPDATE job
    SET client_id = @clientId,
        service_id = @serviceId,
        time_begin = @timeBegin,
        time_end = @timeEnd,
        status = @status,
        notes = @notes
    WHERE job_id = @jobId;
END;
GO

CREATE PROCEDURE jobProcedures.DeleteJob
    @jobId INT
AS
BEGIN
	DELETE FROM job_employee_ref
	WHERE job_id = @jobId

	DELETE FROM job_call_ref
	WHERE job_id = @jobId

	DELETE FROM job
	WHERE job_id = @jobId
END;
GO

CREATE PROCEDURE jobProcedures.GetJob
    @jobId INT
AS
BEGIN
    SELECT * FROM job
    WHERE job_id = @jobId;
END;
GO

CREATE PROCEDURE jobProcedures.GetJobs
AS
BEGIN
	SELECT * FROM job
END;
GO

--referenceProcedures
EXECUTE('CREATE SCHEMA referenceProcedures')
GO

CREATE PROCEDURE referenceProcedures.InsertContractRef
    @contractId INT,
    @serviceId INT
AS
BEGIN
    INSERT INTO contract_ref (contract_id, service_id)
    VALUES (@contractId, @serviceId);
END;
GO

CREATE PROCEDURE referenceProcedures.DeleteContractRef
    @contractId INT = 0,
    @serviceId INT = 0
AS
BEGIN
    DELETE FROM contract_ref
	WHERE contract_id = @contractId OR service_id = @serviceId
END;
GO

CREATE PROCEDURE referenceProcedures.GetContractRef
    @contractId INT = 0,
    @serviceId INT = 0
AS
BEGIN
	IF @contractId != 0
		SELECT DISTINCT service_id FROM contract_ref
		WHERE contract_id = @contractId
	ELSE
		SELECT DISTINCT contract_id FROM contract_ref
		WHERE service_id = @serviceId
END;
GO


CREATE PROCEDURE referenceProcedures.InsertJobCallRef
    @callId INT,
    @jobId INT
AS
BEGIN
    INSERT INTO job_call_ref (call_id, job_id)
    VALUES (@callId, @jobId);
END;
GO

CREATE PROCEDURE referenceProcedures.DeleteJobCallRef
    @callId INT,
    @jobId INT
AS
BEGIN
    DELETE FROM job_call_ref
	WHERE call_id = @callId OR job_id = @jobId
END;
GO

CREATE PROCEDURE referenceProcedures.GetJobCallRef
    @jobId INT = 0,
    @callId INT = 0
AS
BEGIN
    IF @callId != 0
		SELECT DISTINCT job_id FROM job_call_ref
		WHERE call_id = @callId
	ELSE
		SELECT DISTINCT call_id FROM job_call_ref
		WHERE job_id = @jobId
END;
GO

CREATE PROCEDURE referenceProcedures.InsertJobEmployeeRef
    @employeeId INT,
    @jobId INT
AS
BEGIN
    INSERT INTO job_employee_ref (employee_id, job_id)
    VALUES (@employeeId, @jobId);
END;
GO

CREATE PROCEDURE referenceProcedures.DeleterJobEmployeeRef
    @employeeId INT,
    @jobId INT
AS
BEGIN
    DELETE FROM job_employee_ref
	WHERE job_id = @jobId OR employee_id = @employeeId
END;
GO

CREATE PROCEDURE referenceProcedures.GetJobEmployeeRef
    @jobId INT = 0,
    @employeeId INT = 0
AS
BEGIN
    IF @jobId != 0
		SELECT DISTINCT employee_id FROM job_employee_ref
		WHERE job_id = job_id
	ELSE
		SELECT DISTINCT job_id FROM job_employee_ref
		WHERE employee_id = @employeeId
END;
GO
-------------------------------------------------------------------
