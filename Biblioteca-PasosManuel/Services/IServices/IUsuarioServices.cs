using Biblioteca_PasosManuel.Models.Domain;

namespace Biblioteca_PasosManuel.Services.IServices
{
    public interface IUsuarioServices
    {
        public bool CrearUsuario(Usuario request);
        public Usuario ObtenerUsuario(int id);
        public List<Usuario> ObtenerUsuarios();
    }
}
