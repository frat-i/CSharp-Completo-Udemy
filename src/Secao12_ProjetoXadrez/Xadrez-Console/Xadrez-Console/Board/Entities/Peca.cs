using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezTabuleiro.Entities.Enums;


namespace XadrezTabuleiro.Entities
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            Tabuleiro = tabuleiro;
            QuantidadeMovimentos = 0;
        }


    }
}
