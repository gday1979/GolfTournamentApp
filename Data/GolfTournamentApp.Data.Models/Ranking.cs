namespace GolfTournamentApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using GolfTournamentApp.Data.Common.Models;

    public class Ranking : BaseModel<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
