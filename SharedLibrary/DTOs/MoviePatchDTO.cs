using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DTOS
{
    public class MoviePatchDTO
    {
        [Required]
        [StringLength(300)]
        public string Title { get; set; }
        public bool OnCinemas { get; set; }
        public DateTime PremierDate { get; set; }
    }
}
