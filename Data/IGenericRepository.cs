using System.Collections.Generic;
using System.Threading.Tasks;


namespace calculadora.API.Data
{
    public interface IGenericRepository<T> where T: class
    {
        Task Add(T entity);
        Task Delete(object id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(object id);
       
         
    }
}