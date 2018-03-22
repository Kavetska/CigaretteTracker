namespace CigaretteTracker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cigarette
    {
        public double Nicotine { get; set; }
        public int Resin { get; set; }//смол
        public double Price { get; set; }
        public string Brand { get; set; }

        public Cigarette()
        {
            Nicotine = 0.1;
            Resin = 1;
            Price = 1.5;
        }

        public Cigarette(double nicotine, int resin, double price)
        {
            Nicotine = nicotine;
            Resin = resin;
            Price = price;
        }
    }
}
