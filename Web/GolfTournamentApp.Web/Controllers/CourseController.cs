﻿namespace GolfTournamentApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
