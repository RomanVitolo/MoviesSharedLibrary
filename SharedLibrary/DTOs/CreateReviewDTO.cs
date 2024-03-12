using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DTOS
{
    public class CreateReviewDTO
    {
        public string Commentary { get; set; }
        [Range(1, 5)]
        public int Punctuation { get; set; }
    }
}
