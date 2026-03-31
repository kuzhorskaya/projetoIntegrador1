using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projetoIntegrador1.Models;
using projetoIntegrador1.Data;  // TODO: Adicionar using para AppDbContext

namespace projetoIntegrador1.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;  // TODO: Campo para injeção de dependência do banco

    public HomeController(AppDbContext context) {
        _context = context;
        }

    // TODO: Construtor para injetar AppDbContext
    
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == email);
        if (user != null && user.Password == password) {
            HttpContext.Session.SetString("UserId", user.Id.ToString());
        }
    }


    // TODO: Action GET para página de login
    // public IActionResult Login() { return View(); }

    // TODO: Action POST para processar login
    // [HttpPost]
    // public IActionResult Login(string email, string password)
    // {
    //     // Buscar usuário no banco: var user = _context.Users.FirstOrDefault(u => u.Email == email);
    //     // Se user != null && user.Password == password, criar sessão: HttpContext.Session.SetString("UserId", user.Id.ToString()); redirecionar para Index
    //     // Senão, mostrar erro: View("Login", "Credenciais inválidas");
    //     // Docs: https://learn.microsoft.com/aspnet/core/fundamentals/app-state
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
