namespace GolfTournamentApp.Web.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ViewModelValidation
    {
        public const string NameLengthError = "Name must be between {2} and {1} symbols";
        public const string EmptyFieldLengthError = "Please enter the field.";

        public static class Tournament
        {
            public const string NameDisplayName = "Tournament Name";
        }

        public static class Course
        {
            public const string NameDisplayName = "Course Name";
            public const int NameMaxLength = 15;
            public const int CountryMaxLength = 15;
            public const int CityMaxLength = 15;
            public const string ImageUrl = "Image Course";
            public const int DesignerMaxLength = 15;
            public const int CourseDescriptionMaxLength = 15;
        }
    }
}
