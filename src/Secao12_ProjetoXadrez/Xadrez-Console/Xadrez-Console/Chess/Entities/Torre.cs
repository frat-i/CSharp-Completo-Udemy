using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezTabuleiro.Entities;
using XadrezTabuleiro.Entities.Enums;


namespace Xadrez_Console.Chess.Entities;


internal class Torre : Peca
{
    public Torre(Tabuleiro tabuleiro, Cor cor) : base(cor, tabuleiro) { }

    public override string ToString() => "T";

    bool PodeMover(Posicao posicao)
    {
        if (Tabuleiro.PosicaoValida(posicao) is false) return false;
        return Tabuleiro.Peca(posicao) is null || Tabuleiro.Peca(posicao).Cor != Cor;
    }

    public override bool[,] MovimentosPossiveis()
    {
        bool[,] matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

        // Possíveis posições
        Posicao pos = new(0, 0);

        // acima
        pos.DefinirValores(Posicao!.Linha - 1, Posicao.Coluna);
        while (PodeMover(pos))
        {
            matriz[pos.Linha, pos.Coluna] = true;
            if (Tabuleiro.Peca(pos) is not null && Tabuleiro.Peca(pos).Cor != Cor)
                break;
            pos.Linha -= 1;
        }

        // baixo
        pos.DefinirValores(Posicao!.Linha + 1, Posicao.Coluna);
        while (PodeMover(pos))
        {
            matriz[pos.Linha, pos.Coluna] = true;
            if (Tabuleiro.Peca(pos) is not null && Tabuleiro.Peca(pos).Cor != Cor)
                break;
            pos.Linha += 1;
        }

        // direita
        pos.DefinirValores(Posicao!.Linha, Posicao.Coluna + 1);
        while (PodeMover(pos))
        {
            matriz[pos.Linha, pos.Coluna] = true;
            if (Tabuleiro.Peca(pos) is not null && Tabuleiro.Peca(pos).Cor != Cor)
                break;
            pos.Coluna += 1;
        }

        // esquerda
        pos.DefinirValores(Posicao!.Linha, Posicao.Coluna - 1);
        while (PodeMover(pos))
        {
            matriz[pos.Linha, pos.Coluna] = true;
            if (Tabuleiro.Peca(pos) is not null && Tabuleiro.Peca(pos).Cor != Cor)
                break;
            pos.Coluna -= 1;
        }

        return matriz;
    }
}