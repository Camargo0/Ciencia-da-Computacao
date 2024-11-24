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
