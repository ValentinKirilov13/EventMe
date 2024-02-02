using EventMe.Core.Contracts;
using EventMe.Core.ViewModels;
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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<EventViewModel> model = await eventServices.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            EventViewModel model = new EventViewModel()
            {
                Name = string.Empty,
                Place = string.Empty,
                End = DateTime.Now,
                Start = DateTime.Now,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EventViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await eventServices.AddAsync(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await eventServices.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            EventViewModel model = await eventServices.GetByIdAsync(id);

    }
}
