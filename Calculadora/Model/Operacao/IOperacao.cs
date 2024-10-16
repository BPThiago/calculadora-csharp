using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.Operacao
{
    public interface IOperacao
    {
        public int calcular(int num1, int num2);
    }
}
