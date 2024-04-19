namespace GolfTournamentApp.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using GolfTournamentApp.Data.Common.Models;

    public class Ranking : BaseModel<int>
    {
        public Ranking()
        {
            this.Players = new HashSet<Player>();
        }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public int Points { get; set; }

        [Required]
        public int Position { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
