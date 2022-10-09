using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; } // melhor método pois não requer aquele outro código -> propriedade digitada, essa é auto
        // prop tab tab
        // atritubos private é padrão _ antes e letra minuscula


        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }



        //sobrecarga é mais construtores para fazer operações, com parametros diferentes
        //como tem sobrecarga eu não consigo mais usar o construtor Produto p = new Produto(), pra isso funcionar tenho que criar um outro construtor sem passar nenhum parametro
        public Produto() // construtor sempre tem / deve ter o mesmo nome da classe e nenhum valor de retorno


        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1) { 
                      _nome = value;
                }
            }

        } // colocar nome não funciona, tem que usar value pq é isso que vai chegar, é como se estivesse usando nome

        //public string GetNome()
        //{
        //    return _nome;
        //}

        //public void SetNome(string nome)
        //{
        //    if(nome != null && nome.Length > 1) { 
        //    _nome = nome;
        //    }
        //} 

        //Colocando só o metodo GET o usuário não vai de jeito nenhum mudar o valor

        //public Produto(string nome, double preco)
        //{
        //    Nome = nome;
        //    Preco = preco;
        //    Quantidade = 5;
        //    // pode atribuir qualquer valor Quantidade = 10;
        //}


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome +
                ", $ " +
                Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " +
                Quantidade +
                " unidades, Total: $ " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
