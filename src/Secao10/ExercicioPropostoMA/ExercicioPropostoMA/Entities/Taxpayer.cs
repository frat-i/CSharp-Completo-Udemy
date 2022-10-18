using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoMA.Entities
{
    abstract class Taxpayer
    {
        public string Name { get; set; }

        public double AnualIncome { get; set; }

        public Taxpayer()
        {

        }

        protected Taxpayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
        
    }
}
