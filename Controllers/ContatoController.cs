using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cadastro_de_contatos.Models;

namespace cadastro_de_contatos.Controllers;

public class ContatoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Criar()
    {
        return View();
    }

    public IActionResult Editar()
    {
        return View();
    }

    public IActionResult Deletar()
    {
        return View();
    }
}