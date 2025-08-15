#region Using
using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers;

#endregion

public class AdminController : Controller
{
    #region Admin
    public IActionResult Index()
    {
        return View();
    }

    #endregion
}
