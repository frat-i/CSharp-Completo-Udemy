using ExercicioFixacao.Entities;

namespace ExercicioFixacao.Services;
internal class Contract_Service
{
    private IOnlinePaymentService _iOnlinePaymentService;

    public Contract_Service(IOnlinePaymentService onlinePaymentService)
    {
        _iOnlinePaymentService = onlinePaymentService;
    }

    public void ProcessContract(Contract contract, int months)
    {
        double basicQuota = contract.TotalValue / months; //total dividido pelo num de parcelas 
        for (int i = 1; i <= months; i++) //para cada numero de parcela
        {
            DateTime date = contract.Date.AddMonths(i);
            double updatedQuota = basicQuota + _iOnlinePaymentService.Interest(basicQuota, i); //amount = basicQuota, i = mes da parcela
            double fullQuota = updatedQuota + _iOnlinePaymentService.PaymentFee(updatedQuota);
            contract.AddInstallment(new Installment(date, fullQuota)); //installment recebe a data = mes inicial + 1 seguindo até o ultimo mes do parcelamento
        }
    }
}
