﻿namespace GolfTournamentApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
