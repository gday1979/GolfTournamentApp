namespace GolfTournamentApp.Services.Data.Course
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTournamentApp.Web.ViewModels.Course;

    public class CourseService : ICourseService
    {
        Task ICourseService.CreateAsync(CourseFormViewModel course)
        {
            throw new NotImplementedException();
        }
    }
}
