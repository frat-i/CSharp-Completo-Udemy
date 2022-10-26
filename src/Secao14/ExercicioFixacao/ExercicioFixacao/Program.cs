using ExercicioFixacao.Entities;
using ExercicioFixacao.Services;
using System.Globalization;

namespace ExercicioFixacao;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter contract data");
        Console.Write("Number: ");
        int contractNumber = int.Parse(Console.ReadLine());
        Console.Write("Date (dd/MM/yyyy): ");
        DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Contract value: ");
        double contractValue = double.Parse(Console.ReadLine());
        Console.Write("Enter number of installments: ");
        int contractInstallments = int.Parse(Console.ReadLine());

        Contract contract = new(contractNumber, contractDate, contractValue);

        Contract_Service contractService = new Contract_Service(new PaypalService()); //como paypalservice herda da interface onlinepaymentservice eu posso instanciar ela assim
        contractService.ProcessContract(contract, contractInstallments); //aqui eu processo um contrato colocando o contraco que instanciei e numero de parcelas

        Console.WriteLine("Installments: ");
        foreach (Installment installment in contract.Installments)
        {
            Console.WriteLine(installment);
        }


    }
}