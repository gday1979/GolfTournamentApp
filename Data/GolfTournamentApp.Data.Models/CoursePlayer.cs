namespace GolfTournamentApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data.Common.Models;

    public class CoursePlayer : BaseModel<int>
    {
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }
    }
}
