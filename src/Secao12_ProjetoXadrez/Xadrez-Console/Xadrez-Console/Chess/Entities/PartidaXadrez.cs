using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using XadrezTabuleiro.Entities;
using XadrezTabuleiro.Entities.Enums;
using Xadrez_Console.Chess.Entities;
using Xadrez_Console.Board.Entities.Exceptions;



namespace Xadrez_Console.Chess.Entities
{
    internal class PartidaXadrez
    {
        public Tabuleiro Tabuleiro { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }

        public List<Peca> Pecas;
        public List<Peca> PecasCapturadas;

        public PartidaXadrez()
        {
            Tabuleiro = new(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            Pecas = new List<Peca>();
            PecasCapturadas = new List<Peca>();
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tabuleiro.RetirarPeca(origem);
            p.IncrementarQtdeMovimentos();
            Peca PecaCapturada = Tabuleiro.RetirarPeca(destino);
            Tabuleiro.ColocarPeca(p, destino);
            if(PecaCapturada != null)
            {
                PecasCapturadas.Add(PecaCapturada);
            }
        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            Turno++;
            MudaJogador();
            
        }
        
        public void ValidarPosicaoOrigem(Posicao pos)
        {
            if(Tabuleiro.Peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça nessa posição");
            }
            if(JogadorAtual != Tabuleiro.Peca(pos).Cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua");
            }
            if (!Tabuleiro.Peca(pos).ExisteMovimentoPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possiveis para a peça escolhida");
            }
        }

        public void ValidarPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!Tabuleiro.Peca(origem).PodeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida");
            }
        }

        private void MudaJogador()  
        {
            if(JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
        }

        public List<Peca> PecasCapturadasCor(Cor cor)
        {
            List<Peca> aux = new List<Peca>();
            foreach (Peca p in PecasCapturadas)
            {
                if(p.Cor == cor)
                {
                    aux.Add(p);
                }
            }
            return aux;
        }
        public List<Peca> PecasEmJogo(Cor cor)
        {
            List<Peca> aux = new List<Peca>();
            foreach (Peca p in Pecas)
            {
                if (p.Cor == cor)
                {
                    aux.Add(p);
                }
            }
            aux.Except(PecasCapturadasCor(cor));
            return aux;
        }




        public void ColocarNovaPeca(char coluna,int linha, Peca peca)
        {
            Tabuleiro.ColocarPeca(peca, new PosicaoXadrez(coluna, linha).ToPosicao());
            Pecas.Add(peca);
        }
        private void ColocarPecas()
        {
            ColocarNovaPeca('c', 1, new Torre(Tabuleiro, Cor.Branca));
            ColocarNovaPeca('c', 2, new Torre(Tabuleiro, Cor.Branca));
            ColocarNovaPeca('d', 1, new Rei(Tabuleiro, Cor.Branca));
            ColocarNovaPeca('d', 2, new Torre(Tabuleiro, Cor.Branca));
            ColocarNovaPeca('e', 1, new Torre(Tabuleiro, Cor.Branca));
            ColocarNovaPeca('e', 2, new Torre(Tabuleiro, Cor.Branca));

            ColocarNovaPeca('c', 7, new Torre(Tabuleiro, Cor.Preta));
            ColocarNovaPeca('c', 8, new Torre(Tabuleiro, Cor.Preta));
            ColocarNovaPeca('d', 7, new Rei(Tabuleiro, Cor.Preta));
            ColocarNovaPeca('d', 8, new Torre(Tabuleiro, Cor.Preta));
            ColocarNovaPeca('e', 7, new Torre(Tabuleiro, Cor.Preta));
            ColocarNovaPeca('e', 8, new Torre(Tabuleiro, Cor.Preta));

            
        }
    }
}
