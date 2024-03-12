using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DTOS
{
    public class CreateGenreDTO
    {
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
    }
}
