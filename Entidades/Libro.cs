using System.ComponentModel.DataAnnotations;

namespace Ejercicio_Sesión_1.Entidades
{
    public class Libro
    {
        [Key]
        public int LibroId { get; set; }
        public string Titulo { get; set; } //añadir limite de caracteres 150max
        public int Paginas { get; set; } //rango entre 1 - 10000
    }
}
