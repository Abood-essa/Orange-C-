using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthTask.Controllers
{
    public class AdminSetupController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AdminSetupController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MakeMeAdmin()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return Content("You must login first.");
            }

            await _userManager.AddToRoleAsync(user, "Admin");

            return Content("You are now Admin.");
        }
    }
}