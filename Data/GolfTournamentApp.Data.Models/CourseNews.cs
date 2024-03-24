namespace GolfTournamentApp.Data.Models
{
    public class CourseNews
    {
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public int NewsId { get; set; }

        public virtual News News { get; set; }
    }
}
