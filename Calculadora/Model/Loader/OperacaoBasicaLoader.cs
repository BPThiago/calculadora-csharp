using CalculadoraCS.Model.Operacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.Loader
{
    public class OperacaoBasicaLoader : AbstractLoader<IOperacaoBasica>
    {
        public OperacaoBasicaLoader()
        {
            this.pacoteBase = this.pacoteBase + ".Operacao";
        }
    }
}
