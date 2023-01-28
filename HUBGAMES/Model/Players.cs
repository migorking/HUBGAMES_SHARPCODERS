using System;
using System.IO;
using Newtonsoft.Json;

namespace HUBGAMES.Model
{
    internal class Players : HubDeGames
    {

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

        public Players()
        {
            PlayerList = new List<Player>();
            Recarregar();
        }





        public bool Login(string password, string email)
        {
            Console.WriteLine("INSIRA SEU EMAIL: ");
            string emailLogin = Console.ReadLine();
            Console.WriteLine("INSIRA SEU PASSWORD: ");
            string passwordLogin = Console.ReadLine();

            Player user = PlayerList.FirstOrDefault(e => e.Email == emailLogin);
            if (user != null && user.Password == passwordLogin)
            {
                return true;
            }
            return false;
        }

        public void DeleteUser()
        {

        }


        private void Salvar()
        {
            string filePath = @"E:\SHARPCODERS\PROJETOS SHARPCODERS\HUBGAMES\Data\user.json";
            string jsonSalvar = JsonConvert.SerializeObject(PlayerList);
            File.WriteAllText(filePath, jsonSalvar);
        }
        private void Recarregar()
        {
            if (File.Exists("user.json"))
            {
                string jsonLer = File.ReadAllText("user.json");
                PlayerList = JsonConvert.DeserializeObject<List<Player>>(jsonLer);
            }

        }

    }
}
