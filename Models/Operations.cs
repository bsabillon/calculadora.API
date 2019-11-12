using System;
using System.Collections.Generic;


namespace calculadora.API.Models
{
    public class Operations
    {
        public int OperationId { get; set; }
        public string Operator { get; set; }
        
        public double number1 { get; set; }
        public double number2 { get; set; }

        public double Result { get; set; }

    }
}