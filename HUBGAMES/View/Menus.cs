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
            Console.WriteLine("5. JOGAR ADIVINHA NUMERO");
            Console.WriteLine("6. RANKING");
            Console.WriteLine("7. SAIR");
            Console.WriteLine("");
        }

        public void menuDefinirUsuario() // item 1 do menu principal.
        {
            Console.WriteLine("\nCENTRAL DE DEFINIÇOES\n");
            Console.WriteLine("1. CADASTRAR NOVA CONTA");
            Console.WriteLine("2. DELETAR CONTA");
            Console.WriteLine("3. LISTAR CONTA");
            Console.WriteLine("4. MENU PRINCIPAL");
            Console.WriteLine("");

        }

        // bloco abaixo são os menus e descrições do jogo, item 2 do menu principal
        public void menuRegrasJogo()
        {
            Console.WriteLine("\nREGRAS DO JOGO\n");
            Console.WriteLine("1. JOGO DA VELHA");
            Console.WriteLine("2. BATALHA NAVAL");
            Console.WriteLine("3. JOGO ADIVINHA NÚMERO");
            Console.WriteLine("4. FAQ");
            Console.WriteLine("5. MENU PRINCIPAL");
            Console.WriteLine("");

        }

        public void menuRanking()
        {
            Console.WriteLine("\nCHAMPIONS AREA\n");
            Console.WriteLine("1. WORLD RANKING");
            Console.WriteLine("2. TODOS OS PLAYERS");
            Console.WriteLine("3. MENU PRINCIPAL");
        }

        public void SobreJogoDaVelha()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nHISTORIA DO JOGO DA VELHA\n");
            Console.ResetColor();
            Console.WriteLine(
                @"O seu nome Jogo da Velha originou-se na Inglaterra quando mulheres ao fim de tarde se 
reuniam para tomar o chá, bordar e brincar. O jogo da velha era jogado pelas senhoras de mais idade,
já que as mesmas não enxergavam bem,  e não podiam então realizar seus bordados;  
a opção de diversão então era o Jogo da Velha.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nREGRAS DO JOGO DA VELHA\n");
            Console.ResetColor();
            Console.WriteLine("1. O tabuleiro  é uma matriz  de três linhas por três colunas");
            Console.WriteLine("2. Dois jogadores escolhem uma marcação cada um, geralmente um círculo (O) e um xis (X).");
            Console.WriteLine("3. Os jogadores jogam alternadamente, uma marcação por vez, numa lacuna que esteja vazia.");
            Console.WriteLine(@"4. O objectivo é conseguir três círculos ou três xis em linha, quer horizontal, vertical ou diagonal, 
e ao mesmo tempo, quando possível, impedir o adversário de ganhar na próxima jogada.");
            Console.WriteLine("5. Quando um jogador conquista o objetivo, costuma-se riscar os três símbolos.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }

        public void SobreBatalhaNaval()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nHISTORIA DO JOGO BATALHA NAVAL\n");
            Console.ResetColor();
            Console.WriteLine(@"A brincadeira surgiu no início do século XX, mas a versão em tabuleiro só foi criada em 1967.
Soldados russos criaram o jogo na 1ª Guerra Mundial. Na versão original, dois adversários desenhavam, 
em folhas de papel, navios posicionados em um mar imaginário.
Ganhava quem descobrisse primeiro as coordenadas das embarcações do oponente.
Durante a 2ª Guerra Mundial, em 1943, foi lançado o jogo com o nome que ficou mais conhecido nos EUA: Battleship. 
Em 1967, veio a primeira versão de tabuleiro, com as clássicas maletinhas e navios de plástico encaixáveis.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nREGRAS DO JOGO BATALHA NAVAL\n");
            Console.ResetColor();
            Console.WriteLine("Cada jogador, na sua vez de jogar, seguirá o seguinte procedimento:");
            Console.WriteLine("1. Disparará 3 tiros, indicando a coordenadas do alvo através do número da linha e da letra da coluna que definem a posição.");
            Console.WriteLine(@"2. Após cada um dos tiros, o oponente avisará se acertou e, nesse caso, qual navio foi atingido. Se ele for afundado, esse fato também deverá ser informado");
            Console.WriteLine("3. A cada tiro acertado em um alvo, o oponente deverá marcar em seu tabuleiro para que possa informar quando o navio for afundado.");
            Console.WriteLine("4. Um navio é afundado quando todas as casas (quadradinhos) que formam esse navio forem atingidas(os).");
            Console.WriteLine("5. Após os 3 tiros e as respostas do opoente, a vez para para o outro jogador.");
            Console.WriteLine("6. O jogo termina quando um dos jogadores afundar todos os navios do seu oponente.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.ResetColor();

        }

        public void SobreAdivinhaNumero()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nREGRAS DO JOGO ADIVINHA NÚMERO\n");
            Console.ResetColor();
            Console.WriteLine("1. O jogador irá dar seu chute inicial.");
            Console.WriteLine("2. A cada chute que o jogador der, ele receberá uma dica se o número é maior ou menor do que ele escolheu");
            Console.WriteLine("3. O jogo termina quando você acerta o número secreto.");
            Console.WriteLine("4. O objetivo é acertar o número secreto com a menor quantidade de chutes.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }
        public void SobreFAQ()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n1.Quantos pontos eu ganho no JOGO DA VELHA?");
            Console.ResetColor();
            Console.WriteLine("R. A cada vitória no JOGO DA VELHA, o usuário leva 10 pontos\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("2.Quantos pontos eu ganho no BATALHA NAVAL?");
            Console.ResetColor();
            Console.WriteLine("R. A cada vitória no BATALHA NAVAL, o usuário leva 15 pontos\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("3.Quantos pontos eu ganho no ADIVINHA O NÚMERO?");
            Console.ResetColor();
            Console.WriteLine("R. A cada vitória no ADIVINHA O NÚMERO, o usuário leva 5 pontos\n\n");
        }

        public void GoodBye()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("IT'S NEVER GOODBYE....");
            Console.WriteLine("OBRIGADO POR USAR O GAME HUB SHARP CODERS\n");
            Console.WriteLine("Projected by Mário Igor Barbosa");
            Console.WriteLine("Turma SHARPCODERS");
            Console.WriteLine("Sponsored by ImaLearningPlace");
            Console.ResetColor();
        }

    }
}
