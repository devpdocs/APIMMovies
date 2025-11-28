using System.ComponentModel.DataAnnotations;

namespace API.M.Movies.DAL.Models
{
    public class Movie : AuditBase
    {
        [Required]
        [Display(Name="Nombre de la pelicula")]
        public string Name { get; set; }

    }
}
