namespace ExercícioAspNetMvc.Controllers
{
    [Route("[controller]")]
    public class EventosController : Controller
    {
        private readonly ILogger<EventosController> _logger;

        public EventosController(ILogger<EventosController> logger)
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
            return View("Error!");
        }
    }
}