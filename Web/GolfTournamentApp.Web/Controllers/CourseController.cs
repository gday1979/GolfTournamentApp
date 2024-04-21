namespace GolfTournamentApp.Web.Controllers
{
    using System.Threading.Tasks;

    using GolfTournamentApp.Services.Data.Course;
    using GolfTournamentApp.Web.ViewModels.Course;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class CourseController : BaseController
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(CourseFormViewModel course)
        {
           if (!this.ModelState.IsValid)
            {
                return this.View(course);
            }

           await this.courseService.CreateAsync(course);
           return this.RedirectToAction("Index");
        }
    }
}
