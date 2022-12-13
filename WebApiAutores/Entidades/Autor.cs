using System.ComponentModel.DataAnnotations;
using WebApiAutores.Validaciones;

namespace WebApiAutores.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo nombre es requerido")]
        [StringLength(maximumLength: 120, ErrorMessage = " El campo {0} no debe de tener más de {1} caracteres")]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        public List<AutorLibro> AutoresLibros { get; set; }

    }
}
