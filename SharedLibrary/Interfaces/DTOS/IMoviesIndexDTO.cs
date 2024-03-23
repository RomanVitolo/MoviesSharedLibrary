namespace SharedLibrary.Interfaces.Entities;

public interface IMoviesIndexDTO
{
    public List<IMovieDTO> NextReleases { get; set; }
    public List<IMovieDTO> OnCinemas { get; set;}
}