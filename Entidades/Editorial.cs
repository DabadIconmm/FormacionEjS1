using System.ComponentModel.DataAnnotations;

namespace Ejercicio_Sesión_1.Entidades
{
    public class Editorial
    {
        [Key]
        public int EditorialId { get; set; }
        public string Nombre { get; set; } //texto no más de 50 caracteres
    }
}
