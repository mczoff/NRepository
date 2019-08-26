using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstractions
{
    [RepositoryContract("IsUpdateAsync")]
    public interface IUpdateAsyncRepository<TModel, TKey>
    {
        Task<TKey> UpdateAsync(TModel model);
    }
}
