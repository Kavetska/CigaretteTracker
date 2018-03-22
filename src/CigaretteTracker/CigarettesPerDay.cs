namespace CigaretteTracker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CigarettesPerDay
    {
        public List<Cigarette> Cigarettes { get; set; }
        public List<DateTime> TimeOfSmoking { get; set; }
        public DateTime Day { get; set; }

        public CigarettesPerDay(List<Cigarette> Cigarettes, List<DateTime> TimeOfSmoking)
        {
            this.Cigarettes = Cigarettes;
            this.TimeOfSmoking = TimeOfSmoking;
            Day = TimeOfSmoking[0];
        }

        public int ResinsConsumed()
        {
            int result = 0;
            foreach (var c in Cigarettes)
                result += c.Resin;

            return result;
        }

        public double NicotineConsumed()
        {
            double result = 0;
            foreach (var c in Cigarettes)
                result += c.Nicotine;

            return result;
        }

        public double MoneySpent()
        {
            double result = 0;
            foreach (var c in Cigarettes)
                result += c.Price;

            return result;
        }

    }
}
