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