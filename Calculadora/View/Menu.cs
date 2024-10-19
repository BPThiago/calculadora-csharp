using CalculadoraCS.Controller;
using CalculadoraCS.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.View
{
    public class Menu 
    {
        public RequestCalculadoraDTO escolherCalculadora()
        {
            Console.WriteLine("Escolha a calculadora que deseja:");
            Dictionary<string, string> calculadorasMap = ControllerCalculadora.getCalculadorasDisponiveis();

            foreach (string key in calculadorasMap.Keys)
            {
                Console.WriteLine("(" + key + ") " + calculadorasMap[key]);
            }
            Console.Write("Escolha: ");
            return new RequestCalculadoraDTO(Console.ReadLine());
        }
        public RequestOperacaoDTO interagir(ControllerCalculadora controller)
        {
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

            return new RequestOperacaoDTO(num1, operador, num2);
        }

        public void exibirResultado(ResponseOperacaoDTO responseOperacaoDTO) {
            Console.WriteLine("O resultado da operação é: " + responseOperacaoDTO.Result);
        }
    }
}
