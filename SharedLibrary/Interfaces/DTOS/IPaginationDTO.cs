namespace SharedLibrary.Interfaces.Entities;

public interface IPaginationDTO
{
    public int Page { get; set; }
    public int RecordsPerPage { get; set; }
   
}