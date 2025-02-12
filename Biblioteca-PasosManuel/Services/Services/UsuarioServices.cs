using Biblioteca_PasosManuel.Context;
using Biblioteca_PasosManuel.Models.Domain;
using Biblioteca_PasosManuel.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca_PasosManuel.Services.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly ApplicationDbContext _context;
        public UsuarioServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            try
            {
                var result = _context.Usuarios.Include(x => x.Roles).ToList();
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Sucedió un error: " + e.Message);
            }
        }

        public bool CrearUsuario(Usuario request) 
        {
            try
            {
                Usuario usuario = new Usuario()
                {
                    Nombre = request.Nombre,
                    Apellido = request.Apellido,
                    Password = request.Password,
                    UserName = request.UserName,
                    FKRol = 1
                };

                _context.Usuarios.Add(usuario);
                var result = _context.SaveChanges();

                if(result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw new Exception("Sucedio un error: " + e.Message);
            }
        }

        public Usuario ObtenerUsuario(int id)
        {
            try
            {
                Usuario usuario = _context.Usuarios.Find(id);
                //Usuario usuario = _context.Usuarios.Where(x => x.PKUsuario == id);

                return usuario;
            }
            catch (Exception e)
            {

                throw new Exception("Sucedio un error: " + e.Message);
            }
        }
    }
}
