namespace GolfTournamentApp.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data.Models;
    using GolfTournamentApp.Data.Models.Enumerations;

    public class TournamentsSeeder : ISeeder
    {
        public async Task SeedAsync(GolfTournamentDbContext dbContext, IServiceProvider serviceProvider)
        {
           if (dbContext.Tournaments.Any())
            {
                return;
            }

           var tournamemts = new List<Tournament>
            {
                new Tournament
                {
                    Name = "PGA Championship",
                    Description = "The PGA",
                    CategoryTournament = CategoryTournament.PGA,
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow.AddDays(4),
                    Location = "Kiawah Island Golf Resort, South Carolina, USA",
                    Prize = 11000000,
                    ImageUrl = "https://kiawahresort.com/wp-content/uploads/2018/10/6-green.jpg",
                },
                new Tournament
                {
                    Name = "The Open ",
                    Description = "The Open",
                    CategoryTournament = CategoryTournament.PGA,
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow.AddDays(4),
                    Location = "Royal St George's Golf Club, Sandwich, Kent, England",
                    Prize = 10000000,
                    ImageUrl = "https://www.royalstgeorges.com/images/royal-st-georges-golf-club-1.jpg",
                },
            };
           foreach (var tournament in tournamemts)
            {
                await dbContext.Tournaments.AddAsync(new Tournament
                {
                    Name = tournament.Name,
                    Description = tournament.Description,
                    CategoryTournament = tournament.CategoryTournament,
                    StartDate = tournament.StartDate,
                    EndDate = tournament.EndDate,
                    Location = tournament.Location,
                    Prize = tournament.Prize,
                    ImageUrl = tournament.ImageUrl,
                });
            }

           await dbContext.SaveChangesAsync();
        }
    }
}
