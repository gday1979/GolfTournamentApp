namespace GolfTournamentApp.Data.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using GolfTournamentApp.Data.Common.Models;

    using static GolfTournamentApp.Data.Models.DataValidations.News;

    public class News : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; }

        [Required]
        [MaxLength(SourceMaxLength)]
        public string Source { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual GolfTournamentUser User { get; set; }

        public virtual ICollection<PlayerNews> PlayersNewses { get; set; }

        public virtual ICollection<TournamentNews> TournamentsNewses { get; set; }
    }
}
