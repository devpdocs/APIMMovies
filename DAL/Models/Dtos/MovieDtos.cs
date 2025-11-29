using System.ComponentModel.DataAnnotations;

namespace API.M.Movies.DAL.Models.Dtos
{
    public class MovieDtos
    {
        [Required(ErrorMessage = "El Nombre de la pelicula es obligatorio.")]
        [MaxLength(150, ErrorMessage = "El número máximo de caracteres es de 100.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El Nombre del director es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El número máximo de caracteres es de 20.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "La Duración de la pelicula es obligatorio.")]
        [Range(1, 20, ErrorMessage = "La duración de la pelicula, debe oscilar entre 1 y 20 horas")]
        public int Duration { get; set; } 

        [Required(ErrorMessage = "La Descripción de la pelicula es obligatoria.")]
        [MaxLength(400, ErrorMessage = "El número máximo de caracteres es de 400.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "La clasificación de la pelicula es obligatorio.")]
        [Range(1, 10, ErrorMessage = "La clasificación de la pelicula, debe oscilar entre 1 y 10 horas")]
        public int Clasification { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }

}
