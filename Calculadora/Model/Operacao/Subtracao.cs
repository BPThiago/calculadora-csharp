using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.Operacao
{
    public class Subtracao : IOperacaoBasica
    {
        public int calcular(int num1, int num2)
        {
            return num1 - num2;
        }

        public string Operador { get { return "-"; } }
        public string Nome { get { return "Subtração"; } }
    }
}
