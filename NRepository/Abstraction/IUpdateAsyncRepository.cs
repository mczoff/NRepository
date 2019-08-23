using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsUpdateAsync")]
    public interface IUpdateAsyncRepository<TModel, TKey>
    {
        Task UpdateAsync(TModel model, TKey key);
    }
}
