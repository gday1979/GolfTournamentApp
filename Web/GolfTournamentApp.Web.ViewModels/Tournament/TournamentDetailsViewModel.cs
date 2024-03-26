namespace GolfTournamentApp.Web.ViewModels.Tournament
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data.Models;
    using GolfTournamentApp.Services.Mapping;

    using static GolfTournamentApp.Web.ViewModels.ViewModelValidation.Tournament;

    public class TournamentDetailsViewModel : IMapFrom<Tournament>
    {
        public int Id { get; set; }

        [Display(Name = NameDisplayName)]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
