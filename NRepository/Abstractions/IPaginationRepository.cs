using NRepository.Attributes;

namespace NRepository.Abstractions
{
    /// <summary>
    /// Pagination interface.
    /// </summary>
    /// <typeparam name="TModel">Model repository</typeparam>
    [RepositoryContract("IsPagination")]
    public interface IPaginationRepository<TModel>
    {
        TModel[] SelectPage(int page, int count);
    }
}
