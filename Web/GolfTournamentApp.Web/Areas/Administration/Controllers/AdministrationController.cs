namespace GolfTournamentApp.Web.Areas.Administration.Controllers
{
    using GolfTournamentApp.Common;
    using GolfTournamentApp.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
