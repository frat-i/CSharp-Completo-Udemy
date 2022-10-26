namespace ExercicioFixacao.Services;
internal class PaypalService : IOnlinePaymentService
{
    private const double FeePercentage = 0.02; //não acho que tenha a necessidade de colocar duas variaveis já que nessa situação os valores sempre serão os mesmos
    private const double MonthlyInterest = 0.01;

    public double Interest(double amount, int months)
    {
        return amount * MonthlyInterest * months;
    }
    public double PaymentFee(double amount)
    {
        return amount * FeePercentage;
    }

}
