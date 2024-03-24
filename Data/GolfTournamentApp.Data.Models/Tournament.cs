namespace GolfTournamentApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data.Common.Models;
    using GolfTournamentApp.Data.Models.Enumerations;

    public class Tournament : BaseModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Location { get; set; }

        public string Organizer { get; set; }

        public string Prize { get; set; }

        public string Image { get; set; }

        public CategoryTournament CategoryTournament { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<News> Newses { get; set; }

        public virtual ICollection<GolfRanking> GolfRankings { get; set; }
    }
}
