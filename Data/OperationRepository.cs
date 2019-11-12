using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using calculadora.API.Models;
using Microsoft.EntityFrameworkCore;

namespace calculadora.API.Data
{
    public class OperationRepository : GenericRepository<Operations>, IOperationsRepository
    {
        private bool disposed = false;
        private readonly DataContext _context;
     
        public OperationRepository(DataContext context) : base(context)
        {
           
            _context = context;
        }
        protected virtual void Dispose(bool disposing)        
        {            
            if (!this.disposed)            
            {                
                if (disposing)                
                {                    
                    _context.Dispose();                
                }
            }            
            this.disposed = true;        
        }        
        public void Dispose()
        {
           Dispose(true);            
            GC.SuppressFinalize(this);
        }

        
    }
}