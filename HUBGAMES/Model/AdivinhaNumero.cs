using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HUBGAMES.Model.HubDeGames;

namespace HUBGAMES.Model
{
    public class AdivinhaNumero
    {

        public void JogarAdivinhaNumero()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nADIVINHE O NUMERO SECRETO\n");

            Console.WriteLine("EMBARALHANDO OS NUMEROS.....");
            int numeroSecreto = new Random().Next(1, 101);
            Console.WriteLine(numeroSecreto); // mostrar numero para facilitar na apresentação.
            int chute = 0;
            int qntDeChute = 0;
            while (chute != numeroSecreto)
            {
                Console.WriteLine("\nTENTE ACERTAR UM NÚMERO ENTRE 1 e 100: ");
                string tentativa = Console.ReadLine();
                chute = int.Parse(tentativa);
                if (chute < numeroSecreto)
                {
                    Console.WriteLine("\nXIIII, MUITOO LONGE, TENTE UM NÚMERO MENOR...\n");
                    qntDeChute++;
                }
                else if (chute > numeroSecreto)
                {
                    Console.WriteLine("\nEITAA, FALTA FORÇA, TENTE UM NÚMERO MAIOR...\n");
                    qntDeChute++;
                }
            }
            Console.WriteLine("\nPARABÉNS, VOCÊ CONSEGUIU DESCOBRIR O NUMERO! \n");
            Console.WriteLine($"VOCÊ GASTOU {qntDeChute}\n");
            Console.WriteLine(" ------------------------------------------------------------");
            Console.ResetColor();
        }

        public void PontuacaoAdivinhaNum(string nick, string password, string email, int pontos)
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
            int playerPonto = 5;

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
