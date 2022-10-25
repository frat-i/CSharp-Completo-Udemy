namespace AulaArquivos;

class Program
{
    static void Main(string[] args)
    {
        string sourcepath = @"d:\file1.txt";
        string targetpath = @"d:\file2.txt"; // clonar arquivo

        try
        {
            FileInfo fileinfo = new FileInfo(sourcepath); // criou um objeto que está ligado ao arquivo sourcepath
            fileinfo.CopyTo(targetpath); //copia arquivo para o lugar q ta nos ()

            string[] lines = File.ReadAllLines(sourcepath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}