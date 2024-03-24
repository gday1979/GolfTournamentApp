namespace GolfTournamentApp.Data.Models
{
    using System;

    using GolfTournamentApp.Data.Common.Models;

    public class CourseNews : IDeletableEntity
    {
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public int NewsId { get; set; }

        public virtual News News { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string UserId { get; set; }

        public virtual GolfTournamentUser User { get; set; }
    }
}
