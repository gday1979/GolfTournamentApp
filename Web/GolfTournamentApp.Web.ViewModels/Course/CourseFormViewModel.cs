namespace GolfTournamentApp.Web.ViewModels.Course
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CourseFormViewModel
    {
        [Required]

        public string Name { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Designer { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public string Description { get; set; }
    }
}
