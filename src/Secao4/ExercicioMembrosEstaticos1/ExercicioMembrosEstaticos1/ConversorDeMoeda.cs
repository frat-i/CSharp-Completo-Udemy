using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMembrosEstaticos1
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.0;

        public static double ConverterDolar(double quantia, double cotacao) // Valores que necessito para fazer a conversão
        {
            double total = quantia * cotacao;
            return total + total *  IOF / 100.0;
        }

        //



    }
}
