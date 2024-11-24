public class FlightsController : Controller
{
    private readonly AirportDbContext _context;

    public FlightsController(AirportDbContext context)
    {
        _context = context;
    }

    // GET: Flights
    public async Task<IActionResult> Index(string searchOrigin, string searchDestination)
    {
        var flights = from f in _context.Flights
                      select f;

        if (!String.IsNullOrEmpty(searchOrigin))
        {
            flights = flights.Where(f => f.Origin.Contains(searchOrigin));
        }

        if (!String.IsNullOrEmpty(searchDestination))
        {
            flights = flights.Where(f => f.Destination.Contains(searchDestination));
        }

        return View(await flights.ToListAsync());
    }

    // GET: Flights/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var flight = await _context.Flights.FirstOrDefaultAsync(m => m.FlightID == id);
        if (flight == null)
        {
            return NotFound();
        }

        return View(flight);
    }
}
