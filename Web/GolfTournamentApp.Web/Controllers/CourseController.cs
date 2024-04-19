namespace GolfTournamentApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class CourseController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
