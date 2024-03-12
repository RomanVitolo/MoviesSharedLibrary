namespace SharedLibrary.DTOS
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        public string Commentary { get; set; }
        public int Punctuation { get; set; }
        public int MovieId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
