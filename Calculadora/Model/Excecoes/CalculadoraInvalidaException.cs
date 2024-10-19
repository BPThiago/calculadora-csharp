using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.Excecoes
{
    public class CalculadoraInvalidaException : ClasseInvalidaException
    {
        public CalculadoraInvalidaException(string msg) : base(msg)
        {
        }
    }
}
