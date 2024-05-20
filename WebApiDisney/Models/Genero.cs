using System.ComponentModel.DataAnnotations;

namespace WebApiDisney.Models
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nombre Del Género:")]
        [Required(ErrorMessage = "Por favor, ingresar el Género:")]
        [StringLength(150, MinimumLength = 4)]
        public string Nombre { get; set; }


        [Required]
        public List<Pelicula> Peliculas { get; set; }
    }
}
