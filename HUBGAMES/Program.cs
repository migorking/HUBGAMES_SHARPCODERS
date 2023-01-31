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
            BatalhaNaval bN = new BatalhaNaval();
            AdivinhaNumero adivinhaNum = new AdivinhaNumero();


            var nick = string.Empty;
            var password = string.Empty;
            var email = string.Empty;
            var pontos = 0;

            int optionMainMenu;
            do
            {

                menus.MenuPrincipal();
                Console.Write("MAKE YOUR CHOICE: ");
                optionMainMenu = int.Parse(Console.ReadLine());
                Console.Clear();


                switch (optionMainMenu) //start submenu --> definições do usuario
                {
                    case 1:
                        int optionMenuUsuario;
                        do
                        {
                            menus.menuDefinirUsuario();
                            Console.Write("\nMAKE YOUR CHOICE: ");
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
                                    Console.Clear();
                                    players.ListarTodos();
                                    break;

                                case 4:
                                    Console.WriteLine("\nRETORNANDO AO MENU PRINCIPAL...");
                                    Console.Clear();
                                    break;

                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nOPÇÃO INVÁLIDA, TENTE NOVAMENTE!!");
                                    Console.ResetColor();
                                    break;
                            }
                        } while (optionMenuUsuario != 4);
                        break;


                    case 2:
                        int optionRegrasDoJogo;
                        do
                        {
                            menus.menuRegrasJogo();

                            Console.Write("\nMAKE YOUR CHOICE: ");
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
                                    menus.SobreAdivinhaNumero();
                                    break;
                                case 4:
                                    Console.Clear();
                                    menus.SobreFAQ();
                                    break;
                                case 5:
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

                        } while (optionRegrasDoJogo != 5);
                        break;

                    case 3: // Aqui faz o login e joga jogo da velha.
                        bool loginTicToe = false;

                        while (!loginTicToe)
                        {
                            Console.WriteLine("LOGIN PLAYER 1: ");
                            players.Login(password, email);
                            Console.WriteLine("LOGIN PLAYER 2: ");
                            if (players.Login(password, email) == true)
                            {
                                loginTicToe = true;
                            }

                        }
                        Console.Clear();
                        Console.WriteLine("\n\nSTARTING GAME.......\n\n");
                        velha.JogarVelha();
                        players.PontuacaoJogoDaVelha(nick, password, email, pontos);
                        break;

                    case 4:
                        bool loginBn = false;

                        while (!loginBn)
                        {

                            if (players.Login(password, email) == !false)
                            {
                                loginBn = true;
                            }

                        }
                        Console.Clear();
                        Console.WriteLine("\n\nSTARTING GAME.......\n\n");
                        bN.JogarBatalhaNaval();
                        bN.PontuacaoBatalhaNaval(nick, password, email, pontos);
                        break;


                    case 5:
                        bool loginAdivinhaNum = false;

                        while (!loginAdivinhaNum)
                        {

                            if (players.Login(password, email) == !false)
                            {
                                loginAdivinhaNum = true;
                            }

                        }
                        Console.Clear();
                        Console.WriteLine("\n\nSTARTING GAME.......\n\n");
                        adivinhaNum.JogarAdivinhaNumero();
                        adivinhaNum.PontuacaoAdivinhaNum(nick, password, email, pontos);

                        break;

                    case 6: // parte de ranking
                        int optionRanking;
                        do
                        {
                            menus.menuRanking();
                            Console.Write("\nMAKE YOUR CHOICE: ");
                            optionRanking = Convert.ToInt32(Console.ReadLine());

                            switch (optionRanking)
                            {
                                case 1:
                                    players.RankingTotal(nick, pontos);
                                    break;

                                case 2:
                                    players.ListarTodos();
                                    break;

                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("\nRETORNANDO AO MENU PRINCIPAL...");
                                    break;

                                default:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("\nOPÇÃO INVÁLIDA, TENTE NOVAMENTE!!\n");
                                    Console.ResetColor();
                                    break;
                            }

                        } while (optionRanking != 3);
                        break;
                    case 7:
                        menus.GoodBye();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nOPÇÃO INVÁLIDA, TENTE NOVAMENTE!!\n");
                        Console.ResetColor();
                        break;
                }

            } while (optionMainMenu != 7);




            Console.ReadKey();
        }
    }
}


