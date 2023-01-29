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

        public void SobreJogoDaVelha()
        {
            Console.WriteLine("\nHISTORIA DO JOGO DA VELHA\n");
            Console.WriteLine(
                @"O seu nome Jogo da Velha originou-se na Inglaterra quando mulheres ao fim de tarde se 
reuniam para tomar o chá, bordar e brincar. O jogo da velha era jogado pelas senhoras de mais idade,
já que as mesmas não enxergavam bem,  e não podiam então realizar seus bordados;  
a opção de diversão então era o Jogo da Velha.");
            
            Console.WriteLine("\nREGRAS DO JOGO DA VELHA\n");
            Console.WriteLine("1. O tabuleiro  é uma matriz  de três linhas por três colunas");
            Console.WriteLine("2. Dois jogadores escolhem uma marcação cada um, geralmente um círculo (O) e um xis (X).");
            Console.WriteLine("3. Os jogadores jogam alternadamente, uma marcação por vez, numa lacuna que esteja vazia.");
            Console.WriteLine(@"4. O objectivo é conseguir três círculos ou três xis em linha, quer horizontal, vertical ou diagonal, 
e ao mesmo tempo, quando possível, impedir o adversário de ganhar na próxima jogada.");
            Console.WriteLine("5. Quando um jogador conquista o objetivo, costuma-se riscar os três símbolos.");
          
        }

        public void SobreBatalhaNaval()
        {
            Console.WriteLine("\nHISTORIA DO JOGO BATALHA NAVAL\n");
            Console.WriteLine(@"A brincadeira surgiu no início do século XX, mas a versão em tabuleiro só foi criada em 1967.
Soldados russos criaram o jogo na 1ª Guerra Mundial. Na versão original, dois adversários desenhavam, 
em folhas de papel, navios posicionados em um mar imaginário.
Ganhava quem descobrisse primeiro as coordenadas das embarcações do oponente.
Durante a 2ª Guerra Mundial, em 1943, foi lançado o jogo com o nome que ficou mais conhecido nos EUA: Battleship. 
Em 1967, veio a primeira versão de tabuleiro, com as clássicas maletinhas e navios de plástico encaixáveis.");

            Console.WriteLine("\nREGRAS DO JOGO BATALHA NAVAL\n");
            Console.WriteLine("Cada jogador, na sua vez de jogar, seguirá o seguinte procedimento:");
            Console.WriteLine("1. Disparará 3 tiros, indicando a coordenadas do alvo através do número da linha e da letra da coluna que definem a posição.");
            Console.WriteLine(@"2. Após cada um dos tiros, o oponente avisará se acertou e, nesse caso, qual navio foi atingido. Se ele for afundado, esse fato também deverá ser informado");
            Console.WriteLine("3. A cada tiro acertado em um alvo, o oponente deverá marcar em seu tabuleiro para que possa informar quando o navio for afundado.");
            Console.WriteLine("4. Um navio é afundado quando todas as casas (quadradinhos) que formam esse navio forem atingidas(os).");
            Console.WriteLine("5. Após os 3 tiros e as respostas do opoente, a vez para para o outro jogador.");
            Console.WriteLine("6. O jogo termina quando um dos jogadores afundar todos os navios do seu oponente.");

        }


    }
}
