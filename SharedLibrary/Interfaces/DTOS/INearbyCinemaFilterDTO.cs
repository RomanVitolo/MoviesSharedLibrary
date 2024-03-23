namespace SharedLibrary.Interfaces.Entities;

public interface INearbyCinemaFilterDTO
{
    public double Latitude { get; set; }  
    public double Longitude { get; set; }    
    public int DistanceInKms { get; set; }   
    
}