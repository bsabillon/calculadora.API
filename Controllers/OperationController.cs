using System.Threading.Tasks;
using calculadora.API.Data;
using calculadora.API.Models;
using Microsoft.AspNetCore.Mvc;
using calculadora.API.Domain;
using System;

namespace calculadora.API.Controllers
{

    [ApiController]
    [Route("calculadora/api")]
    public class OperationController : ControllerBase
    {
        
        private readonly IOperationsRepository _repo;
        private readonly IUnitOfWork _unitOfWork;
        public DomainServices _service;
        public OperationController(IOperationsRepository repo, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var operations = await _unitOfWork.Operations.GetAll();
            return Ok(operations);
        }

        [HttpPost("sumar")]
        public async Task<IActionResult> AddSuma(Operations operation)
        {
           operation.Result = operation.number1 + operation.number2;
           await _unitOfWork.Operations.Add(operation);
           await _unitOfWork.Complete();
           return Ok(operation); 
        }

         [HttpPost("restar")]
        public async Task<IActionResult> AddResta(Operations operation)
        {
           operation.Result = operation.number1 - operation.number2; 
           await _unitOfWork.Operations.Add(operation);
           await _unitOfWork.Complete();
           return Ok(operation); 
        }

         [HttpPost("multiplicar")]
        public async Task<IActionResult> AddMultiplicacion(Operations operation)
        {
           operation.Result = operation.number1 * operation.number2; 
           await _unitOfWork.Operations.Add(operation);
           await _unitOfWork.Complete();
           return Ok(operation); 
        }

         [HttpPost("dividir")]
        public async Task<IActionResult> AddDivision(Operations operation)
        {
           operation.Result = operation.number1 / operation.number2; 
           await _unitOfWork.Operations.Add(operation);
           await _unitOfWork.Complete();
           return Ok(operation); 
        }
         [HttpPost("exponencial")]
        public async Task<IActionResult> AddExponencial(Operations operation)
        {
           operation.Result = Math.Pow(operation.number1, operation.number2);
           await _unitOfWork.Operations.Add(operation);
           await _unitOfWork.Complete();
           return Ok(operation); 
        }
         [HttpPost("raiz")]
        public async Task<IActionResult> AddRaiz(Operations operation)
        {
           operation.Result = Math.Sqrt(operation.number1);
           await _unitOfWork.Operations.Add(operation);
           await _unitOfWork.Complete();
           return Ok(operation); 
        }

    }
}