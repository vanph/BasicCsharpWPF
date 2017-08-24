using System.Collections.Generic;

namespace MyCountry.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected List<T> Data;
        
        protected GenericRepository()
        {
            InitData();
        }

        public IEnumerable<T> GetAll()
        {
            return Data;
        }

        protected abstract void InitData();
    }

}
