namespace MatrizFixacao;

class Program
{
    static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split(' ');
        int n = int.Parse(line[0]);
        int m = int.Parse(line[1]);

        int[,] mat = new int[n, m];

        for (int i = 0; i < n; i++) // linhas
        {
            string[] valores = Console.ReadLine().Split(' ');

            for (int j = 0; j < m; j++) // colunas
            {
                mat[i, j] = int.Parse(valores[j]);
            }
        }

        Console.Write("Numero a ser lido: ");
        int numeroLido = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if(mat[i, j] == numeroLido)
                {
                    Console.WriteLine("Posicao: " + i + ", " + j);

                    if(j > 0)
                    {
                       
                        Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Cima: " + mat[i - 1, j]);
                    }

                    if (j < n - 1)
                    {
                        Console.WriteLine("Direita: " + mat[i, j + 1]);
                    }

                    if (i < m - 1)
                    {
                        Console.WriteLine("Baixo: " + mat[i + 1,j]);
                    }
                }
            }
        }


    }
}