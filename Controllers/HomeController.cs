using Microsoft.AspNetCore.Mvc;

namespace PrivatBank.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
