-- Criação de Tabelas
CREATE TABLE Flights (
    FlightID INT PRIMARY KEY IDENTITY(1,1),
    FlightNumber VARCHAR(10) NOT NULL UNIQUE,
    DepartureTime DATETIME NOT NULL,
    ArrivalTime DATETIME NOT NULL,
    Origin VARCHAR(100) NOT NULL,
    Destination VARCHAR(100) NOT NULL,
    Airline VARCHAR(100) NOT NULL,
    FlightStatus VARCHAR(50) NOT NULL DEFAULT 'Scheduled' -- Campo de status adicionado
);

CREATE TABLE Passengers (
    PassengerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    Phone VARCHAR(15) CHECK (LEN(Phone) >= 10)
);

CREATE TABLE Tickets (
    TicketID INT PRIMARY KEY IDENTITY(1,1),
    PassengerID INT NOT NULL,
    FlightID INT NOT NULL,
    SeatNumber VARCHAR(5) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (PassengerID) REFERENCES Passengers(PassengerID) ON DELETE CASCADE,
    FOREIGN KEY (FlightID) REFERENCES Flights(FlightID) ON DELETE CASCADE
);

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    JobTitle VARCHAR(100) NOT NULL,
    HireDate DATE NOT NULL
);

CREATE TABLE Aircrafts (
    AircraftID INT PRIMARY KEY IDENTITY(1,1),
    Model VARCHAR(50) NOT NULL,
    Capacity INT NOT NULL
);
