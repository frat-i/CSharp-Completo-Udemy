using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropHeranca.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(DateTime manufactureDate, string name, double price) : base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string Pricetag()
        {
            return Name + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + manufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }

    }
}
