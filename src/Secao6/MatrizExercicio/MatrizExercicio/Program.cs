namespace MatrizExercicio;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int [,] mat = new int[n, n];

        for (int i = 0; i < n; i++) // para verificar as LINHAS 
        {
            string[] valores = Console.ReadLine().Split(' '); // guarda os valores que vao ser inseridos em cada coluna

            for (int j = 0; j < n; j++) // para verificar as COLUNAS -> insere os valores que foram guardados pela var valores
                                        //mat[i,j] -> o i ainda é o mesmo já que está dentro do outro for, o j que é a
                                        //coluna vai ser trocada pelos valores em sequencia da var valores
            {
                mat[i, j] = int.Parse(valores[j]);
            }
        }

        Console.WriteLine("Diagonal Principal : ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(mat[i,i] + " "); //como nao denomei diferente a linha e coluna vao ser ambas i

        }
        Console.WriteLine(" ");


        int contagemNegativos = 0;
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i, j] < 0)
                {
                    contagemNegativos++;
                }
            }
        }

        Console.WriteLine("Numeros negativos: " + contagemNegativos);
    }
}