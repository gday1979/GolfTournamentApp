﻿namespace GolfTournamentApp.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(GolfTournamentDbContext dbContext, IServiceProvider serviceProvider);
    }
}
