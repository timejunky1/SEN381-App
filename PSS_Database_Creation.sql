CREATE DATABASE PSS;
CREATE TABLE employee (
	employee_id INT IDENTITY(1,1) PRIMARY KEY,
    email VARCHAR(30) UNIQUE,
    name VARCHAR(15),
    surname VARCHAR(15),
    password VARCHAR(10),
    job_title VARCHAR(30)
);
CREATE TABLE login (
    login_id INT IDENTITY(1,1) PRIMARY KEY,
    email VARCHAR(30),
    time_in DATETIME,
    time_out DATETIME,
    FOREIGN KEY (email) REFERENCES employee(email)
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
    title VARCHAR(30),
    duration INT,
    priority INT,
    cost DECIMAL(10, 2)
);
CREATE TABLE contract (
    contract_id INT IDENTITY(1,1) PRIMARY KEY,
    SLA VARCHAR(255),
    duration INT,
    priority INT,
);
CREATE TABLE contract_ref (
    ref_id INT IDENTITY(1,1) PRIMARY KEY,
	contract_id INT,
    service_id INT,
    FOREIGN KEY (service_id) REFERENCES service(service_id),
	FOREIGN KEY (contract_id) REFERENCES contract(contract_id)
);
CREATE TABLE client (
    client_id INT IDENTITY(1,1) PRIMARY KEY,
    company_name VARCHAR(50),
	person_name VARCHAR(15),
	person_surname VARCHAR(15),
    address_id INT,
    contract_id INT,
    phone VARCHAR(10),
	email VARCHAR(30) UNIQUE,
    FOREIGN KEY (address_id) REFERENCES address(address_id),
    FOREIGN KEY (contract_id) REFERENCES contract(contract_id)
);
CREATE TABLE call_log (
    call_id INT IDENTITY(1,1) PRIMARY KEY,
    employee_id INT,
    client_id INT,
    client_name VARCHAR(255),
    role VARCHAR(255),
    description TEXT,
    call_time DATETIME,
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
    FOREIGN KEY (client_id) REFERENCES client(client_id),
    FOREIGN KEY (service_id) REFERENCES service(service_id)
);
CREATE TABLE job_call_ref(
	ref_id INT IDENTITY(1,1) PRIMARY KEY,
	call_id INT,
	job_id INT,
	FOREIGN KEY (call_id) REFERENCES call_log(call_id),
    FOREIGN KEY (job_id) REFERENCES job(job_id)
);
CREATE TABLE job_employee_ref(
	ref_id INT IDENTITY(1,1) PRIMARY KEY,
	employee_id INT,
	job_id INT,
	FOREIGN KEY (job_id) REFERENCES job(job_id),
	FOREIGN KEY (employee_id) REFERENCES employee(employee_id)
);
