using CalculadoraCS.Model.Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.DTO
{
    public class RequestOperacaoDTO
    {
        private int num1, num2;
        private string operador;

        public RequestOperacaoDTO(int num1, string operador, int num2)
        {
            this.operador = operador;
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Num1 { get { return num1; } }
        public int Num2 { get { return num2; } }
        public string Operador { get { return operador; } }
    }
}
