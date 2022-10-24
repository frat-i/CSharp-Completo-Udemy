using XadrezTabuleiro.Entities;
using XadrezTabuleiro.Entities.Enums;


namespace Xadrez_Console.Chess.Entities;

internal class Rei : Peca
{
    private PartidaXadrez partida;
    public Rei(Tabuleiro tab, Cor cor, PartidaXadrez partida) : base(cor, tab)
    {
        this.partida = partida;
    }

    public override string ToString()
    {
        return "R";
    }

    bool PodeMover(Posicao posicao)
    {
        if (Tabuleiro.PosicaoValida(posicao) is false) return false;
        return Tabuleiro.Peca(posicao) is null || Tabuleiro.Peca(posicao).Cor != Cor;
    }

    private bool TesteTorreParaRoque(Posicao pos)
    {
        Peca p = Tabuleiro.Peca(pos);
        return p != null && p is Torre && p.Cor == Cor && p.QuantidadeMovimentos == 0;
    }


    public override bool[,] MovimentosPossiveis()
    {
        bool[,] matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

        // Possíveis posições
        Posicao pos = new Posicao(0, 0);

        // acima
        pos.DefinirValores(Posicao!.Linha - 1, Posicao.Coluna);
        if (PodeMover(pos)) matriz[pos.Linha, pos.Coluna] = true;

        // ne
        pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
        if (PodeMover(pos)) matriz[pos.Linha, pos.Coluna] = true;

        // direita
        pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
        if (PodeMover(pos)) matriz[pos.Linha, pos.Coluna] = true;

        // se
        pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
        if (PodeMover(pos)) matriz[pos.Linha, pos.Coluna] = true;

        // abaixo
        pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
        if (PodeMover(pos)) matriz[pos.Linha, pos.Coluna] = true;

        // so
        pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
        if (PodeMover(pos)) matriz[pos.Linha, pos.Coluna] = true;

        // esquerda
        pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
        if (PodeMover(pos)) matriz[pos.Linha, pos.Coluna] = true;

        // no
        pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
        if (PodeMover(pos)) matriz[pos.Linha, pos.Coluna] = true;

        // #jogada especial roque 
        if (QuantidadeMovimentos == 0 && !partida.Xeque)
        {
            // #jogada especial roque pequeno
            Posicao post1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
            if (TesteTorreParaRoque(post1))
            {
                Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);
                if (Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null)
                {
                    matriz[Posicao.Linha, Posicao.Coluna + 2] = true;
                }
            }

            // #jogada especial roque grande
            Posicao post2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
            if (TesteTorreParaRoque(post2))
            {
                Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);
                if (Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null && Tabuleiro.Peca(p3) == null)
                {
                    matriz[Posicao.Linha, Posicao.Coluna - 2] = true;
                }
            }

        }

        return matriz;
    }


}
