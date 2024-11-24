-- View para Voos Disponíveis
CREATE VIEW AvailableFlights AS
SELECT FlightID, FlightNumber, Origin, Destination, DepartureTime, ArrivalTime, Airline, FlightStatus
FROM Flights;
