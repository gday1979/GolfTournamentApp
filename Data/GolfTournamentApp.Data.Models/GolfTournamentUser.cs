namespace GolfTournamentApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Principal;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data.Common.Models;
    using Microsoft.AspNetCore.Identity;

    public class GolfTournamentUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public GolfTournamentUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();

            this.Newses = new HashSet<News>();
            this.PlayerNews = new HashSet<PlayerNews>();
            this.TournamentNews = new HashSet<TournamentNews>();
        }

        public string FullName { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public virtual ICollection<News> Newses { get; set; }

        public virtual ICollection<PlayerNews> PlayerNews { get; set; }

        public virtual ICollection<TournamentNews> TournamentNews { get; set; }
    }
}
