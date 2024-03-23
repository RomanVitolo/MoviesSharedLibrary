namespace SharedLibrary.Interfaces.Entities;

public interface IActorMovieDetailDTO
{
    public int ActorId { get; set; }
    public string Character {  get; set; }
    public string Name { get; set; }
}