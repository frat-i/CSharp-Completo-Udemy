using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao1
{
    internal class Retangulo
    { 
        public double Largura;
        public double Altura;

        public double CalcArea()
        {
            return Largura * Altura;
        }

        public double CalcPerimetro()
        {
            return Largura + Altura;
        }

        public double CalcDiagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);

        }


    }
}
