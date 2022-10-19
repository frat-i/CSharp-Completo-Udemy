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

        PosicaoXadrez pos = new('c', 7);
        Console.WriteLine(pos);
        Console.WriteLine(pos.ToPosicao());

    }
}