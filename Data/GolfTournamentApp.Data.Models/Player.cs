namespace GolfTournamentApp.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;

    using GolfTournamentApp.Data.Common.Models;

    public class Player : BaseDeletableModel<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Country { get; set; }

        public int Age { get; set; }

        public virtual ICollection<PlayerNews> PlayersNewses { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Tournament> Tournaments { get; set; }

        public virtual ICollection<GolfRanking> GolfRankings { get; set; }
    }
}
