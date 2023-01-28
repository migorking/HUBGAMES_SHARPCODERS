using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUBGAMES.Model
{
    class HubDeGames
    {

        public class Player
        {
            public Player(string nick, string password, string email, int pontos)
            {
                Nick = nick;
                Password = password;
                Email = email;
                Pontos = pontos;
            }

            public string Nick { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }

            public int Pontos { get; set; }
        }

        public List<Player> PlayerList { get; set;}


        




















        private void Reload()
        {
            
        }
    }
}
