using CalculadoraCS.Model.Operacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.Calculadora
{
    public interface ICalculadora
    {
        public int calcular(int num1, string operador, int num2);

        public Dictionary<string, string> getOperacoesDisponiveis();

        public string Nome { get; }
        public string Identificador { get; }
    }
}
