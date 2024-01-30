using EventMe.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace EventMe.Web.Controllers
{
    public class EventController : Controller
    {
        private readonly ILogger<EventController> logger;
        private readonly IEventServices eventServices;

        public EventController(
            ILogger<EventController> _logger,
            IEventServices _eventServices)
        {
            logger = _logger;
            eventServices = _eventServices;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
