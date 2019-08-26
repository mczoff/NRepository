using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstractions
{
    [RepositoryContract("IsCreateAsync")]
    public interface ICreateAsyncRepository<TModel, TKey>
    {
        Task<TKey> CreateAsync(TModel model);
    }
}
