using System.Diagnostics;
using System.Diagnostics.Contracts;
using WebApplication1.Datos;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Controllers
{
    public class InicioController : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public InicioController(ApplicationDbContext context)
        {
            _contexto = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Usuario.ToListAsync());
        }
        
    }
}
