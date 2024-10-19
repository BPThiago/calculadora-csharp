using CalculadoraCS.View;
using System;
using System.Diagnostics.Metrics;

namespace CalculadoraCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            string idCalc = menu.escolherCalculadora();
            menu.interagir(idCalc);
        }
    }
}