using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prueba_Tecnica.Models;

namespace Prueba_Tecnica.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Reportes()
    {
   
      return View();
    }

    public IActionResult ConfiguracionesMenu()
    {
      return View();
    }

    public IActionResult ConfiguracionesTienda()
    {
      
      return View();
    }
    public IActionResult Categorias()
    {
     
      return View();
    }
    public IActionResult Productos()
    {
     
      return View();
    }
    public IActionResult Ordenes()
    {
     
      return View();
    }
    public IActionResult Empleados()
    {
     
      return View();
    }
  }
}
