using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeranca.Entities
{
    sealed class SavingsAccount : Account //sealed faz com que não possam ser criadas subclasses baseadas na classe selada
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number,holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void WithDraw(double amount) // sealed no override faz com que outras subclasses não possam dar override novamente neste método
        {
            base.WithDraw(amount);
            Balance -= 2.00 ;
        }

    }
}
