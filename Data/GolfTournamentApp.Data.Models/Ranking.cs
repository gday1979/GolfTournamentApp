namespace GolfTournamentApp.Data.Models
{
    using GolfTournamentApp.Data.Common.Models;

    public class Ranking : BaseModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
