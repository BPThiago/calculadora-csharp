using CalculadoraCS.Model.Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.Loader
{
    public class CalculadoraLoader : AbstractLoader<ICalculadora>
    {
        public CalculadoraLoader() {
            this.pacoteBase = this.pacoteBase + ".Calculadora";
        }
    }
}
