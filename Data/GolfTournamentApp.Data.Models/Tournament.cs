namespace GolfTournamentApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data.Common.Models;
    using GolfTournamentApp.Data.Models.Enumerations;

    using static GolfTournamentApp.Data.Models.DataValidations.Tournament;

    public class Tournament : BaseModel<int>
    {
        public Tournament()
        {
            this.Players = new HashSet<Player>();
        }

        [Required]
        [MaxLength(TournamentMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int Prize { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public CategoryTournament CategoryTournament { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
