namespace GolfTournamentApp.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using GolfTournamentApp.Data.Common.Models;

    using static GolfTournamentApp.Data.Models.DataValidations.Player;

    public class Player : BaseDeletableModel<int>
    {
        public Player()
        {
            this.PlayersNewses = new HashSet<PlayerNews>();
            this.Courses = new HashSet<Course>();
            this.Tournaments = new HashSet<Tournament>();
            this.GolfRankings = new HashSet<GolfRanking>();
        }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(CountryMaxLength)]
        public string Country { get; set; }

        [Required]
        [MaxLength(AgeMaxLength)]
        public int Age { get; set; }

        public virtual ICollection<PlayerNews> PlayersNewses { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Tournament> Tournaments { get; set; }

        public virtual ICollection<GolfRanking> GolfRankings { get; set; }
    }
}
