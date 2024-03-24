namespace GolfTournamentApp.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data.Models;

    public class PlayersSeeder : ISeeder
    {
        public async Task SeedAsync(GolfTournamentDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Players.Any())
            {
                return;
            }

            var players = new List<Player>
            {
                new Player
                {
                    FirstName = "Tiger",
                    LastName = "Woods",
                    Country = "USA",
                    Age = 45,
                },
                new Player
                {
                    FirstName = "Rory",
                    LastName = "McIlroy",
                    Country = "Northern Ireland",
                    Age = 32,
                },
                new Player
                {
                    FirstName = "Jordan",
                    LastName = "Spieth",
                    Country = "USA",
                    Age = 28,
                },
                new Player
                {
                    FirstName = "Phil",
                    LastName = "Mickelson",
                    Country = "USA",
                    Age = 51,
                },
                new Player
                {
                    FirstName = "Justin",
                    LastName = "Thomas",
                    Country = "USA",
                    Age = 28,
                },
                new Player
                {
                    FirstName = "Bryson",
                    LastName = "DeChambeau",
                    Country = "USA",
                    Age = 28,
                },
                new Player
                {
                    FirstName = "Collin",
                    LastName = "Morikawa",
                    Country = "USA",
                    Age = 24,
                },
                new Player
                {
                    FirstName = "Xander",
                    LastName = "Schauffele",
                    Country = "USA",
                    Age = 27,
                },
                new Player
                {
                    FirstName = "Brooks",
                    LastName = "Koepka",
                    Country = "USA",
                    Age = 31,
                },
                new Player
                {
                    FirstName = "Patrick",
                    LastName = "Reed",
                    Country = "USA",
                    Age = 31,
                },
                new Player
                {
                    FirstName = "Viktor",
                    LastName = "Hovland",
                    Country = "Norway",
                    Age = 24,
                },
                new Player
                {
                    FirstName = "Tony",
                    LastName = "Finau",
                    Country = "USA",
                    Age = 32,
                },
                new Player
                {
                    FirstName = "Hideki",
                    LastName = "Matsuyama",
                    Country = "Japan",
                    Age = 29,
                },
                new Player
                {
                    FirstName = "Webb",
                    LastName = "Simpson",
                    Country = "USA",
                    Age = 35,
                },
                new Player
                {
                    FirstName = "Adam",
                    LastName = "Scott",
                    Country = "Australia",
                    Age = 41,
                },
                new Player
                {
                    FirstName = "Sungjae",
                    LastName = "Im",
                    Country = "South Korea",
                    Age = 23,
                },
                new Player
                {
                    FirstName = "Tommy",
                    LastName = "Fleetwood",
                    Country = "England",
                    Age = 30,
                },
                new Player
                {
                    FirstName = "Louis",
                    LastName = "Oosthuizen",
                    Country = "South Africa",
                    Age = 38,
                },
                new Player
                {
                    FirstName = "Jason",
                    LastName = "Day",
                    Country = "Australia",
                    Age = 33,
                },
                new Player
                {
                    FirstName = "Matthew",
                    LastName = "Wolff",
                    Country = "USA",
                    Age = 22,
                },
                new Player
                {
                    FirstName = "Harris",
                    LastName = "English",
                    Country = "USA",
                    Age = 32,
                },
            };
            foreach (var player in players)
            {
                await dbContext.Players.AddAsync(new Player
                {
                    FirstName = player.FirstName,
                    LastName = player.LastName,
                    Country = player.Country,
                    Age = player.Age,
                });
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
