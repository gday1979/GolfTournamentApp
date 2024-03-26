namespace GolfTournamentApp.Services.Data
{
    using System;

    using Microsoft.AspNetCore.Http;

    public class TournamentCreateInputModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string Location { get; set; }

        public IFormFile ImageUrl { get; set; }

        public string OrganizerId { get; set; }
    }
}
