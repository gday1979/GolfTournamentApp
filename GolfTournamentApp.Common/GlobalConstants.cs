namespace GolfTournamentApp.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "GolfTournamentApp";

        public const string SystemEmail = "zshkembov@gmail.com";

        public const string AdministratorRoleName = "Administrator";

        public const string AdminUsername = "Admin";

        public const string UserRoleName = "User";

        public const string AdminEmail = "zshkembov@gmail.com";

        public const string AdminPassword = "16051979";

        public const string AdministratorFullName = "Zlatin";

        public const string AllowedExtensionsErrorMessage = "This photoe extension is not allowed!";
        public const string MaxFileSizeErrorMessage = "Maxium allowed file size is {0} megabytes";
        public const string DefaultDateTimeFormat = "dd/MM/yyyy HH:mm";
        public const string CloudinaryPrefix = "https://res.cloudinary.com/{0}/image/upload/";
        public const int ImageMaxSizeMB = 10;

        public static readonly string[] AllowedImageExtensions = { "jpg", "jpeg", "png", "gif" };
    }
}
