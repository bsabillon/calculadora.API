using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using calculadora.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace calculadora.API.Data
{
    public interface IOperationsRepository : IGenericRepository<Operations>, IDisposable
    {
         
    }
}