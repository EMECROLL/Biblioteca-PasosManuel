using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca_PasosManuel.Models.Domain
{
    public class Usuario
    {
        [Key]
        public int PKUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [ForeignKey("Roles")]
        public int FKRol { get; set; }
        public Rol Roles { get; set; }
    }
}
