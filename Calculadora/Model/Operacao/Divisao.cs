using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.Operacao
{
    public class Divisao : IOperacaoBasica
    {
        public int calcular(int num1, int num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Erro: Divisão por zero não é permitida!");
            return num1 / num2;
        }

        public string Operador { get { return "/"; } }
        public string Nome { get { return "Divisão"; } }
    }
}
