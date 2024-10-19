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
    public class CalculadoraBasica : AbstractCalculadora
    {
        protected override void fillOperacoes()
        {
            ILoader<IOperacaoBasica> loader = new OperacaoBasicaLoader();
            HashSet<IOperacaoBasica> allOperacoes = loader.acessaClasses();
            foreach (IOperacao op in allOperacoes)
            {
                operacoes.Add(op);
                operacoesMap.Add(op.Operador, op.Nome);
            }
            operacoes.Union(allOperacoes);
        }

        public override string Nome { get { return "Calculadora Básica"; } }
        public override string Identificador { get { return "cb"; } }
    }
}
