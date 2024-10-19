using CalculadoraCS.Model.Operacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.Loader
{
    public class OperacaoLoader : AbstractLoader<IOperacao>
    {
        public OperacaoLoader() {
            this.pacoteBase = this.pacoteBase + ".Operacao";
        }
    }
}
