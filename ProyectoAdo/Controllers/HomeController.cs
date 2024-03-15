using Microsoft.AspNetCore.Mvc;
using ProyectoAdo.Models;
using System.Diagnostics;

using Business;
using Entity.Entidades;

namespace ProyectoAdo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioBusiness _usuarioBL;

        public HomeController(IUsuarioBusiness business)
        {
            _usuarioBL = business;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> MostrarUsuario()
        {
            List<Usuario> lstUsuario = await _usuarioBL.ObtenerUsuario();
            return View(lstUsuario);
        }

        public async Task<IActionResult> MostrarUsuarioById( int id )
        {
            Usuario Usuario = await _usuarioBL.ObtenerUsuarioById(id);
            return View(Usuario);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}