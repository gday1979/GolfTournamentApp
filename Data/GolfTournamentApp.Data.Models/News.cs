namespace GolfTournamentApp.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;

    using GolfTournamentApp.Data.Common.Models;

    public class News : BaseDeletableModel<int>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Source { get; set; }

        public string Author { get; set; }

        public virtual ICollection<PlayerNews> PlayersNewses { get; set; }

        public virtual ICollection<CourseNews> CourseNews { get; set; }

        public virtual ICollection<TournamentNews> TournamentsNewses { get; set; }
    }
}
