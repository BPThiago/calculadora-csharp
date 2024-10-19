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
        public string escolherCalculadora()
        {
            Console.WriteLine("Escolha a calculadora que deseja:");
            Dictionary<string, string> calculadorasMap = ControllerCalculadora.getCalculadorasDisponiveis();

            foreach (string key in calculadorasMap.Keys)
            {
                Console.WriteLine("(" + key + ") " + calculadorasMap[key]);
            }
            Console.Write("Escolha: ");
            return Console.ReadLine();
        }
        public void interagir(string idCalc)
        {
            ControllerCalculadora controller = new ControllerCalculadora(idCalc);

            Console.Write("Insira o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Dictionary<string, string> operacoes = controller.getOperacoesDisponiveis();
            Console.WriteLine("Insira o operador");
            foreach (string key in operacoes.Keys)
            {
                Console.WriteLine("(" + key + ") " + operacoes[key]);
            }
            Console.Write("Operador: ");
            string operador = Console.ReadLine();

            Console.Write("Insira o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = controller.calcular(num1, operador, num2);

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
