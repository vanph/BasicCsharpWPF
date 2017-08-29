using System;
using System.Collections.Generic;

namespace MyCountry.Repository
{
    public interface IGenericRepository<T> 
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> Get(Func<T, bool> predicate, int pageSize, int pageNumber);
    }
}
