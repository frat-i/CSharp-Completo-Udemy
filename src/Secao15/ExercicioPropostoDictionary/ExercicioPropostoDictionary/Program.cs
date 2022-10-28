namespace EXPDictionary;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter file full path: ");
        string path = Console.ReadLine();

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                Dictionary<string, int> candidato = new Dictionary<string, int>();

                while (!sr.EndOfStream)
                {
                    string[] votingRecord = sr.ReadLine().Split(',');
                    string candidate = votingRecord[0];
                    int votes = int.Parse(votingRecord[1]);

                    if (candidato.ContainsKey(candidate)) // se a chave igual ao candidato já existe ele vai e soma os votos
                    {
                        candidato[candidate] += votes;
                    }
                    else // se a chave igual ao candidato não existe ainda ele seta o número de votos nesse else
                    {
                        candidato[candidate] = votes;
                    }

                }

                foreach (var kvp in candidato)
                {
                    Console.WriteLine($"{kvp.Key} : {kvp.Value}");
                }

            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}