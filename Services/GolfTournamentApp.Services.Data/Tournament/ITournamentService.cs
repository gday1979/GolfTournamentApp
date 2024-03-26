namespace GolfTournamentApp.Services.Data.Tournament
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTournamentApp.Web.ViewModels.Tournament;

    public interface ITournamentService
    {
        Task<TournamentDetailsViewModel> CreateAsync(TournamentCreateInputModel tournamentCreateInputModel);
    }
}
