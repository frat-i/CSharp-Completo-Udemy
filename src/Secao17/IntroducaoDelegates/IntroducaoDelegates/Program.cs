using IntroDelegates.Services;

namespace IntroDelegates;

class Program
{
    //delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperation(double n1, double n2);
    static void Main(string[] args)
    {
        double a = 10;
        double b = 12;


        //BinaryNumericOperation op = CalculationService.Sum;

        //double result = CalculationService.Sum(a, b);

        //double result = op(a, b);

        //double result2 = op.Invoke(a, b);

        BinaryNumericOperation op = CalculationService.ShowSum;
        op += CalculationService.ShowMax;

        op(a, b);

    }
}