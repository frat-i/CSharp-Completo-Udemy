using System;
using XadrezTabuleiro.Entities;
using XadrezTabuleiro.Entities.Enums;
using Xadrez_Console.Presentation.Entities;
using Xadrez_Console.Chess.Entities;

namespace Xadrez_Console;

class Program
{
    static void Main(string[] args)
    {

        Tabuleiro tab = new(8, 8);

        tab.ColocarPeca(new Torre(tab, Cor.Laranja), new Posicao(0,0));
        tab.ColocarPeca(new Torre(tab, Cor.Vermelha), new Posicao(1,3));
        tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2,4));
        
        Tela.ImprimirTabuleiro(tab);



    }
}