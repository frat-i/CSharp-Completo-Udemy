using XadrezTabuleiro.Entities;
using XadrezTabuleiro.Entities.Enums;

namespace Xadrez_Console.Chess.Entities;

internal class Peao : Peca
{
    private PartidaXadrez partida;

    public Peao(Tabuleiro tab, Cor cor, PartidaXadrez partida) : base(cor, tab)
    {
        this.partida = partida;
    }

    public override string ToString()
    {
        return "P";
    }

    private bool ExisteInimigo(Posicao pos)
    {
        Peca p = Tabuleiro.Peca(pos);
        return p != null && p.Cor != Cor;
    }

    private bool Livre(Posicao pos)
    {
        return Tabuleiro.Peca(pos) == null;
    }

    public override bool[,] MovimentosPossiveis()
    {
        bool[,] matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

        Posicao pos = new Posicao(0, 0);

        if (Cor == Cor.Branca)
        {
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(pos) && Livre(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna);

            Posicao p2 = new Posicao(Posicao.Linha - 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(p2) && Livre(p2) && Tabuleiro.PosicaoValida(pos) && Livre(pos) && QuantidadeMovimentos == 0)
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }

            //// #jogadaespecial en passant
            //if (Posicao.Linha == 3)
            //{
            //    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
            //    if (Tabuleiro.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tabuleiro.peca(esquerda) == partida.vulneravelEnPassant)
            //    {
            //        matriz[esquerda.Linha - 1, esquerda.Coluna] = true;
            //    }
            //    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
            //    if (Tabuleiro.PosicaoValida(direita) && ExisteInimigo(direita) && Tabuleiro.peca(direita) == partida.vulneravelEnPassant)
            //    {
            //        matriz[direita.Linha - 1, direita.Coluna] = true;
            //    }
            //}
        }
        else
        {
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(pos) && Livre(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna);
            Posicao p2 = new Posicao(Posicao.Linha + 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(p2) && Livre(p2) && Tabuleiro.PosicaoValida(pos) && Livre(pos) && QuantidadeMovimentos == 0)
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(pos) && ExisteInimigo(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
            }

            //// #jogadaespecial en passant
            //if (Posicao.Linha == 4)
            //{
            //    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
            //    if (Tabuleiro.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tabuleiro.peca(esquerda) == partida.vulneravelEnPassant)
            //    {
            //        matriz[esquerda.Linha + 1, esquerda.Coluna] = true;
            //    }
            //    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
            //    if (Tabuleiro.PosicaoValida(direita) && ExisteInimigo(direita) && Tabuleiro.peca(direita) == partida.vulneravelEnPassant)
            //    {
            //        matriz[direita.Linha + 1, direita.Coluna] = true;
            //    }
            //}
        }

        return matriz;
    }
}
