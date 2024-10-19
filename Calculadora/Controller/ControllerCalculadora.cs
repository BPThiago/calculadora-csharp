using CalculadoraCS.Model.Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Controller
{
    public class ControllerCalculadora
    {
        private ICalculadora calc;

        public ControllerCalculadora(string id)
        {
            calc = AbstractCalculadora.criar(id);
        }

        public int calcular(int num1, string operador, int num2)
        {
            return calc.calcular(num1, operador, num2);
        }

        public Dictionary<string, string> getOperacoesDisponiveis()
        {
            return calc.getOperacoesDisponiveis();
        }

        public static Dictionary<string, string> getCalculadorasDisponiveis()
        {
            Dictionary<string, string> calculadorasMap = AbstractCalculadora.getCalculadorasDisponiveis();
            return calculadorasMap;
        }
    }
}
