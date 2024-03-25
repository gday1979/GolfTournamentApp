namespace GolfTournamentApp.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data.Models;

    public class CoursesSeeder : ISeeder
    {
        public async Task SeedAsync(GolfTournamentDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Courses.Any())
            {
                return;
            }

            var courses = new List<Course>
            {
                new Course
                {
                    Name = "Augusta",
                    City = "Augusta",
                    Country = "USA",
                    Designer = "Alister MacKenzie",
                    Length = 7435,
                    Image = "https://media.gettyimages.com/id/469054546/photo/augusta-ga-tiger-woods-of-the-united-states-takes-a-free-drop-on-the-second-hole-during-the.jpg?s=612x612&w=0&k=20&c=rp6KOooIEMu5uDpHUbABaH2k3DH4GgaP0pu0qvU0HoQ=",
                },
                new Course
                {
                    Name = "PebbleBeach",
                    City = "PebbleBeach",
                    Country = "USA",
                    Designer = "Jack Neville",
                    Length = 6828,
                    Image = "https://media.gettyimages.com/id/1155742847/photo/pebble-beach-california-adri-arnaus-of-spain-prepares-to-take-a-free-drop-on-the-ninth-hole.jpg?s=612x612&w=0&k=20&c=-aCJ5GJiMAyKlUTWmSJ4NpMImq1S4Im2sMiIUNlU18c=",
                },
                new Course
                {
                    Name = "St.Andrews",
                    City = "St.Andrews",
                    Country = "Scotland",
                    Designer = "Old Tom Morris",
                    Length = 6721,
                    Image = "https://www.caddybytes.com/virtualtours/St%20Andrews1/slides/Valley_ofSin.jpg",
                },
            };
            foreach (var course in courses)
            {
                await dbContext.Courses.AddAsync(new Course
                {
                    Name = course.Name,
                    City = course.City,
                    Country = course.Country,
                    Designer = course.Designer,
                    Length = course.Length,
                    Image = course.Image,
                });
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
