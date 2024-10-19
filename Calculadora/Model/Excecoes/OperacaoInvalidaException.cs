using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.Excecoes
{
    public class OperacaoInvalidaException : ClasseInvalidaException
    {
        public OperacaoInvalidaException(string msg) : base(msg)
        {
        }
    }
}
