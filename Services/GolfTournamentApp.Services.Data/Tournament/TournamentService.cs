namespace GolfTournamentApp.Services.Data.Tournament
{
    using System.Threading.Tasks;

    using GolfTournamentApp.Data.Common.Repositories;
    using GolfTournamentApp.Data.Models;
    using GolfTournamentApp.Services.Data;
    using GolfTournamentApp.Web.ViewModels.Tournament;

    using Microsoft.EntityFrameworkCore;

    public class TournamentService : ITournamentService
    {
        public Task<TournamentDetailsViewModel> CreateAsync(TournamentCreateInputModel tournamentCreateInputModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
