using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsCreateAsync")]
    public interface ICreateAsyncRepository<TModel, TKey>
    {
        Task<TKey> CreateAsync(TModel model);
    }
}
