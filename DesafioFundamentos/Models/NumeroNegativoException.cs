using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class NumeroNegativoException : Exception
    {
        public NumeroNegativoException(string msg) : base(msg)
        {
            
        }
    }
}