namespace Bloco_Using;

class Program
{
    static void Main(string[] args)
    {
        string path = @"d:\file1.txt";


        try
        {
            /*using (FileStream fs = new(path, FileMode.Open))*/ //using automaticamente fecha coisas não verificadas pelo CLR -> filestream,streamreader...
                                                                 //{
            using (StreamReader sr = File.OpenText(path)) // -> forma resumida
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            //}
        }
        catch (IOException e)
        {
            Console.WriteLine("An error has occurred");
            Console.WriteLine(e.Message);
        }


    }
}