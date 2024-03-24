namespace GolfTournamentApp.Data.Models
{
    using GolfTournamentApp.Data.Common.Models;

    public class GolfRanking : BaseDeletableModel<int>
    {
        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }

        public int RankingId { get; set; }

        public virtual Ranking Ranking { get; set; }
    }
}
