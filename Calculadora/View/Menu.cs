using CalculadoraCS.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.View
{
    public class Menu 
    {
        public void interagir()
        {
            Console.Write("Insira o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Insira o operador: ");
            string operador = Console.ReadLine();

            Console.Write("Insira o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            ControllerCalculadora controller = new ControllerCalculadora();

            int resultado = controller.calcular(num1, operador, num2);

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
