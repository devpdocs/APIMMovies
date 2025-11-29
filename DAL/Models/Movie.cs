using System.ComponentModel.DataAnnotations;

namespace API.M.Movies.DAL.Models
{
    public class Movie : AuditBase
    {
        [Required]
        [Display(Name="Nombre de la pelicula")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Nombre del director de la pelicula")]
        public string Director { get; set; }

        [Required]
        [Display(Name ="Duración del la pelicula")]
        public int Duration { get; set; } 

        [Display(Name="Descripción de la pelicula")]
        public string? Description { get; set; }

        [Required]
        [Display(Name="Clasificación de la pelicula")]
        public int Clasification { get; set; }
    }
}
