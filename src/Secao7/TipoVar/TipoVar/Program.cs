namespace TipoVar;

class Program
{
    static void Main(string[] args)
    {
        // var aceita qualquer tipo de variavel, mas isso pode fazer com que erros ocorram
        //var x = 10;
        //var y = 20.00;
        //var z = "Maria";



        //Console.WriteLine(x);
        //Console.WriteLine(y);
        //Console.WriteLine(z);

        //condicional ternaria consegue substituir um if-else
        // faz a variavel = (condicao) ? ->if<- : ->else<-

        double preco = double.Parse(Console.ReadLine());
        double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

        Console.WriteLine(desconto); 



    }
}