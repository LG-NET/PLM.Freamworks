using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PLM.Website.Controllers
{
    public class SigninController : Controller
    {
        #region -- Index --

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName(nameof(Index))]
        public IActionResult IndexPost()
        {
            return View();
        }

        #endregion

        #region -- Forgot Password --

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ActionName(nameof(ForgotPassword))]
        public IActionResult ForgotPasswordPost()
        {
            return View();
        }

        #endregion
    }
}
