using System.Globalization;
namespace DateTime1;

class Program
{
    static void Main(string[] args)
    {
        //o datetime em si começa a contar ticks a cada 100nanosegundos a partir do 1/1/1 00:00, mas ele faz o calculo automatico dps pras operacoes
        //DateTime d1 = DateTime.Now;
        //Console.WriteLine(d1);
        //Console.WriteLine(d1.Ticks);


        //para fazer um datetime com informação direta é ANO, MES, DIA, HORA, MINUTO , SEGUNDO....

        //DateTime d1 = new DateTime(2000, 8, 15);
        //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
        //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
        //Console.WriteLine(d1);
        //Console.WriteLine(d2);
        //Console.WriteLine(d3);

        //DateTime d1 = DateTime.Now; //data agora
        //DateTime d2 = DateTime.UtcNow;// data agora no horario global - utc
        //DateTime d3 = DateTime.Today;// dia agora -> vai mostrar meia noite
        //Console.WriteLine(d1);
        //Console.WriteLine(d2);
        //Console.WriteLine(d3);


        ////parse fazendo string virar datetime
        //DateTime d1 = DateTime.Parse("2000-08-15");
        //DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
        //DateTime d3 = DateTime.Parse("15/08/2000");
        //DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
        //Console.WriteLine(d1);
        //Console.WriteLine(d2);
        //Console.WriteLine(d3);
        //Console.WriteLine(d4);

        //PARSEEXACT FAZ COM QUE VC POSSA COLOCAR UMA MASCARA NA DATA -> MUITO UTIL
        DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
        CultureInfo.InvariantCulture);
        DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
        CultureInfo.InvariantCulture);
        Console.WriteLine(d1);
        Console.WriteLine(d2);

    }
}