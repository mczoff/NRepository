using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsDeleteAsync")]
    public interface IDeleteAsyncRepository<TModel, TKey>
    {
        Task Delete(TModel key);
        Task Delete(TKey key);
    }
}
