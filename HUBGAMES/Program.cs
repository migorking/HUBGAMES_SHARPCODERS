using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using HUBGAMES.Model;
using HUBGAMES.View;
using System.Text.Json;
using static HUBGAMES.Model.HubDeGames;

namespace HUBGAMES //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Players players= new Players();

            var nick = string.Empty;
            var password = string.Empty;
            var email = string.Empty;
            

            players.RegisterUser(nick, password, email);
            // players.Login(password, email);

            //players.DeleteUser(nick, email, password);

            players.ListarTodos();

            //List<Player> listaPlayers


            Console.ReadKey();
        }
    }
}


