namespace GolfTournamentApp.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data.Models;

    public class PlayerSeeder : ISeeder
    {
        public async Task SeedAsync(GolfTournamentDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Players.Any())
            {
                return;
            }

            var players = new List<(string FirstName, string LastName, string Country, int Age)>

            {
                                ("Tiger", "Woods", "USA", 45),
                                ("Rory", "McIlroy", "Northern Ireland", 32),
                                ("Jordan", "Spieth", "USA", 28),
                                ("Justin", "Thomas", "USA", 27),
                                ("Jon", "Rahm", "Spain", 26),
                                ("Collin", "Morikawa", "USA", 24),
                                ("Xander", "Schauffele", "USA", 27),
                                ("Bryson", "DeChambeau", "USA", 27),
                                ("Patrick", "Cantlay", "USA", 29),
                                ("Viktor", "Hovland", "Norway", 24),
                                ("Webb", "Simpson", "USA", 35),
                                ("Tony", "Finau", "USA", 31),
                                ("Hideki", "Matsuyama", "Japan", 29),
                                ("Patrick", "Reed", "USA", 30),
                                ("Scottie", "Scheffler", "USA", 25),
                                ("Daniel", "Berger", "USA", 28),
                                ("Louis", "Oosthuizen", "South Africa", 38),
                                ("Harris", "English", "USA", 31),
                                ("Sungjae", "Im", "South Korea", 23),
                                ("Jason", "Kokrak", "USA", 36),
                                ("Adam", "Scott", "Australia", 40),
                                ("Lee", "Westwood", "England", 48),
                                ("Phil", "Mickelson", "USA", 51),
                                ("Matt", "Fitzpatrick", "England", 27),
                                ("Abraham", "Ancer", "Mexico", 30),
                                ("Corey", "Conners", "Canada", 29),
                                ("Joaquin", "Niemann", "Chile", 22),
                                ("Gary", "Woodland", "USA", 37),
                                ("Kevin", "Kisner", "USA", 37),
                                ("Francesco", "Molinari", "Italy", 38),
                                ("Bubba", "Watson", "USA", 42),
                                ("Branden", "Grace", "South Africa", 33),
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
        }
    }
}
