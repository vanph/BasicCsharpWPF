using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCountry.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected List<T> Data { get; set; }
        
        protected GenericRepository()
        {
            InitData();
        }

        public IEnumerable<T> GetAll()
        {
            return Data;
        }

        public IEnumerable<T> Get(Func<T, bool> predicate, int pageSize, int pageNumber)
        {
            if (predicate == null)
            {
                return Data.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            }
            return Data.Where(predicate).Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }

        protected abstract void InitData();
    }

}
