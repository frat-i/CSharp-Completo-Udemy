namespace Params;

class Program
{
    static void Main(string[] args)
    {
        //int s1 = Calculadora.Soma(10,20,30,40,50);
        //Console.WriteLine(s1);

        //int a = 10;
        //int triplo;

        //Calculadora.Triple(a, out triplo);
        //Console.WriteLine(triplo);
        //Calculadora.Triple(a); // não funciona pq o valor a vira x e as operações realizadas em x afetam apenas ele
        //                       //para funcionar tem que colocar ref, pois x vai apontar/refenciar/mexer na original para a;
        //Console.WriteLine(a);

        int x = 20;

        object obj = x; //boxing -> converte um tipo valor em tipo referencia compativel, aceita qualquer tipo, aponta para um obj no heap

        int y = (int)obj; //unboxing -> converte tipo ref para tipo valor compativel



    }
}