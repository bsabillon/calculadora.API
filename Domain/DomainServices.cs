using calculadora.API.Models;
using System;
using System.Threading.Tasks;


namespace calculadora.API.Domain
{
    public class DomainServices : Operations
    {
        
        public object Sumar(Operations operation)
        {
           operation.Result = operation.number1 + operation.number2;
           return operation;
        }

        public object Restar(Operations operation)
        {
           operation.Result = operation.number1 + operation.number2;
           return operation;
        }

        public object Multiplicar(Operations operation)
        {
           operation.Result = operation.number1 * operation.number2; 
           return operation;
        }

        public object Dividir(Operations operation)
        {
            operation.Result = operation.number1 / operation.number2;
            return operation;
        }

        public object Potenciar(Operations operation)
        {
            operation.Result = Math.Pow(operation.number1, operation.number2);
            return operation;
        }

         public object CalcularRaiz(Operations operation)
        {
            operation.Result = Math.Sqrt(operation.number1);
            return operation;
        }


    }
}