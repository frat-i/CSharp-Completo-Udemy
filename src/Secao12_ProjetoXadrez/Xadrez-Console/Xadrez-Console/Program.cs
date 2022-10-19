using System;
using XadrezTabuleiro.Entities;
using XadrezTabuleiro.Entities.Enums;
using Xadrez_Console.Presentation.Entities;
using Xadrez_Console.Chess.Entities;
using Xadrez_Console.Board.Entities.Exceptions;


namespace Xadrez_Console;

class Program
{
    static void Main(string[] args)
    {

        try
        {
            Tabuleiro tab = new(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(5, 2));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(4, 7));

            tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 1));
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 1));
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 5));

            Tela.ImprimirTabuleiro(tab);
        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}