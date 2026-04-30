using System;

namespace RoboTupiniquim.ConsoleApp.Entidades;

public static class posicao
{   
    public static string ObterPosicaoInicial()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("==>                   Robô Tupiniquim                  <==");
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("==> Informe por favor, alguns comandos para nosso ROBÔ <==");
        Console.WriteLine("----------------------------------------------------------");
        Console.Write("==> Digite a posição inicial do Tupiniquim (X Y D): ");
        string? posiIncial = Console.ReadLine();

        return posiIncial;
    }

}
