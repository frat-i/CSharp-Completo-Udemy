namespace FuncoesString;
class Program
{
    static void Main(string[] args)
    {
        string original = "abcde FGHIJ abc DEFG       ";

        string s1 = original.ToUpper(); // tudo maiusculo
        string s2 = original.ToLower(); // tudo minusculo
        string s3 = original.Trim(); // apaga espacos vazios antes e depois
        int n1 = original.IndexOf("bc"); // posicao -> primeira ocorrencia doq ta no ()
        int n2 = original.LastIndexOf("bc"); // posicao -> ultima ocorrencia doq ta no ()

        string s4 = original.Substring(3); // corta parte da string
        string s5 = original.Substring(3,5); // comeca na 3 e corta 5 caracteres a partir da pos 3

        string s6 = original.Replace('a', 'x'); //substitui x caractere por y caractere
        string s7 = original.Replace("abc", "x"); //substitui x caractere por y caractere

        bool b1 = String.IsNullOrEmpty(original); // bom pra ver se usuario por ex deixou em branco o campo
        bool b2 = String.IsNullOrWhiteSpace(original); // verifica se é null ou espaço em branco


        Console.WriteLine("Original: -" + original + "-");
        Console.WriteLine("ToUpper: -" + s1 + "-");
        Console.WriteLine("ToLower: -" + s2 + "-");
        Console.WriteLine("Trim: -" + s3 + "-");
        Console.WriteLine("IndexOf(bc): - " + n1);
        Console.WriteLine("LastIndexOf(bc): - " + n2);
        Console.WriteLine("Substring 3: " + s4);
        Console.WriteLine("Substring 3,5: " + s5);
        Console.WriteLine("Replace: - " + s6);
        Console.WriteLine("Replace: - " + s7);
        Console.WriteLine("IsNullorEmpty: - " + b1);
        Console.WriteLine("IsNullorWhiteSpace: - " + b2);

    }
}