namespace GolfTournamentApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class DataValidations
    {
        public static class Course
        {
            public const int NameMaxLength = 20;
            public const int CountryMaxLength = 20;
            public const int CityMaxLength = 20;
            public const int MaxLength = 8000;
            public const int DesignerMaxLength = 20;
        }

        public static class News
        {
            public const int TitleMaxLength = 50;
            public const int ContentMaxLength = 200;
            public const int SourceMaxLength = 20;
        }

        public static class Player
        {
            public const int FirstNameMaxLength = 15;
            public const int LastNameMaxLength = 15;
            public const int CountryMaxLength = 20;
            public const int AgeMaxLength = 60;
        }

        public static class Tournament
        {
            public const int TournamentMaxLength = 20;
            public const int DescriptionMaxLength = 100;
            public const int LocationMaxLength = 20;
            public const int OrganizerMaxLength = 20;
            public const int PrizeMaxLength = 10;
        }
    }
}
