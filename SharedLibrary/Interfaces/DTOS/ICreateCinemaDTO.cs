namespace SharedLibrary.Interfaces.Entities;

public interface ICreateCinemaDTO
{      
    public string Name { get; set; }  
    public double Latitude { get; set; }   
    public double Longitude { get; set; }
}