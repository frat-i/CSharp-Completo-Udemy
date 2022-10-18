using System;
using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadas.Entities.Exceptions;

namespace ExcecoesPersonalizadas;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-In date (dd/mm/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out date (dd/mm/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            Reservation reservation = new(roomNumber, checkIn, checkOut);
            Console.WriteLine($"Reservation {reservation}");
            Console.WriteLine();

            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-In date (dd/mm/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out date (dd/mm/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkIn, checkOut);
            Console.WriteLine();
            Console.WriteLine($"Reservation {reservation}");

        }
        catch (DomainException e)
        {
            Console.WriteLine($"Error in reservation: {e.Message} ");
        }
        catch(FormatException e) 
        {
            Console.WriteLine($"Format error : {e.Message}");
        }
        catch(Exception e)
        {
            Console.WriteLine($"Unexpected error: {e.Message}");
        }
    }



}
