using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoMA.Entities
{
    internal class Company : Taxpayer
    {
        public int numberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(int numberOfEmployees, string name, double anualIncome) : base(name, anualIncome)
        {
            this.numberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (numberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
