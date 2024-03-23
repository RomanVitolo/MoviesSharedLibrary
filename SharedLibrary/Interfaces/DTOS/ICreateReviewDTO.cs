namespace SharedLibrary.Interfaces.Entities;

public interface ICreateReviewDTO
{
    public string Commentary { get; set; }  
    public int Punctuation { get; set; }
}