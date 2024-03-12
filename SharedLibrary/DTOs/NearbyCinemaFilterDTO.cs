using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.DTOS
{
    public class NearbyCinemaFilterDTO
    {
        [Range(-90, 90)]
        public double Latitude { get; set; }
        [Range(-180, 180)]
        public double Longitude { get; set; }
        private int distanceInKms = 10;
        private readonly int maxDistanceKms = 50;
        public int DistanceInKms 
        { 
            get {  return distanceInKms; } 
            set {  distanceInKms = ( value > maxDistanceKms) ?  maxDistanceKms : value; } 
        }
    }
}
