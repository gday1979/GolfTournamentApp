namespace GolfTournamentApp.Services.Data.Cloudinary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public interface IApplicationCloudinary
    {
        Task<string> UploadFileAsunc(IFormFile file);

        Task DeleteFile(string url);
    }
}
