namespace GolfTournamentApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class TournamentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
