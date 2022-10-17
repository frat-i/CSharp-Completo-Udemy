using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExercicioPropHeranca.Entities
{
    internal class ImportedProduct : Product
    {
        public double customFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(double customFees,string name, double price) : base(name, price)
        {
            this.customFee = customFees;
        }

        public double totalPrice()
        {
            return Price += customFee;
        }

        public override string Pricetag()
        {
            return Name
                + " $ "
                + totalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + customFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }

    }
}
