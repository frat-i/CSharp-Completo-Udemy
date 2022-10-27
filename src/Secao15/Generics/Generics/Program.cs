namespace ExemploGenerics;
class Program
{
	static void Main(string[] args)
	{
		PrintService<int> printservice = new PrintService<int>();

		Console.Write("How many values? ");
		int n = int.Parse(Console.ReadLine());
		for (int i = 0; i < n; i++)
		{
			int x = int.Parse(Console.ReadLine());
			printservice.AddValue(x);
		}

		//int a = printservice.First();
		//int b = a + 2;
		//Console.WriteLine(b);


		printservice.Print();
		Console.Write($"First: {printservice.First()}");
	}
}