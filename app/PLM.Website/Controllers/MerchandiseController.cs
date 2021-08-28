using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PLM.Website.Controllers
{
    public class MerchandiseController : Controller
    {
        #region -index-
        public IActionResult Index()
        {
            return View();
        }
        #endregion
        #region -Update-
        public IActionResult Editor() => View();

        public IActionResult AddMerchandise() => View();
        #endregion
    }
}
