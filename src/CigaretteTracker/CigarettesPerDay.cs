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

        public CigarettesPerDay(List<Cigarette> Cigarettes, List<DateTime> TimeOfSmoking, DateTime Day)
        {
            this.Cigarettes = Cigarettes;
            this.TimeOfSmoking = TimeOfSmoking;
            this.Day = Day;
        }
    }
}
