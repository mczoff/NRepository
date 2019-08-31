namespace NRepository.Models
{
    /// <summary>
    /// Repositories contract
    /// </summary>
    public class RepositoryContract
    {
        public bool IsSelect { get; set; }
        public bool IsSelectAsync { get; set; }
        public bool IsDelete { get; set; }
        public bool IsDeleteAsync { get; set; }
        public bool IsCreate { get; set; }
        public bool IsCreateAsync { get; set; }
        public bool IsUpdate { get; set; }
        public bool IsUpdateAsync { get; set; }
        public bool IsCount { get; set; }
        public bool IsCountAsync { get; set; }
        public bool IsPagination { get; set; }
        public bool IsPaginationAsync { get; set; }
    }
}
