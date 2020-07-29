using OracleBpm.Features.Domain.Contract;

namespace OracleBpm.Features.Data.Repositorys
{
    public interface IFeatureBaseRepository <T>: IFeatureBase<T> where T: class
    {

    }
}
