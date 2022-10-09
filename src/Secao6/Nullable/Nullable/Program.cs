namespace Nullable;

class Program {
    static void Main(string[] args)
    {
        double? x = null;
        double? y = 10.0;

        double a = x ?? 5;
        double b = y ?? 5;

        Console.WriteLine(a);
        Console.WriteLine(b);

        //Console.WriteLine(x.GetValueOrDefault());
        //// pega o valor da variavel ou o valor padrao do tipo dela
        //Console.WriteLine(y.GetValueOrDefault());

        //Console.WriteLine(x.HasValue);
        ////verifica se tem valor 
        //Console.WriteLine(y.HasValue);

        //if(x.HasValue)
        //    Console.WriteLine(x.Value);
        ////pega diretamente o valor da var, não consegue imprimir valor nulo
        //else
        //    Console.WriteLine("X é nulo");

        //if(y.HasValue)
        //    Console.WriteLine(y.Value);
        //else
        //    Console.WriteLine("Y é nulo");

        ////para deixar "opcional = nullable" pode escrever Nullable<tipo> x = null ou colocar um ? dps do tipo,
        //// o ? faz o mesmo que o nullable<tipo>



    }
}
