using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CigaretteTracker
{
    public class CigarettePack
    {
        public List<Cigarette> Cigarettes { get; set; }
        public double Price { get { return PriceOfPack(); } set { Price = value; } }

        private double PriceOfPack()
        {
            double result = 0;
            foreach (var c in Cigarettes)
                result += c.Price;

            return result;
        }
    }
}
