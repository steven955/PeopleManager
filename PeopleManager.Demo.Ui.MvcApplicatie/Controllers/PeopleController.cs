namespace PeopleManager.Demo.Ui.MvcApplicatie.Controllers;

public class PeopleController : Controller
{
    private readonly ILogger<PeopleController> _logger;

    public PeopleController(ILogger<PeopleController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}