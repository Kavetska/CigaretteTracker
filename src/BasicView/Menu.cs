namespace BasicView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CigaretteTracker;

    public class Menu
    {
        private List<string> menuOptions;
        private CigarettesTracker cigaretteTracker;

        public Menu(CigarettesTracker cigaretteTracker)
        {
            this.cigaretteTracker = cigaretteTracker;
            menuOptions = new List<string>();
            Start();
        }


        public void Start()
        {
            Console.WriteLine("Choose menu item: ");
            menuOptions.Add("1. Count of the Day");
            menuOptions.Add("2. All Smoking Records");
            menuOptions.Add("3. Search By Date");

            foreach (var option in menuOptions)
                Console.WriteLine(option);

            Console.ReadKey();
        }

        public void Choose(int choice)
        {
            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }

        public void CountOfTheDay()
        {
            //var currentDate = cigaretteTracker.CigarettesPerDayList
            //Console.WriteLine(cigaretteTracker.CigarettesPerDayList[])
        }

        public void AllSmokingRecords()
        {

        }

        public DateTime? SearchByDate(DateTime date)
        {
            foreach (var c in cigaretteTracker.CigarettesPerDayList)
                if (c.Day == date)
                    return c.Day;
                else return DateTime.Now;
            return null;
        }

        public void DisplayRecord(DateTime date)
        {

        }
    }
}
