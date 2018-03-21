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
            
        }
    }
}
