using System.ComponentModel.DataAnnotations;

namespace API.M.Movies.DAL.Models.Dtos
{
    public class CategoryCreateDtos
    {
        [Required(ErrorMessage = "El nombre de la categoría es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El número máximo de caracteres es de 100.")]
        public string Name { get; set; }
    }

}
