using System;
using System.Threading.Tasks;

namespace calculadora.API.Data
{
    public interface IUnitOfWork
    {
         IOperationsRepository Operations {get;}

         Task<int> Complete();
    }
}