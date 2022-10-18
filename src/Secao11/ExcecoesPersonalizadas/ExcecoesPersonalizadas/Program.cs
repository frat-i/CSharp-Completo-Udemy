﻿using System;
using ExcecoesPersonalizadas.Entities;

namespace ExcecoesPersonalizadas;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Room number: ");
        int roomNumber = int.Parse(Console.ReadLine());
        Console.Write("Check-In date (dd/mm/yyyy): ");
        DateTime checkIn = DateTime.Parse(Console.ReadLine()); 
        Console.Write("Check-Out date (dd/mm/yyyy): ");
        DateTime checkOut = DateTime.Parse(Console.ReadLine());

        if (checkOut <= checkIn)
        {
            Console.WriteLine("Error in reservation: Check-Out date must be after the Check-In date");
        }
        else
        {
            Reservation reservation = new(roomNumber, checkIn, checkOut);
            Console.WriteLine($"Reservation {reservation}");
            Console.WriteLine();

            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-In date (dd/mm/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out date (dd/mm/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            string error = reservation.UpdateDates(checkIn, checkOut);

            if(error != null)
            {
                Console.WriteLine("Error in reservation : " + error);
            }
            else
            {
                Console.WriteLine($"Reservation {reservation}");
            }

        }
        


    }
}