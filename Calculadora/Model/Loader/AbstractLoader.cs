using CalculadoraCS.Model.Excecoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.Loader
{
    public abstract class AbstractLoader<T> : ILoader<T>
    {
        protected string pacoteBase = "CalculadoraCS.Model";

        public T criar(string opcao)
        {
            try
            {
                string className = pacoteBase + "." + opcao;
                Type type = Type.GetType(className);

                return (T)Activator.CreateInstance(type);
            } catch (Exception) {
                throw new ClasseInvalidaException("Erro: Classe instanciada é inválida.");
            }
        }

        public HashSet<T> acessaClasses()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            IEnumerable<Type> tipos = assembly.GetTypes()
                .Where(t => t.Namespace == pacoteBase && !t.IsAbstract && typeof(T).IsAssignableFrom(t));
    
            HashSet<T> instancias = new HashSet<T>();
            foreach (var tipo in tipos)
            {
                T instancia = (T)Activator.CreateInstance(tipo);
                if (instancia != null)
                {
                    instancias.Add(instancia);
                }
            }
            return instancias;
        }
    }
}
