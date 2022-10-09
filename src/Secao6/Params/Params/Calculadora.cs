using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Calculadora
    {
        //public static int Soma(params int[] numeros) //params mostra para o programa que o que ele receber já vai estar no formato desejado ->
        //                                             // -> não precisa colocar o int[] numeros toda vez que for instanciar
        //                                             // -> quando Soma for referenciada o (int[] {dados}) vira (dados)
        //{
        //    int soma = 0;

        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        soma += numeros[i];
        //    }

        //    return soma;
        //}

        //public static void Triple(ref int x)
        //{
        //    x = x * 3;
        //}

        public static void Triple(int origem, out int resultado) //out faz a mesma coisa que o ref mas a variavel não precisa ser referenciada para ele funcionar
        {
            resultado = origem * 3;
        }
    }
}
