using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezTabuleiro.Entities;
using XadrezTabuleiro.Entities.Enums;


namespace Xadrez_Console.Chess.Entities
{
    internal class Rei : Peca
    { 
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
