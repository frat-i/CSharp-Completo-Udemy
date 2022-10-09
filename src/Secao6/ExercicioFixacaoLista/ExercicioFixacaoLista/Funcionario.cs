using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoLista
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        private double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
             Salario += Salario / 100  * porcentagem;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario;
        }
    }
}
