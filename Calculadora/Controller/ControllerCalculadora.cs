using CalculadoraCS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Controller
{
    public class ControllerCalculadora
    {
        public int calcular(int num1, string operador, int num2)
        {
            Calculadora calc = new Calculadora();
            return calc.calcular(num1, operador, num2);
        }
    }
}
