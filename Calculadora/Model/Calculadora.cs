using CalculadoraCS.Model.Operacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model
{
    public class Calculadora
    {
        public int calcular(int num1, string operador, int num2)
        {
            IOperacao op;
            switch (operador)
            {
                case "+":
                    op = new Soma();
                    break;
                case "-":
                    op = new Subtracao();
                    break;
                case "*":
                    op = new Multiplicacao();
                    break;
                case "/":
                    op = new Divisao();
                    break;
                default:
                    op = new Soma();
                    break;
                // TODO: Aplicar exceção em caso de default
            }

            return op.calcular(num1, num2);
        }
    }
}
