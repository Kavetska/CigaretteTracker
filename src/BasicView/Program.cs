using CigaretteTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicView
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Cigarette> cigarettes = new List<Cigarette>();
            for(int i = 0; i< 20; i++)
            {
                cigarettes.Add(new Cigarette());
            }

            DateTime date = DateTime.Now;
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;

            List<DateTime> timesOfSmoking = new List<DateTime>();
            for(int i = 0; i<20; i++)
            {
                timesOfSmoking.Add(new DateTime(year, month, day, i, i+20, 0));
            }

            List<CigarettesPerDay> calendar = new List<CigarettesPerDay>();
            for(int i = 0; i<30; i++)
            {
                calendar.Add(new CigarettesPerDay(cigarettes, timesOfSmoking));
            }

            CigarettesTracker tracker = new CigarettesTracker(calendar);

            Menu menu = new Menu(tracker);
        }
    }
}
