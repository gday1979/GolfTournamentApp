namespace GolfTournamentApp.Web.Areas.Identity.Pages.Account
{
    using System.ComponentModel.DataAnnotations;

    using GolfTournamentApp.Data.Models;

    using static GolfTournamentApp.Data.Common.DataValidation;

    public class AjaxRegisterInputModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Full name")]
        [MaxLength(FullNameMaxLength, ErrorMessage = "The {0} must be max {1} characters long.")]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength =6)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
