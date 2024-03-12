namespace SharedLibrary.DTOS
{
    public class MovieDetailsDTO : MovieDTO
    {
        public List<GenreDTO> Genres { get; set; }
        public List<ActorMovieDetailDTO> Actors { get; set; }
    }
}
