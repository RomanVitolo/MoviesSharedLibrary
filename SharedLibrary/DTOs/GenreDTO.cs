using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DTOS
{
    public class GenreDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
    }
}
