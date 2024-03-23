namespace SharedLibrary.Interfaces.Entities;

public interface IMoviePatchDTO
{
    public string Title { get; set; }
    public bool OnCinemas { get; set; }
    public DateTime PremierDate { get; set; }
}