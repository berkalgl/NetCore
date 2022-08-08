using DILifeCycle.Models;
using DILifeCycle.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DILifeCycle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingletonGuidGenerator _singletonGuidGenerator;
        private readonly IScopedGuidGenerator _scopedGuidGenerator;
        private readonly ITransientGuidGenerator _transientGuidGenerator;
        private readonly GuidService _guidService;

        public HomeController(ILogger<HomeController> logger, ISingletonGuidGenerator singletonGuidGenerator, ITransientGuidGenerator transientGuidGenerator, IScopedGuidGenerator scopedGuidGenerator, GuidService guidService)
        {
            _logger = logger;
            _singletonGuidGenerator = singletonGuidGenerator;
            _scopedGuidGenerator = scopedGuidGenerator;
            _transientGuidGenerator = transientGuidGenerator;
            _guidService = guidService;
        }

        public IActionResult Index()
        {
            ViewBag.Singleton = _singletonGuidGenerator.Guid.ToString();
            ViewBag.Scoped = _scopedGuidGenerator.Guid.ToString();
            ViewBag.Transient = _transientGuidGenerator.Guid.ToString();

            ViewBag.ServiceSingleton = _guidService._singletonGuidGenerator.Guid.ToString();
            ViewBag.ServiceScoped = _guidService._scopedGuidGenerator.Guid.ToString();
            ViewBag.ServiceTransient = _guidService._transientGuidGenerator.Guid.ToString();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}