namespace GolfTournamentApp.Data.Models
{
    using System.Collections.Generic;

    using GolfTournamentApp.Data.Common.Models;

    public class Course : BaseDeletableModel<int>
    {
        public Course()
        {
            this.Tournaments = new HashSet<Tournament>();
            this.Players = new HashSet<Player>();
        }

        public string Name { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Image { get; set; }

        public int Length { get; set; }

        public string Designer { get; set; }

        public virtual ICollection<Tournament> Tournaments { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
