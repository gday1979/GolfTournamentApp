﻿namespace GolfTournamentApp.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data.Models;

    internal class SettingsSeeder : ISeeder
    {
        public async Task SeedAsync(GolfTournamentDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Settings.Any())
            {
                return;
            }

            await dbContext.Settings.AddAsync(new Setting { Name = "Setting1", Value = "value1" });
        }
    }
}
