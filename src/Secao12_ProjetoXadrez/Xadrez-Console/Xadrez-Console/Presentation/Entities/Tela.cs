using Xadrez_Console.Chess.Entities;
using XadrezTabuleiro.Entities;
using XadrezTabuleiro.Entities.Enums;

namespace Xadrez_Console.Presentation.Entities;

internal static class Tela
{
    public static void ImprimirPartida(PartidaXadrez partida)
    {
        ImprimirTabuleiro(partida.Tabuleiro);
        Console.WriteLine();
        ImprimirPecasCapturadas(partida);
        Console.WriteLine();
        Console.WriteLine($"Turno: {partida.Turno}");
        if (!partida.Terminada)
        {
            Console.WriteLine($"Aguardando jogada: {partida.JogadorAtual}");
            if (partida.Xeque)
            {
                Console.WriteLine("XEQUE");
            }
        }
        else
        {
            Console.WriteLine("XEQUEMATE!");
            Console.WriteLine($"Vencedor: {partida.JogadorAtual}");
        }

    }

    public static void ImprimirPecasCapturadas(PartidaXadrez partida)
    {
        Console.WriteLine("Pecas capturadas: ");
        Console.Write("Brancas: ");
        ImprimirConjunto(partida.PecasCapturadasCor(Cor.Branca));
        Console.WriteLine();
        Console.Write("Pretas: ");
        ConsoleColor aux = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        ImprimirConjunto(partida.PecasCapturadasCor(Cor.Preta));
        Console.ForegroundColor = aux;
        Console.WriteLine();
    }

    public static void ImprimirConjunto(HashSet<Peca> conjunto)
    {
        Console.Write("[");
        foreach (Peca p in conjunto)
        {
            Console.Write(p + "");
        }
        Console.Write("]");
    }

    public static void ImprimirTabuleiro(Tabuleiro Tab)
    {
        for (int i = 0; i < Tab.Linhas; i++)
        {
            Console.Write(8 - i + " ");
            for (int j = 0; j < Tab.Colunas; j++)
            {

                Tela.ImprimirPeca(Tab.Peca(i, j));

            }
            Console.WriteLine();
        }
        Console.WriteLine("  a b c d e f g h");
    }

    public static void ImprimirTabuleiro(Tabuleiro Tab, bool[,] posicoesPossiveis)
    {

        ConsoleColor fundoOriginal = Console.BackgroundColor;
        ConsoleColor fundoAlterado = ConsoleColor.DarkGray;


        for (int i = 0; i < Tab.Linhas; i++)
        {
            Console.Write(8 - i + " ");
            for (int j = 0; j < Tab.Colunas; j++)
            {
                if (posicoesPossiveis[i, j])
                {
                    Console.BackgroundColor = fundoAlterado;
                }
                else
                {
                    Console.BackgroundColor = fundoOriginal;
                }
                Tela.ImprimirPeca(Tab.Peca(i, j));

            }
            Console.WriteLine();
        }
        Console.WriteLine("  a b c d e f g h");
        Console.BackgroundColor = fundoOriginal;
    }

    public static PosicaoXadrez LerPosicaoXadrex()
    {
        string s = Console.ReadLine();
        char coluna = s[0];
        int linha = int.Parse(s[1].ToString());
        return new PosicaoXadrez(coluna, linha);
    }

    public static void ImprimirPeca(Peca peca)
    {
        if (peca == null)
        {
            Console.Write("- ");
        }
        else
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;

            }
            Console.Write(" ");
        }
    }

}

