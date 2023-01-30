using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUBGAMES.Model
{
    public class BatalhaNaval
    {

        public void JogarBatalhaNaval()
        {

            int[,] tabuleiro = new int[10, 10];
            int[] navios = { 2, 2, 4, 3 };
            Random rndNavios = new Random();

            foreach (int n in navios)
            {
                bool navioExiste = false;

                while (!navioExiste)
                {
                    int linha = rndNavios.Next(0, 10);
                    int coluna = rndNavios.Next(0, 10);
                    int sentido = rndNavios.Next(0, 2);

                    if (sentido == 0)
                    {
                        if (linha + n <= 10)
                        {
                            navioExiste = true;
                            for (int i = linha; i < linha + n; i++)
                            {
                                tabuleiro[i, coluna] = 1;
                            }

                        }
                    }
                    else
                    {
                        if (coluna + n <= 10)
                        {
                            navioExiste = true;
                            for (int i = coluna; i < coluna + n; i++)
                            {
                                tabuleiro[linha, i] = 1;
                            }
                        }
                    }

                }
            }

            int tentativas = 0;
            int acertos = 0;

            while (acertos < 9)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nBATALHA NAVAL\n");
                Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
                Console.WriteLine("  * * * * * * * * * *");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(i + "|");
                    for (int j = 0; j < 10; j++)
                    {
                        if (tabuleiro[i, j] == 2)
                        {
                            Console.Write("X ");
                        }
                        else if (tabuleiro[i, j] == 1) // esse trecho é para deixar o navio visivel
                        {
                            Console.Write("N ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                    Console.WriteLine("|");
                }

                Console.WriteLine("  + + + + + + + + + +");
                Console.ResetColor();

                Console.WriteLine("DIGITE UMA LINHA E UMA COLUNA ==> EX: 1 1");
                string[] chute = Console.ReadLine().Split(' ');
                int linha = Convert.ToInt32(chute[0]);
                int coluna = Convert.ToInt32(chute[1]);

                if (tabuleiro[linha, coluna] == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nEM CHEIO! VOCÊ ACERTOU!");
                    Console.ResetColor();
                    acertos++;
                    tabuleiro[linha, coluna] = 2;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nVOCÊ ERROU ESSE DISPARO, TENTE NOVAMENTE!");
                    Console.ResetColor();
                }
                tentativas++;
            }

            Console.WriteLine($"\nFIM DE JOGO! VOCÊ GANHOU!");
            Console.WriteLine($"FORAM DISPARADOS {tentativas} TIROS!\n");

        }


    }
}
