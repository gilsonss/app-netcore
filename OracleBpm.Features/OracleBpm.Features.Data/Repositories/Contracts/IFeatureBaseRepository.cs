using OracleBpm.Features.Domain.Contract;

namespace OracleBpm.Features.Data.Repositories.Contracts
{
    public interface IFeatureBaseRepository <T>: IFeatureBase<T> where T: class
    {

    }
}
