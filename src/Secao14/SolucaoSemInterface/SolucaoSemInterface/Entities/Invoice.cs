namespace SolucaoSemInterface.Entities;
internal class Invoice
{
    public double BasicPayment { get; set; }
    public double Tax { get; set; }

    public Invoice(double basicpayment, double tax)
    {
        BasicPayment = basicpayment;
        Tax = tax;
    }

    public double TotalPayment
    {
        get { return BasicPayment + Tax; }
    }

    public override string ToString()
    {
        return "Basic Payment: "
                + BasicPayment.ToString("F2")
                + "\nTax: "
                + Tax
                + "\nTotalPayment: "
                + TotalPayment.ToString("F2");

    }

}
