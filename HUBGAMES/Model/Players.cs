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

        public void RegisterUser(string nick, string password, string email)
        {

            Console.WriteLine("DIGITE SEU NICKNAME: ");
            string nomeUsuario = Console.ReadLine();
            Console.WriteLine("DIGITE SEU PASSWORD: ");
            string passwordUsuario = Console.ReadLine();
            Console.WriteLine("DIGITE SEU EMAIL: ");
            string emailUsuario = Console.ReadLine();

            Player user = new Player(nick, password, email);
            {
                user.Nick = nomeUsuario;
                user.Password = passwordUsuario;
                user.Email = emailUsuario;
            }

            PlayerList.Add(user);
            Salvar();

        }

        public bool Login(string password, string email) // faz o login do usuario
        {
            Console.WriteLine("INSIRA SEU EMAIL: ");
            string emailLogin = Console.ReadLine();
            Console.WriteLine("INSIRA SEU PASSWORD: ");
            string passwordLogin = Console.ReadLine();

            Player user = PlayerList.FirstOrDefault(e => e.Email == emailLogin);
            if (user != null && user.Password == passwordLogin)
            {
                Console.WriteLine("Usuario Logado com Sucesso");
                return true;
            }
            Console.WriteLine("Falha no login");
            return false;
        }

        public void DeleteUser(string nick, string email, string password)
        {
            string filePath = @"E:\SHARPCODERS\PROJETOS SHARPCODERS\HUBGAMES\Data\user.json";
            Console.WriteLine("INSIRA SEU USUARIO: ");
            string usuarioDelete = Console.ReadLine();
            Console.WriteLine("INSIRA SEU EMAIL: ");
            string emailDelete = Console.ReadLine();
            Console.WriteLine("INSIRA SEU PASSWORD: ");
            string passwordDelete = Console.ReadLine();

            
            string jsonString = File.ReadAllText(filePath);
            jsonString.Trim();
            List<Player> players = JsonConvert.DeserializeObject<List<Player>>(jsonString);

            players.RemoveAll(p => p.Email == emailDelete); //escolher o item mais unico para fazer a remoção.
            jsonString = JsonConvert.SerializeObject(players);
            File.WriteAllText(filePath, jsonString);


        }


        public void ListarTodos()
        {
            string filePath = @"E:\SHARPCODERS\PROJETOS SHARPCODERS\HUBGAMES\Data\user.json";
            string jsonString = File.ReadAllText(filePath);
            jsonString.Trim();
            List<Player> players = JsonConvert.DeserializeObject<List<Player>>(jsonString);
            foreach (var item in players)
            {
                Console.WriteLine(item);
            }
        }


        private void Salvar()
        {
            string filePath = @"E:\SHARPCODERS\PROJETOS SHARPCODERS\HUBGAMES\Data\user.json";
            string jsonSalvar = JsonConvert.SerializeObject(PlayerList);
            File.WriteAllText(filePath, jsonSalvar);
            
            
        }
        private void Recarregar()
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
