namespace IntroLinq;

class Program
{
    static void Main(string[] args)
    {
        // especificar o datasource
        int[] numbers = new int[] { 2, 3, 4, 5, };

        // definir a query
        var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
        IEnumerable<int> result2 = numbers.Where(x => x % 2 == 0).Select(x => x * 10); // linq é mais recomendado usar IEnumerable, pois linq gera resultados mais genericos

        // executar query

        foreach (int i in result)
        {
            Console.WriteLine(i);
        }

    }
}