using System.Collections.Generic;

namespace OracleBpm.Features.Domain.Contract
{
    public interface IFeatureBase <T> where T : class
    {
        void AddFeature(T entityFeatuare);

        void UpdateFeature(T entityFeatuare);

        void RemoveFeature(T entityFeatuare);

        IList<T> ListFeature(T entityFeatuare);
    }
}
