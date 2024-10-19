using CalculadoraCS.View;
using System;
using System.Diagnostics.Metrics;

namespace CalculadoraCS.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            string idCalc = menu.escolherCalculadora();
            int resultado = menu.interagir(idCalc);
            menu.exibirResultado(resultado);
        }
    }
}