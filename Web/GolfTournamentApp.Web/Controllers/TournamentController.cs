namespace GolfTournamentApp.Web.Controllers
{
    using System.Linq;

    using GolfTournamentApp.Data;
    using Microsoft.AspNetCore.Mvc;

    public class TournamentController : Controller
    {
        private readonly GolfTournamentDbContext context;

        public TournamentController(GolfTournamentDbContext context)
        {
           this.context = context;
        }

        public IActionResult Index()
        {
            var tournaments = this.context.Tournaments.ToList();
            return this.View(tournaments);
        }
    }
}
