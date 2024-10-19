using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.DTO
{
    public class ResponseOperacaoDTO
    {
        private int result;
        public ResponseOperacaoDTO(int result)
        {
            this.result = result;
        }

        public int Result { get { return result; } }
    }
}
