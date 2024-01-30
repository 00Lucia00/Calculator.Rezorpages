using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain
{
    public class CalculationResult
    {
        public bool Successful {  get; set; }

        public float? Result { get; set; }
        
        public Exception? Error { get; set; }


    }
}
