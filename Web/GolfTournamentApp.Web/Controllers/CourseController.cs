namespace GolfTournamentApp.Web.Controllers
{
    using System.Threading.Tasks;

    using GolfTournamentApp.Web.ViewModels.Course;
    using Microsoft.AspNetCore.Mvc;

    public class CourseController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseFormViewModel courseFormViewModel)
        {
            return this.View();
        }
    }
}
