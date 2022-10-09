namespace Timespan1;

class Program
{
    static void Main(string[] args)
    {
        //timespan representa duração -> timespan é muito utilizado para calcular juros 

        ////objt timespan tbm armazena em ticks de 100 nanosegundos a duração
        //TimeSpan t1 = new TimeSpan(0, 1, 30);
        //Console.WriteLine(t1);
        //Console.WriteLine(t1.Ticks);

        //CONSTRUTORES TIMESPAN
        //• TimeSpan()
        //• TimeSpan(ticks)
        //• TimeSpan(horas, minutos, segundos)
        //• TimeSpan(dias, horas, minutos, segundos)
        //• TimeSpan(dias, horas, minutos, segundos, milissegundos)

        //TimeSpan t1 = new TimeSpan();// -> como foi instanciado com nada ele vai retornar 0
        //TimeSpan t2 = new TimeSpan(900000000L);
        //TimeSpan t3 = new TimeSpan(2, 11, 21);
        //TimeSpan t4 = new TimeSpan(1, 2, 11, 21);// -> quando envolve dias ele coloca o DIA. para fazer a representação
        //TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
        //Console.WriteLine(t1);
        //Console.WriteLine(t2);
        //Console.WriteLine(t3);
        //Console.WriteLine(t4);
        //Console.WriteLine(t5);

        //METODO FROM FAZ DIRETO NA UNIDADE QUE VOCE QUER
        TimeSpan t1 = TimeSpan.FromDays(1.5);
        TimeSpan t2 = TimeSpan.FromHours(1.5);
        TimeSpan t3 = TimeSpan.FromMinutes(1.5);
        TimeSpan t4 = TimeSpan.FromSeconds(1.5);
        TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
        TimeSpan t6 = TimeSpan.FromTicks(900000000L); // -> PRECISA COLOCAR O L QUE SIGNIFICA LONG
        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
        Console.WriteLine(t4);
        Console.WriteLine(t5);
        Console.WriteLine(t6);


    }
}