namespace EXDirectory_DirectoryInfo;

class Program
{
    static void Main(string[] args)
    {
        string path = @"d:\teste\";

        try
        {
            //listar subpastas -> *.* todos nomes e extensoes
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // poderia usar var que já seria colocado como IEnumerable
            Console.WriteLine("FOLDERS: ");

            foreach (string folder in folders)
            {
                Console.WriteLine(folder);
            }

            Console.WriteLine();

            //listar arquivos
            IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FILES: ");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Directory.CreateDirectory(path + @"\newfolder");

        }
        catch (IOException e)
        {
            Console.WriteLine("An error has occurred");
            Console.WriteLine(e.Message);
        }
    }
}