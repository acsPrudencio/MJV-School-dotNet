using Microsoft.AspNetCore.Mvc;

namespace aula09.Controllers;

public class CoxinhaController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    // GET
    public IActionResult Pastel()
    {
        return View();
    }
}