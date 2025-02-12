using System.ComponentModel.DataAnnotations;

namespace Biblioteca_PasosManuel.Models.Domain
{
    public class Rol
    {
        [Key]
        public int PKRol { get; set; }
        public string Nombre { get; set; }
    }
}
