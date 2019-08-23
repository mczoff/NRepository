using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsDeleteAsync")]
    public interface IDeleteAsyncRepository<TKey>
    {
        Task Delete(TKey key);
    }
}
