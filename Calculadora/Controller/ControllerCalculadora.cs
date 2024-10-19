using CalculadoraCS.Model.Calculadora;
using CalculadoraCS.Model.DTO;
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

        public ControllerCalculadora(RequestCalculadoraDTO requestCalculadoraDTO)
        {
            calc = AbstractCalculadora.criar(requestCalculadoraDTO);
        }

        public ResponseOperacaoDTO calcular(RequestOperacaoDTO requestOperacaoDTO)
        {
            return calc.calcular(requestOperacaoDTO);
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
