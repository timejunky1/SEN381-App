CREATE DATABASE PSS;
CREATE TABLE employee (
	employee_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(8) UNIQUE,
    name VARCHAR(255),
    surname VARCHAR(255),
    password VARCHAR(255),
    job_title VARCHAR(255)
);
CREATE TABLE login (
    login_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(8),
    time_in DATETIME,
    time_out DATETIME,
    FOREIGN KEY (username) REFERENCES employee(username)
);
CREATE TABLE address (
    address_id INT IDENTITY(1,1) PRIMARY KEY,
    street_no VARCHAR(255),
    street VARCHAR(255),
    city VARCHAR(255),
    province VARCHAR(255),
    zipcode VARCHAR(10)
);
CREATE TABLE service (
    service_id INT IDENTITY(1,1) PRIMARY KEY,
    title VARCHAR(255),
    duration INT,
    priority INT,
    cost DECIMAL(10, 2)
);
CREATE TABLE contract_ref (
    ref_id INT IDENTITY(1,1) PRIMARY KEY,
    service_id INT,
    FOREIGN KEY (service_id) REFERENCES service(service_id)
);
CREATE TABLE contract (
    contract_id INT IDENTITY(1,1) PRIMARY KEY,
    refID INT,
    SLA VARCHAR(255),
    duration INT,
    priority INT,
    FOREIGN KEY (refID) REFERENCES contract_ref(ref_id)
);
CREATE TABLE client (
    client_id INT IDENTITY(1,1) PRIMARY KEY,
    company_name VARCHAR(255),
    address_id INT,
    contract_id INT,
    contact_details VARCHAR(255),
    FOREIGN KEY (address_id) REFERENCES address(address_id),
    FOREIGN KEY (contract_id) REFERENCES contract(contract_id)
);
CREATE TABLE call_log (
    log_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(8),
    client_id INT,
    client_name VARCHAR(255),
    role VARCHAR(255),
    description TEXT,
    call_time DATETIME,
    FOREIGN KEY (username) REFERENCES employee(username),
    FOREIGN KEY (client_id) REFERENCES client(client_id)
);
CREATE TABLE job (
    job_id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(8),
    client_id INT,
    service_id INT,
    time_begin DATETIME,
    time_end DATETIME,
    status VARCHAR(255),
    call_id INT,
    FOREIGN KEY (username) REFERENCES employee(username),
    FOREIGN KEY (client_id) REFERENCES client(client_id),
    FOREIGN KEY (service_id) REFERENCES service(service_id),
    FOREIGN KEY (call_id) REFERENCES call_log(log_id)
);




