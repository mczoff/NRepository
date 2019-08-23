using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsCreateAsync")]
    public interface ICreateAsyncRepository<TModel>
    {
        Task Create(TModel model);
    }
}
