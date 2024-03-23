namespace SharedLibrary.Interfaces.Entities;

public interface IMovieDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool OnCinemas { get; set; }
    public DateTime PremierDate { get; set; }
    public string Poster { get; set; }
}