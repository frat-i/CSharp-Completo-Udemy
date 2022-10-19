using System;
using XadrezTabuleiro.Entities;
using XadrezTabuleiro.Entities.Enums;
using Xadrez_Console.Presentation.Entities;

namespace Xadrez_Console;

class Program
{
    static void Main(string[] args)
    {

        Tabuleiro tab = new(8, 8);

        Tela.ImprimirTabuleiro(tab);



    }
}