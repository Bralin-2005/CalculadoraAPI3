using Microsoft.AspNetCore.Mvc;

namespace CalculadoraAPI2.Controllers;

public class CalculadoraControleler : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}