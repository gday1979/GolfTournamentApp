namespace GolfTournamentApp.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data;
    using GolfTournamentApp.Data.Models;
    using GolfTournamentApp.Services.Data;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class TournamentController : Controller
    {
        private readonly GolfTournamentDbContext context;

        public TournamentController(GolfTournamentDbContext context)
        {
           this.context = context;
        }

        public IActionResult Index()
        {
            List<Tournament> tournaments = this.context.Tournaments.ToList();
            return this.View(tournaments);
        }

        public IActionResult Details(int id)
        {
            Tournament tournament = this.context.Tournaments.FirstOrDefault(x => x.Id == id);
            return this.View(tournament);
        }
    }
}
