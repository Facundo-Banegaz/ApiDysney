using System.ComponentModel.DataAnnotations;

namespace WebApiDisney.Models
{
    public class Pelicula
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Título:")]
        [Required(ErrorMessage = "Por favor, ingresar el Título de la Película:")]
        [StringLength(150, MinimumLength = 4)]
        public string Titulo { get; set; }


        [Required(ErrorMessage = "Por favor, seleccionar una Imagen.")]
        [Display(Name = "Imagen")]
        public string Imagen { get; set; }

        [Display(Name = "Fecha:")]
        [Required(ErrorMessage = "Por favor, ingresar la Fecha:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime FechaCreacion { get; set; }

        [Display(Name = "Califiacíon:")]
        [Required(ErrorMessage = "Por favor, ingresar la Califiacíon de la Película:")]
        [Range(1, 5, ErrorMessage = "El valor para {0} debe estar entre {1} y {2}.")]
        public int Calification { get; set; }

        public List<Personaje> Personajes { get; set; }
    }
}
