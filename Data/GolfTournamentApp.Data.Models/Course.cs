namespace GolfTournamentApp.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using GolfTournamentApp.Data.Common.Models;

    using static GolfTournamentApp.Data.Models.DataValidations.Course;

    public class Course : BaseDeletableModel<int>
    {
        public Course()
        {
            this.Tournaments = new HashSet<Tournament>();
            this.Players = new HashSet<Player>();
        }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(CountryMaxLength)]
        public string Country { get; set; }

        [Required]
        [MaxLength(CityMaxLength)]
        public string City { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        [MaxLength(MaxLength)]
        public int Length { get; set; }

        [Required]
        [MaxLength(DesignerMaxLength)]
        public string Designer { get; set; }

        public virtual ICollection<Tournament> Tournaments { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
