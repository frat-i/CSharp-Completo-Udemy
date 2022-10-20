using System;
using XadrezTabuleiro.Entities;
using XadrezTabuleiro.Entities.Enums;
using Xadrez_Console.Presentation.Entities;
using Xadrez_Console.Chess.Entities;
using Xadrez_Console.Board.Entities.Exceptions;
using Xadrez_Console.Chess.Entities;


namespace Xadrez_Console;

class Program
{
    static void Main(string[] args)
    {

        try
        {
            PartidaXadrez partida = new();

            while (!partida.Terminada)
            {
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.Tabuleiro);

                Console.WriteLine();
                Console.Write("Digite Origem: ");
                Posicao origem = Tela.LerPosicaoXadrex().ToPosicao(); 
                bool[,] posicoesPossiveis = partida.Tabuleiro.Peca(origem).MovimentosPossiveis(); // pega a peca pela posicao e mostra os movimentos q pode fazer

                Console.Clear();
                Tela.ImprimirTabuleiro(partida.Tabuleiro, posicoesPossiveis);

                Console.WriteLine();
                Console.Write("Digite destino: ");
                Posicao destino = Tela.LerPosicaoXadrex().ToPosicao();

                partida.ExecutaMovimento(origem, destino);
            }


            
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}