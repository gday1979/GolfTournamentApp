namespace GolfTournamentApp.Web.ViewModels.Course
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using static GolfTournamentApp.Web.ViewModels.ViewModelValidation.Course;

    public class CourseFormViewModel
    {
        [Required]
        [MaxLength(NameMaxLength)]
        [Display(Name = "Course Name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(CountryMaxLength)]
        public string Country { get; set; }

        [Required]
        [MaxLength(CityMaxLength)]
        public string City { get; set; }

        [Required]
        [MaxLength(DesignerMaxLength)]
        public string Designer { get; set; }

        [Required]
        [Display(Name = "Image Course")]
        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(CourseDescriptionMaxLength)]
        public string Description { get; set; }
    }
}
