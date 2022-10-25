namespace StreamWriter_EX;

class Program
{
    static void Main(string[] args)
    {

        string sourcepath = @"d:\file1.txt";
        string targetpath = @"d:\file2.txt";

        try
        {
            string[] lines = File.ReadAllLines(sourcepath);

            using (StreamWriter sw = File.AppendText(targetpath)) //escrevendo o counteudo do sourcepath no arquivo targetpath
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error has occurred");
            Console.WriteLine(e.Message);
        }



    }
}