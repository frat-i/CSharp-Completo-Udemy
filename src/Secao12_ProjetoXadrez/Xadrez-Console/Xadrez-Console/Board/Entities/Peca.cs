using XadrezTabuleiro.Entities.Enums;


namespace XadrezTabuleiro.Entities;

abstract class Peca
{
    public Posicao Posicao { get; set; }
    public Cor Cor { get; protected set; }
    public int QuantidadeMovimentos { get; protected set; }
    public Tabuleiro Tabuleiro { get; protected set; }

    public Peca(Cor cor, Tabuleiro tabuleiro)
    {
        Cor = cor;
        Tabuleiro = tabuleiro;
        QuantidadeMovimentos = 0;
    }

    public void IncrementarQtdeMovimentos()
    {
        QuantidadeMovimentos++;
    }
    public void DecrementarQtdeMovimentos()
    {
        QuantidadeMovimentos--;
    }

    public bool ExisteMovimentoPossiveis()
    {
        bool[,] matriz = MovimentosPossiveis();
        for (int i = 0; i < Tabuleiro.Linhas; i++)
        {
            for (int j = 0; j < Tabuleiro.Colunas; j++)
            {
                if (matriz[i, j] == true)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public bool MovimentoPossivel(Posicao pos)
    {
        return MovimentosPossiveis()[pos.Linha, pos.Coluna];
    }


    public abstract bool[,] MovimentosPossiveis();


}
