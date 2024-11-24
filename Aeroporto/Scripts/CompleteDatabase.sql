-- Criação do Banco de Dados
CREATE DATABASE CompleteAirportDB;
USE CompleteAirportDB;

-- Tabela para Voos (Flights)
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

-- Tabela para Passageiros (Passengers)
CREATE TABLE Passengers (
    PassengerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    Phone VARCHAR(15) CHECK (LEN(Phone) >= 10)
);

-- Tabela para Tickets (com relacionamento com Flights e Passengers)
CREATE TABLE Tickets (
    TicketID INT PRIMARY KEY IDENTITY(1,1),
    PassengerID INT NOT NULL,
    FlightID INT NOT NULL,
    SeatNumber VARCHAR(5) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (PassengerID) REFERENCES Passengers(PassengerID) ON DELETE CASCADE,
    FOREIGN KEY (FlightID) REFERENCES Flights(FlightID) ON DELETE CASCADE
);

-- Tabela para Funcionários (Employees)
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    JobTitle VARCHAR(100) NOT NULL,
    HireDate DATE NOT NULL
);

-- Tabela para Aeronaves (Aircrafts)
CREATE TABLE Aircrafts (
    AircraftID INT PRIMARY KEY IDENTITY(1,1),
    Model VARCHAR(50) NOT NULL,
    Capacity INT NOT NULL
);

-- Dados de Exemplo para Voos
INSERT INTO Flights (FlightNumber, DepartureTime, ArrivalTime, Origin, Destination, Airline, FlightStatus)
VALUES
('BR101', '2024-12-01 07:00', '2024-12-01 11:00', 'Rio de Janeiro', 'São Paulo', 'LATAM', 'On Time'),
('US202', '2024-12-01 09:30', '2024-12-01 14:00', 'Miami', 'New York', 'American Airlines', 'Delayed'),
('FR303', '2024-12-02 15:00', '2024-12-02 20:30', 'Paris', 'Berlin', 'Air France', 'Cancelled');

-- Dados de Exemplo para Passageiros
INSERT INTO Passengers (FirstName, LastName, Email, Phone)
VALUES
('Lionel', 'Messi', 'lionel.messi@example.com', '21987654321'),
('Cristiano', 'Ronaldo', 'cristiano.ronaldo@example.com', '3155554444');

-- Dados de Exemplo para Tickets
INSERT INTO Tickets (PassengerID, FlightID, SeatNumber, Price)
VALUES
(1, 1, '10A', 500.00),
(2, 2, '15C', 700.00);

-- Dados de Exemplo para Funcionários
INSERT INTO Employees (FirstName, LastName, JobTitle, HireDate)
VALUES
('Neymar', 'Junior', 'Pilot', '2017-05-10'),
('Kylian', 'Mbappe', 'Flight Attendant', '2019-08-15');

-- Dados de Exemplo para Aeronaves
INSERT INTO Aircrafts (Model, Capacity)
VALUES
('Embraer E190', 100),
('Airbus A380', 850);

-- View para Voos Disponíveis
CREATE VIEW AvailableFlights AS
SELECT FlightID, FlightNumber, Origin, Destination, DepartureTime, ArrivalTime, Airline, FlightStatus
FROM Flights;

-- Trigger para Monitorar Atualizações em Tickets
CREATE TRIGGER TicketUpdateLog
ON Tickets
AFTER UPDATE
AS
BEGIN
    PRINT 'A ticket has been updated.';
END;

-- Stored Procedure para Reservar um Ticket
CREATE PROCEDURE ReserveTicket
    @PassengerID INT,
    @FlightID INT,
    @SeatNumber VARCHAR(5),
    @Price DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO Tickets (PassengerID, FlightID, SeatNumber, Price)
    VALUES (@PassengerID, @FlightID, @SeatNumber, @Price);
END;

-- Stored Procedure para Atualizar Status de Voos
CREATE PROCEDURE UpdateFlightStatus
    @FlightID INT,
    @NewStatus VARCHAR(50)
AS
BEGIN
    UPDATE Flights
    SET FlightStatus = @NewStatus
    WHERE FlightID = @FlightID;
END;

-- Exemplo de Atualização de Status de Voo
EXEC UpdateFlightStatus @FlightID = 1, @NewStatus = 'Delayed';
