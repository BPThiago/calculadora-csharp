using CalculadoraCS.Controller;
using CalculadoraCS.Model.DTO;
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
            RequestCalculadoraDTO requestCalculadoraDTO = menu.escolherCalculadora();
            ControllerCalculadora controller = new ControllerCalculadora(requestCalculadoraDTO);
            RequestOperacaoDTO requestOperacaoDTO = menu.interagir(controller);
            ResponseOperacaoDTO responseOperacaoDTO = controller.calcular(requestOperacaoDTO);
            menu.exibirResultado(responseOperacaoDTO);
        }
    }
}