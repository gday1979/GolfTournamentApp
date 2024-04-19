namespace GolfTournamentApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class PlayerController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
