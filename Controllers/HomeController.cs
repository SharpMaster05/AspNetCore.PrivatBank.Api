using Microsoft.AspNetCore.Mvc;
using PrivatBank.Services;

namespace PrivatBank.Controllers;

public class HomeController : Controller
{
    private readonly CurrencyService _service;

    public HomeController(CurrencyService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        var rates = await _service.GetAsync();

        return View(rates);
    }
}
