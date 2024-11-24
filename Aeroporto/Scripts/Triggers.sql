-- Trigger para Monitorar Atualizações em Tickets
CREATE TRIGGER TicketUpdateLog
ON Tickets
AFTER UPDATE
AS
BEGIN
    PRINT 'A ticket has been updated.';
END;
