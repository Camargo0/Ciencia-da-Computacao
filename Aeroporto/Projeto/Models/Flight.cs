public class Flight
{
    public int FlightID { get; set; }
    public string FlightNumber { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public string Airline { get; set; }

    // Novo campo para status do voo
    public string FlightStatus { get; set; }

    public ICollection<Ticket> Tickets { get; set; }
}
