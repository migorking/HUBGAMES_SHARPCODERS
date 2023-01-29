using System;
using System.IO;
using Newtonsoft.Json;

namespace HUBGAMES.Model
{
    internal class Players : HubDeGames
    {
        public Players()
        {
            PlayerList = new List<Player>();
            Recarregar();
        }

        public void RegisterUser(string nick, string password, string email, int pontos)
        {
            Console.WriteLine("\nVOCE ESCOLHEU A PILULA VERMELHA: ");
            Console.Write("\nESCOLHA SEU NICKNAME: ");
            string nomeUsuario = Console.ReadLine();
            Console.Write("DIGITE SEU EMAIL DE ACESSO: ");
            string emailUsuario = Console.ReadLine();
            Console.Write("DIGITE SEU PASSWORD: ");
            string passwordUsuario = Console.ReadLine();
            
            int pontosUsuario = 0;

            Player user = new Player(nick, password, email, pontos);
            {
                user.Nick = nomeUsuario;
                user.Password = passwordUsuario;
                user.Email = emailUsuario;
                user.Pontos = pontosUsuario;
            }

            PlayerList.Add(user);
            Salvar();
            Console.Clear();
        }

        public bool Login(string password, string email) // faz o login do usuario
        {

            bool loginAceito = false;
            int tentativasDeLogin = 0;
            int tentativas = 1;


            while (!loginAceito && tentativasDeLogin < tentativas)
            {
                Console.Clear();
                Console.WriteLine("INICIANDO LOGIN DO USUARIO.\n");
                Console.WriteLine("INSIRA SEU EMAIL: ");
                string emailLogin = Console.ReadLine();
                Console.WriteLine("INSIRA SEU PASSWORD: ");
                string passwordLogin = Console.ReadLine();

                Player user = PlayerList.FirstOrDefault(e => e.Email == emailLogin); // metodo pra encontrar o primeiro dado igual a entrada, nesse caso o email.
                if (user != null && user.Password == passwordLogin)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nLOGIN FEITO COM SUCESO\n");
                    Console.ResetColor();
                    loginAceito = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nLOGIN NÃO PODE SER FEITO, TENTE NOVAMENTE \n");
                    Console.ResetColor();
                }

                tentativasDeLogin++;
            }

            return loginAceito;
        }

        public void DeleteUser(string nick, string email, string password)
        {
            string filePath = @"E:\SHARPCODERS\PROJETOS SHARPCODERS\HUBGAMES\Data\user.json";
            Console.WriteLine("\nA ÚNICA COISA QUE VOCÊ PODE CONTROLAR SÃO SUAS ESCOLHAS...");
            Console.WriteLine("E VOCE FEZ A SUA...\n");
            Console.Write("ME FALE SEU NICKNAME PELA ÚLTIMA VEZ: ");
            string usuarioDelete = Console.ReadLine();
            Console.Write("SEU EMAIL: ");
            string emailDelete = Console.ReadLine();
            Console.Write("SEU PASSWORD: ");
            string passwordDelete = Console.ReadLine();
            Console.ResetColor();
            string jsonString = File.ReadAllText(filePath);
            jsonString.Trim();
            List<Player> players = JsonConvert.DeserializeObject<List<Player>>(jsonString);
            players.RemoveAll(p => p.Email == emailDelete); //escolher o item mais unico para fazer a remoção.
            jsonString = JsonConvert.SerializeObject(players);
            File.WriteAllText(filePath, jsonString);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nCRITICAL HIT!!");
            Console.WriteLine("\nGAME OVER! SUA CONTA DELETADA COM SUCESSO!\n");
            Console.ResetColor();
            
        }


        public void ListarTodos()
        {
            string filePath = @"E:\SHARPCODERS\PROJETOS SHARPCODERS\HUBGAMES\Data\user.json";
            string jsonString = File.ReadAllText(filePath);
            jsonString.Trim();
            List<Player> players = JsonConvert.DeserializeObject<List<Player>>(jsonString);
            foreach (var item in players)
            {
                Console.WriteLine($"NICKNAME: {item.Nick} | EMAIL: {item.Email} | TOTAL DE PONTOS: {item.Pontos}\n");

            }
        }


        private void Salvar() // metodo para serializar e salvar o arquivo json
        {
            string filePath = @"E:\SHARPCODERS\PROJETOS SHARPCODERS\HUBGAMES\Data\user.json";
            string jsonSalvar = JsonConvert.SerializeObject(PlayerList);
            File.WriteAllText(filePath, jsonSalvar);


        } 
        private void Recarregar() // metodo para deserializar, por em uma lista e dar opcao de manipular o json
        {
            string filePath = @"E:\SHARPCODERS\PROJETOS SHARPCODERS\HUBGAMES\Data\user.json";
            if (File.Exists(filePath))
            {
                string jsonLer = File.ReadAllText(filePath);
                PlayerList = JsonConvert.DeserializeObject<List<Player>>(jsonLer);


            }

        } 

    }
}
