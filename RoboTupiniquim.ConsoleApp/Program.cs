using System;
using RoboTupiniquim.ConsoleApp.Entidades;

class Program
{
    static void Main()
    {
        while (true)
        {
            string posiIncial = posicao.ObterPosicaoInicial();

            //eliminando os espaços da string que o usuário digitou
            string[] partes = posiIncial.Split(' ');

            //recuperando do array e recebendo por variavel
            int x = int.Parse(partes[0]);
            int y = int.Parse(partes[1]);
            char direcao = char.ToUpper(partes[2][0]);

            //"EMEMEMEMM";
            Console.Write("==> Digite os comandos para o Tupiniquim: ");
            string? comandos = Console.ReadLine().ToUpper();

            char[] instrucoes = comandos.ToCharArray();


            //percorrendo o camando da sequencia
            foreach (char comando in instrucoes)
            {
                if (comando == 'E')
                {
                    //virando a esquerda
                    if (direcao == 'N') 
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'O') 
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'S') 
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'L') 
                    {
                        direcao = 'N';
                    }
                }
                else if (comando == 'D')
                {
                    // virando a direita
                    if (direcao == 'N') 
                    {
                        direcao = 'L';
                    }
                    else if (direcao == 'L') 
                    {
                        direcao = 'S';
                    }
                    else if (direcao == 'S') 
                    {
                        direcao = 'O';
                    }
                    else if (direcao == 'O') 
                    {
                        direcao = 'N';
                    }
                }
                else if (comando == 'M')
                {
                    // movendo
                    if (direcao == 'N') 
                    {
                        y++;
                    }
                    else if (direcao == 'S') 
                    {
                        y--;
                    }
                    else if (direcao == 'L') 
                    {
                        x++;
                    }
                    else if (direcao == 'O') 
                    {
                        x--;
                    }
                }
            }

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"==> O Tupiniquim agora esta em: {x} {y} {direcao}");

            Console.WriteLine("----------------------------------------------------------");
                Console.Write("Deseja continuar? (s/N) -> ");
                string? opcao = Console.ReadLine().ToUpper();

                if (opcao != "S")
                {
                    break;
                }
        }
    }
}