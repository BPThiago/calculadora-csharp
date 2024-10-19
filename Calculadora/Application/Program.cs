using CalculadoraCS.Controller;
using CalculadoraCS.Model.DTO;
using CalculadoraCS.Model.Excecoes;
using CalculadoraCS.View;
using System;
using System.Diagnostics.Metrics;

namespace CalculadoraCS.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Menu menu = new Menu();
                RequestCalculadoraDTO requestCalculadoraDTO = menu.escolherCalculadora();
                ControllerCalculadora controller = new ControllerCalculadora(requestCalculadoraDTO);
                RequestOperacaoDTO requestOperacaoDTO = menu.interagir(controller);
                ResponseOperacaoDTO responseOperacaoDTO = controller.calcular(requestOperacaoDTO);
                menu.exibirResultado(responseOperacaoDTO);
            } catch (ClasseInvalidaException ex) {
                Console.WriteLine(ex.Message);
            } catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            } catch (Exception ex)
            {
                Console.WriteLine("Vishhhhhh..");
            }
        }
    }
}