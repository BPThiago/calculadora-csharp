using CalculadoraCS.Model.DTO;
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
        public ResponseOperacaoDTO calcular(RequestOperacaoDTO requestOperacaoDTO);

        public Dictionary<string, string> getOperacoesDisponiveis();

        public string Nome { get; }
        public string Identificador { get; }
    }
}
