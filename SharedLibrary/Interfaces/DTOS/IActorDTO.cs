namespace SharedLibrary.Interfaces.Entities;

public interface IActorDTO
{
    public int Id { get; set; }    
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string Photo { get; set; } 
}