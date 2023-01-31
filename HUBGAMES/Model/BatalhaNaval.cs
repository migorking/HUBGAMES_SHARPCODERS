using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HUBGAMES.Model.HubDeGames;

namespace HUBGAMES.Model
{
    public class BatalhaNaval
    {

        public void JogarBatalhaNaval()
        {

            int[,] tabuleiro = new int[10, 10];
            int[] navios = { 2, 2 }; //Diminuir a quantidade de navios para apresentação
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

            while (acertos < 4) // quantidades de navios = a quantidade de acertos para ganhar, sempre que aumentar a frota esse numero tem que ser alterado
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


        public void PontuacaoBatalhaNaval(string nick, string password, string email, int pontos)
        {
            List<Player> scores = new List<Player>();
            string filePath = @"E:\SHARPCODERS\PROJETOS SHARPCODERS\HUBGAMES\Data\user.json";
            if (File.Exists(filePath))
            {
                string jsonPoints = File.ReadAllText(filePath);
                scores = JsonConvert.DeserializeObject<List<Player>>(jsonPoints);

            }

            bool playerExiste = false;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("YOU WIN!");
            Console.ResetColor();
            Console.WriteLine("FORNECA SEUS DADOS PARA O RANKING: ");
            Console.Write("SEU NICK REGISTRADO: ");
            string playerWin = Console.ReadLine();
            Console.Write("\nOBRIGADO, ESTAMOS GERANDO SUA PONTUACAO!");
            int playerPonto = 15;

            while (!playerExiste)
            {

                foreach (var p in scores)
                {
                    if (p.Nick == playerWin)
                    {
                        p.Pontos += playerPonto;
                        playerExiste = true;
                        break;
                    }
                }

                //salvar o json
                string jsonSalvarPoints = JsonConvert.SerializeObject(scores);
                File.WriteAllText(filePath, jsonSalvarPoints);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nPONTUAÇÃO GERADA COM SUCESSO\n");

                string jsonPoints = File.ReadAllText(filePath);
                scores = JsonConvert.DeserializeObject<List<Player>>(jsonPoints);

                if (!playerExiste)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nUSUARIO NÃO ENCONTRADO\n");
                    Console.Write("TENTE MAIS UMA VEZ: ");
                    playerWin = Console.ReadLine();
                    Console.ResetColor();
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nPONTUAÇÃO GERADA COM SUCESSO\n");

                    foreach (var points in scores)
                    {
                        if (points.Nick == playerWin)
                        {
                            Console.WriteLine($"SUA PONTUAÇÃO ATUAL É: {points.Pontos}");
                        }
                    }
                    Console.ResetColor();

                }
            }

        }

    }
}
