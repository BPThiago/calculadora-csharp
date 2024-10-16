using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.Operacao
{
    public class Soma : IOperacao
    {
        public int calcular(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class Subtracao : IOperacao
    {
        public int calcular(int num1, int num2)
        {
            return num1 - num2;
        }
    }

    public class Multiplicacao : IOperacao
    {
        public int calcular(int num1, int num2)
        {
            return num1 * num2;
        }
    }

    public class Divisao : IOperacao
    {
        public int calcular(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
