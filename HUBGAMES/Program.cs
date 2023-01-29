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
            Players players = new Players();
            Menus menus = new Menus();

            var nick = string.Empty;
            var password = string.Empty;
            var email = string.Empty;
            var pontos = 0;

            int optionMainMenu;
            do
            {
                Console.Clear();
                menus.MenuPrincipal();
                Console.WriteLine("MAKE YOUR CHOICE: ");
                optionMainMenu = int.Parse(Console.ReadLine());


                switch (optionMainMenu) //start submenu --> definições do usuario
                {
                    case 1:
                        int optionMenuUsuario;
                        do
                        {
                            menus.menuDefinirUsuario();
                            Console.WriteLine("\nDIGITE A OPÇÃO DESEJADA: ");
                            optionMenuUsuario = Convert.ToInt32(Console.ReadLine());


                            switch (optionMenuUsuario)
                            {

                                case 1:
                                    Console.Clear();
                                    players.RegisterUser(nick, password, email, pontos);
                                    break;
                                case 2:
                                    Console.Clear();
                                    players.Login(password, email);
                                    players.DeleteUser(nick, email, password);
                                    break;
                                case 3:
                                    Console.WriteLine("\nRETORNANDO AO MENU PRINCIPAL...");
                                    break;
                                default: 
                                    Console.Clear();
                                    Console.WriteLine("\nOPÇÃO INVÁLIDA, TENTE NOVAMENTE!!");
                                    break;
                            }
                        } while (optionMenuUsuario != 3);
                        break;


                    case 2:


                        break;
                }





            } while (optionMainMenu != 5);



            //players.RegisterUser(nick, password, email);
            // players.Login(password, email);

            //players.DeleteUser(nick, email, password);

            //players.ListarTodos();




            Console.ReadKey();
        }
    }
}


