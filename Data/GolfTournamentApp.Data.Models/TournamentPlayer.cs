namespace GolfTournamentApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data.Common.Models;

    public class TournamentPlayer : BaseModel<int>
    {
        public int TournamentId { get; set; }

        public virtual Tournament Tournament { get; set; }

        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }
    }
}
