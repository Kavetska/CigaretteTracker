namespace CigaretteTracker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CigarettesTracker
    {
        public List<CigarettesPerDay> CigarettesPerDayList { get; set; }

        public CigarettesTracker(List<CigarettesPerDay> CigarettesPerDayList)
        {
            this.CigarettesPerDayList = CigarettesPerDayList;
        }


    }
}
