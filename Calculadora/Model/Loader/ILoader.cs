using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.Loader
{
    public interface ILoader<T>
    {
        T criar(string opcao);

        HashSet<T> acessaClasses();
    }
}
