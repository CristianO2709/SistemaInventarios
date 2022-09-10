using Microsoft.AspNetCore.Mvc;
using SysInventarios.DataContext;
using SysInventarios.Models;
using System.Diagnostics;

namespace SysInventarios.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InventariosDbContext  _dbcontext;

        public HomeController(ILogger<HomeController> logger, InventariosDbContext dbcontext)
        {
            _logger = logger;
            _dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            int countUser = _dbcontext.Usuarios.Count();
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