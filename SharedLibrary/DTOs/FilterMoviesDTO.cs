using System.Diagnostics.Eventing.Reader;

namespace SharedLibrary.DTOS
{
    public class FilterMoviesDTO
    {
        public int Page { get; set; } = 1;
        public int RecordsPerPage = 10;
        public PaginationDTO Pagination 
        {
            get { return new PaginationDTO { Page = this.Page, RecordsPerPage = this.RecordsPerPage }; }
        }

        public string Title { get; set; }
        public int GenreId { get; set; }
        public bool OnCinemas { get; set; }
        public bool NextReleases { get; set; }
        public string SortField { get; set; }
        public bool AscendingOrder { get; set; } = true;
    }
}
