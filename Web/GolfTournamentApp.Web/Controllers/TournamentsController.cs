namespace GolfTournamentApp.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data;
    using GolfTournamentApp.Data.Models;
    using GolfTournamentApp.Services.Data.Tournament;
    using GolfTournamentApp.Web.ViewModels.Tournament;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    public class TournamentsController : BaseController
    {
        private readonly ITournamentService tournamentsService;

        public TournamentsController(ITournamentService tournamentService)
        {
            this.tournamentsService = tournamentService;
        }

        public IActionResult Index()
        {
            return this.View();
        }
    }
}
