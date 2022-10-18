using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoMA.Entities
{
    internal class Individual : Taxpayer
    {
        public double healthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualIncome) : base(name,anualIncome)
        {
            this.healthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(AnualIncome < 20000.00)
            {
               if(healthExpenditures > 0)
                {
                    return (AnualIncome * 0.15) - (healthExpenditures *0.5);
                }

                else
                {
                    return (AnualIncome * 0.15);
                }
            }
            else
            {
                if (healthExpenditures > 0)
                {
                    return (AnualIncome * 0.25) - (healthExpenditures * 0.5);
                }

                else
                {
                    return (AnualIncome * 0.25);
                }

            }
        }
    }
}
