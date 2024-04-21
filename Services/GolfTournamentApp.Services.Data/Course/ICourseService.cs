namespace GolfTournamentApp.Services.Data.Course
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTournamentApp.Web.ViewModels.Course;

    public interface ICourseService
    {
        Task CreateAsync(CourseFormViewModel course);
    }
}
