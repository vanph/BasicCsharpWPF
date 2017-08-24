using System.Collections.Generic;

namespace MyCountry.Repository
{
    public interface IGenericRepository<T> 
    {
        IEnumerable<T> GetAll();
    }
}
