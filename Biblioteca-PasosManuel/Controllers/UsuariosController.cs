using Biblioteca_PasosManuel.Models.Domain;
using Biblioteca_PasosManuel.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_PasosManuel.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioServices _usuarioServices;
        public UsuariosController(IUsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;
        }
        public IActionResult Index()
        {
            var result = _usuarioServices.ObtenerUsuarios();
            return View(result);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Usuario request)
        {
            _usuarioServices.CrearUsuario(request);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _usuarioServices.ObtenerUsuario(id);
            return View(result);
        }

    }
}
