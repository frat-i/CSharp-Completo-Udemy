namespace EDirectionary;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> cookies = new Dictionary<string, string>();

        cookies["user"] = "Maria";
        cookies["email"] = "maria@gmail.com";
        cookies["phone"] = "99712234";
        cookies["phone"] = "2232394";

        Console.WriteLine(cookies["email"]);
        Console.WriteLine(cookies["phone"]); // <-coloca o segundo valor pois dictionary não admite repetição, sobreescreve o primeiro valor

        cookies.Remove("email");

        if (cookies.ContainsKey("email"))
        {
            Console.WriteLine(cookies["email"]);
        }
        else
        {
            Console.WriteLine("there is no email key");
        }

        Console.WriteLine($"Size: {cookies.Count}");

        Console.WriteLine("All cookies: ");
        foreach (KeyValuePair<string, string> item in cookies) //melhor usar var, esse jeito é muito verboso
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }


    }
}