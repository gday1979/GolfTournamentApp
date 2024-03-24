namespace GolfTournamentApp.Data.Models
{
    using System;

    using GolfTournamentApp.Data.Common.Models;

    public class TournamentNews : IDeletableEntity
    {
        public int TournamentId { get; set; }

        public virtual Tournament Tournament { get; set; }

        public int? NewsId { get; set; }

        public virtual News News { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
