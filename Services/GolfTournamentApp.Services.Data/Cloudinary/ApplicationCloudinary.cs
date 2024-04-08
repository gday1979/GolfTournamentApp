namespace GolfTournamentApp.Services.Data.Cloudinary
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Microsoft.AspNetCore.Http;

    public class ApplicationCloudinary : IApplicationCloudinary
    {
        private readonly Cloudinary cloudinary;

        public ApplicationCloudinary(Cloudinary cloudinary)
        {
            this.cloudinary = cloudinary;
        }

        [Obsolete]
        public async Task<string> UploadFileAsunc(IFormFile file)
        {
            byte[] destinationFile;
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                destinationFile = memoryStream.ToArray();
            }

            ImageUploadResult uploadResult;
            using (var ms = new MemoryStream(destinationFile))
            {
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, ms),
                };

                uploadResult = await this.cloudinary.UploadAsync(uploadParams);
            }

            return uploadResult.SecureUri.AbsoluteUri;
        }

        public async Task DeleteFile(string url)
        {
            var publicId = this.GetCloudinaryPublicIdFromUrl(url);
            var deleteParams = new DeletionParams(publicId);

            await this.cloudinary.DestroyAsync(deleteParams);
        }

        private string GetCloudinaryPublicIdFromUrl(string url)
        {
            var startIndex = url.IndexOf('/') + 1;
            var length = url.LastIndexOf('.') - startIndex;
            var publicId = url.Substring(startIndex, length);

            return publicId;
        }
    }
}
