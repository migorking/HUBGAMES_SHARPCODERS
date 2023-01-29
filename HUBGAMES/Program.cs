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
using System.ComponentModel;
using System.Data;

namespace HUBGAMES //aqui nome do projeto sempre
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Players players = new Players();
            Menus menus = new Menus();
            JogoDaVelha velha = new JogoDaVelha();

            var nick = string.Empty;
            var password = string.Empty;
            var email = string.Empty;
            var pontos = 0;

            int optionMainMenu;
            do
            {
                //Console.Clear();
                menus.MenuPrincipal();
                Console.WriteLine("MAKE YOUR CHOICE: ");
                optionMainMenu = int.Parse(Console.ReadLine());
                Console.Clear();


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

                                    if (players.Login(password, email) != true)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\nFINISH HIM!! - SEU LOGIN NÃO PODE SER FEITO\n");
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        players.DeleteUser(nick, email, password);
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("\nRETORNANDO AO MENU PRINCIPAL...");
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nOPÇÃO INVÁLIDA, TENTE NOVAMENTE!!");
                                    Console.ResetColor();
                                    break;
                            }
                        } while (optionMenuUsuario != 3);
                        break;


                    case 2:
                        int optionRegrasDoJogo;
                        do
                        {
                            menus.menuRegrasJogo();
                            Console.WriteLine("ESCOLHA O JOGO QUE VOCÊ QUER CONHECER A HISTORIA E AS REGRAS: ");
                            optionRegrasDoJogo = Convert.ToInt32(Console.ReadLine());

                            switch (optionRegrasDoJogo)
                            {
                                case 1:
                                    Console.Clear();
                                    menus.SobreJogoDaVelha();
                                    break;
                                case 2:
                                    Console.Clear();
                                    menus.SobreBatalhaNaval();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("\nRETORNANDO AO MENU PRINCIPAL...");
                                    break;
                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nOPÇÃO INVÁLIDA, TENTE NOVAMENTE!!");
                                    Console.ResetColor();
                                    break;
                            }

                        } while (optionRegrasDoJogo != 3);
                        break;
                    case 3:
                       /* Console.WriteLine("FAZER LOGIN DO PLAYER1: ");
                        players.Login(password, email);
                        Console.WriteLine("FAZER LOGIN DO PLAYER2: ");
                        players.Login(password, email);
                        JogoDaVelha velha1 = new JogoDaVelha();
                        Console.Clear();
                        velha1.JogarVelha();*/
                        players.Pontuacao(nick, password, email, pontos);


                        break;
                    case 4:

                        if (players.Login(password, email) != true)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nFINISH HIM!! - SEU LOGIN NÃO PODE SER FEITO\n");
                            Console.ResetColor();

                        }
                        break;
                }





            } while (optionMainMenu != 5);




            Console.ReadKey();
        }
    }
}


