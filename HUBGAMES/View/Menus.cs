using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUBGAMES.View
{
    public class Menus
    {
        public void MenuPrincipal()
        {
            Console.WriteLine("\nBEM VINDO AO GAME HUB SHARP CODERS\n");
            Console.WriteLine("1. DEFINIÇÕES DE USUARIO");
            Console.WriteLine("2. REGRAS DOS JOGOS");
            Console.WriteLine("3. JOGAR JOGO DA VELHA");
            Console.WriteLine("4. JOGAR BATALHA NAVAL");
            Console.WriteLine("5. RANKING");
            Console.WriteLine("6. SAIR");
            Console.WriteLine("");
        }

        public void menuDefinirUsuario()
        {
            Console.WriteLine("\nCENTRAL DE DEFINIÇOES\n");
            Console.WriteLine("1. CADASTRAR NOVA CONTA");
            Console.WriteLine("2. DELETAR CONTA");
            Console.WriteLine("3. MENU PRINCIPAL");
            Console.WriteLine("");

        }

        public void menuRegrasJogo()
        {
            Console.WriteLine("\nREGRAS DO JOGO");
            Console.WriteLine("1. JOGO DA VELHA");
            Console.WriteLine("2. BATALHA NAVAL");
            Console.WriteLine("3. MENU PRINCIPAL");
            Console.WriteLine("");
           
        }


    }
}
