using CalculadoraCS.Model.Excecoes;
using CalculadoraCS.Model.Loader;
using CalculadoraCS.Model.Operacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.Calculadora
{
    public abstract class AbstractCalculadora : ICalculadora
    {
        protected HashSet<IOperacao> operacoes;
        protected Dictionary<string, string> operacoesMap;

        public AbstractCalculadora()
        {
            operacoes = new HashSet<IOperacao>();
            operacoesMap = new Dictionary<string, string>();
            fillOperacoes();
        }

        public int calcular(int num1, string operador, int num2)
        {
            IOperacao op = mapOperacao(operador);
            
            return op.calcular(num1, num2);
        }

        private IOperacao mapOperacao(string operador)
        {
            foreach (IOperacao op in operacoes)
            {
                if (op.Operador.Equals(operador))
                    return op;
            }
            throw new OperacaoInvalidaException("Erro: Operação inválida.");
        }

        protected abstract void fillOperacoes();

        public Dictionary<string, string> getOperacoesDisponiveis()
        {
            return operacoesMap;
        }

        public abstract string Nome { get; }
        public abstract string Identificador { get; }

        public static Dictionary<string, string> getCalculadorasDisponiveis()
        {
            ILoader<ICalculadora> loader = new CalculadoraLoader();
            HashSet<ICalculadora> allCalculadoras = loader.acessaClasses();

            Dictionary<string, string> calculadorasMap = new Dictionary<string, string>();

            foreach (ICalculadora calc in allCalculadoras)
            {
                calculadorasMap.Add(calc.Identificador, calc.Nome);
            }

            return calculadorasMap;
        }

        public static ICalculadora criar(string idCalc)
        {
            ILoader<ICalculadora> loader = new CalculadoraLoader();
            HashSet<ICalculadora> allCalculadoras = loader.acessaClasses();

            foreach (ICalculadora calc in allCalculadoras)
            {
                if (calc.Identificador.Equals(idCalc))
                    return calc;
            }
            throw new CalculadoraInvalidaException("Erro: Calculadora escolhida é inválida!");
        }
    }
}
