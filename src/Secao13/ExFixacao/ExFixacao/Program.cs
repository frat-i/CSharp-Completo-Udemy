using ExFixacao.Entities;
using System.Globalization;

namespace EXFixacao;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter file full path");

        string sourceFilePath = Console.ReadLine();
        try
        {
            string[] lines = File.ReadAllLines(sourceFilePath); // le todas as linhas do arquivo

            string sourceFolderPath = Path.GetDirectoryName(sourceFilePath); // pega a pasta do arquivo 
            string targetFolderPath = sourceFolderPath + @"\out"; // seta a pasta que deve ser criada e onde
            string targetFilePath = targetFolderPath + @"\summary.csv"; // seta o arquivo que deve ser criado e onde

            Directory.CreateDirectory(targetFolderPath); // cria a pasta

            using (StreamWriter sw = File.AppendText(targetFilePath))
            {
                foreach (string line in lines)
                {

                    string[] fields = line.Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(fields[2]);

                    Product prod = new(name, price, quantity);

                    sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}
