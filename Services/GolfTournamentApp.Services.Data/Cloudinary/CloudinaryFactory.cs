namespace GolfTournamentApp.Services.Data.Cloudinary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Principal;
    using System.Text;
    using System.Threading.Tasks;

    using CloudinaryDotNet;
    using Microsoft.Extensions.Configuration;

    public class CloudinaryFactory
    {
        public static Cloudinary GetInstance(IConfiguration configuration)
        {
            var cloud = configuration["Cloudinary:CloudName"];
            var apiKey = configuration["Cloudinary:ApiKey"];
            var apiSecret = configuration["Cloudinary:ApiSecret"];

            Account account = new Account(cloud, apiKey, apiSecret);

            Cloudinary instance = new Cloudinary(account);
            return instance;
        }
    }
}
