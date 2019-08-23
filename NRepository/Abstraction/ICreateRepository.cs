using NRepository.Attributes;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsCreate")]
    public interface ICreateRepository<TModel>
    {
        void Create(TModel model);
    }
}
