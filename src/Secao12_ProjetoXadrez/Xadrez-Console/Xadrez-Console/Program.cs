using Xadrez_Console.Board.Entities.Exceptions;
using Xadrez_Console.Chess.Entities;
using Xadrez_Console.Presentation.Entities;
using XadrezTabuleiro.Entities;


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
                try
                {
                    Console.Clear();
                    Tela.ImprimirPartida(partida);


                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrex().ToPosicao();
                    partida.ValidarPosicaoOrigem(origem);


                    bool[,] posicoesPossiveis = partida.Tabuleiro.Peca(origem).MovimentosPossiveis(); // pega a peca pela posicao e mostra os movimentos q pode fazer

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tabuleiro, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrex().ToPosicao();
                    partida.ValidarPosicaoDestino(origem, destino);

                    partida.RealizaJogada(origem, destino);
                }
                catch (TabuleiroException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            Console.Clear();
            Tela.ImprimirPartida(partida);

        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}