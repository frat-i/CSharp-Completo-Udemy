namespace EXPath;

class Program
{
    static void Main(string[] args)
    {
        string path = @"d:\teste\file1.txt";


        Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}"); //mostra a \ pq é ela que ta separando os diretórios
        Console.WriteLine($"PathSeparator: {Path.PathSeparator}");
        Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(path)}");
        Console.WriteLine($"GetFileName: {Path.GetFileName(path)}");
        Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(path)}");
        Console.WriteLine($"GetExtension: {Path.GetExtension(path)}");
        Console.WriteLine($"GetFullPath: {Path.GetFullPath(path)}");
        Console.WriteLine($"GetTempPath: {Path.GetTempPath()}"); //mostra caminho para a pasta temp do windows



    }
}