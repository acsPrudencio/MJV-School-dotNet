using Microsoft.AspNetCore.Mvc;

namespace aula09.Controllers;

public class BombaController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}