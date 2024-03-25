namespace GolfTournamentApp.Web.Areas.Identity.Pages.Account
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using GolfTournamentApp.Data.Models;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Build.Framework;
    using Microsoft.Extensions.Logging;

    public class LoginModel : PageModel
    {
        private readonly SignInManager<GolfTournamentUser> signInManager;
        private readonly ILogger<LoginModel> logger;

        public LoginModel(SignInManager<GolfTournamentUser> signInManager, ILogger<LoginModel> logger)
        {
            this.signInManager = signInManager;
            this.logger = logger;
        }

        [BindProperty]
        public LoginInputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(string returnUrl = null)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                if (!string.IsNullOrEmpty(this.ErrorMessage))
                {
                    this.ModelState.AddModelError(string.Empty, this.ErrorMessage);
                }

                returnUrl = returnUrl ?? this.Url.Content("~/");

                await this.HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

                this.ExternalLogins = (await this.signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

                this.ReturnUrl = returnUrl;
                return this.Page();
            }
            else
            {
                return this.Redirect("/");
            }
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? this.Url.Content("~/");

            if (this.ModelState.IsValid)
            {
                var result = await this.signInManager.PasswordSignInAsync(this.Input.Username, this.Input.Password, this.Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    this.logger.LogInformation("User logged in.");
                    return this.LocalRedirect(returnUrl);
                }

                if (result.IsLockedOut)
                {
                    this.logger.LogWarning("User account locked out.");
                    return this.RedirectToPage("./Lockout");
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return this.Page();
                }
            }

            return this.Page();
        }
    }
}
