﻿using SolucaoSemInterface.Entities;


namespace SolucaoSemInterface.Services;
internal class RentalService
{
    public double PricePerHour { get; private set; }
    public double PricePerDay { get; private set; }

    private ITaxService _taxService;
    public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
    {
        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
        _taxService = taxService;
    }

    public void ProcessInvoice(CarRental carRental)
    {
        TimeSpan duration = carRental.Finish.Subtract(carRental.Start); //verifica a diferença da data que alugou pra data que devolveu

        double basicPayment = 0.0;
        if (duration.TotalHours <= 12)
        {
            basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
        }
        else
        {
            basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
        }

        double tax = _taxService.Tax(basicPayment); // calculando a taxa de imposto com oq eu acabei de calcular

        carRental.Invoice = new(basicPayment, tax);
    }


}
