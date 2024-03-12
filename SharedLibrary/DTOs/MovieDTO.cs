using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DTOS
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool OnCinemas { get; set; }
        public DateTime PremierDate { get; set; }
        public string Poster { get; set; }
    }
}
