using System;

namespace DateTimeOperacoes;

class Program
{
    static void Main(string[] args)
    {
        //Date(DateTime) -> TIPOS DE OPERACOES POSSIVEIS E SEUS VALORES
        //• Day(int)
        //• DayOfWeek(DayOfWeek)
        //• DayOfYear(int)
        //• Hour(int)
        //• Kind(DateTimeKind)
        //• Millisecond(int)
        //• Minute(int)
        //• Month(int)
        //• Second(int)
        //• Ticks(long)
        //• TimeOfDay(TimeSpan)
        //• Year(int)

        //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
        //Console.WriteLine(d);
        //Console.WriteLine("1) Date: " + d.Date);
        //Console.WriteLine("2) Day: " + d.Day);// -> ignora horas,min,seg,etc
        //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek); // -> só o dia
        //Console.WriteLine("4) DayOfYear: " + d.DayOfYear); // -> dia no ano -> 365 bobao
        //Console.WriteLine("5) Hour: " + d.Hour); // -> só a hora
        //Console.WriteLine("6) Kind: " + d.Kind); // que tipo de horário é, por padrao é o local mas como nao especificou ta como UNSPECIFIED (horario ex GMT)
        //Console.WriteLine("7) Millisecond: " + d.Millisecond); // -> só milisegundos
        //Console.WriteLine("8) Minute: " + d.Minute); // -> só minutos
        //Console.WriteLine("9) Month: " + d.Month); // -> só o mes
        //Console.WriteLine("10) Second: " + d.Second); // -> só os segundos
        //Console.WriteLine("11) Ticks: " + d.Ticks);
        //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay); // -> pega tudo menos o ano mes e dia
        //Console.WriteLine("13) Year: " + d.Year); // -> só o ano

        //DateTime d = new DateTime(2015, 10, 23, 21, 15, 30, 15);

        //string s1 = d.ToLongDateString(); // pode ate ser colocada em uma string pra sla simplificar? 
        //string s2 = d.ToLongTimeString(); // mostra apenas as horas,min,seg
        //string s3 = d.ToShortDateString(); // mostra a data sem horas
        //string s4 = d.ToShortTimeString(); // mostra a hora curtinha sem os segundos

        //string s5 = d.ToString(); // coloca no formato local default
        //string s6 = d.ToString("yyyy/MM/dd HH:mm:ss"); // só com o tostring da pra colocar uma máscara foda
        //string s7 = d.ToString("yyyy/MM/dd HH:mm:ss.fff"); // fff -> milisegundos

        //Console.WriteLine(d.ToLongDateString()); // -> isso faz com que converta a variavel datetime em uma string e usa a linguagem do computador para escrever de forma mais longa
        //Console.WriteLine(s1);
        //Console.WriteLine(s2);
        //Console.WriteLine(s3);
        //Console.WriteLine(s4);
        //Console.WriteLine(s5);
        //Console.WriteLine(s6);
        //Console.WriteLine(s7);

        // OPERACOES COM 
        //DateTime x = ...
        //DateTime y = x.Add(timeSpan);
        //DateTime y = x.AddDays(double);
        //DateTime y = x.AddHours(double);
        //DateTime y = x.AddMilliseconds(double);
        //DateTime y = x.AddMinutes(double);
        //DateTime y = x.AddMonths(int);
        //DateTime y = x.AddSeconds(double);
        //DateTime y = x.AddTicks(long);
        //DateTime y = x.AddYears(int);
        //DateTime y = x.Subtract(timeSpan);
        //TimeSpan t = x.Subtract(dateTime);

        //DateTime comecoTrab = DateTime.Now.AddMonths(-3);
        
        //var naoRecebe = DateTime.Now.Subtract(comecoTrab);
        ////DateTime naoDebit = comecoTrab.AddMonths(3);
        //Console.WriteLine("Locsfudz começou a trabalhar na OnFriday em: {0}", comecoTrab.ToString("dd/MM/yyyy") );
        //Console.WriteLine($"Fazem {naoRecebe.TotalDays:N0} dias que o coitado nao recebe :(");


        Console.Write("Digite quando foi que o Locsfudz começou a trabalhar na OnFriday: ");
        DateTime d1 = DateTime.Parse(Console.ReadLine());
        DateTime d2 = DateTime.Now;

        TimeSpan diferenca = d2.Subtract(d1); // -> COMPARAR DATAS

        Console.WriteLine($"Fazem APROXIMADAMENTE {(diferenca.TotalDays / 30).ToString("N0")} meses que o locsfudz nao recebe");
     

        //if(DateTime.TryParse(Console.ReadLine(), out DateTime date)) // -> como ler datas
        //{
        //    Console.WriteLine($"Fazem {DateTime.Now.Subtract(date).ToString("MM")} meses que o locsfduz nao recebe");
        //}
        //else
        //{
        //    Console.WriteLine("Escreve a data certo bobao");
        //}
         //DateTime.TryParse(Console.ReadLine(), out dataComecouTrab);


        

    }
}