using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        private string selection;
        private double costOfCups = 1.00;
        private double costOfLemons = .25;
        private double costOfSugar = .30;
        private double costOfIce = .10;

        public double CostOfCups
        {
            get { return costOfCups; }
            set { costOfCups = value; }
        }

        public double CostOfLemons
        {
            get { return costOfLemons; }
            set { costOfLemons = value; }
        }

        public double CostOfSugar
        {
            get { return costOfSugar; }
            set { costOfSugar = value; }
        }

        public double CostOfIce
        {
            get { return costOfIce; }
            set { costOfIce = value; }
        }

        public Store()
        {

        }

        public void DisplayStore()
        {
            Console.WriteLine("You are at the store. Purchase items as needed.");
            Console.WriteLine("Cups: ${0}", CostOfCups);
            Console.WriteLine("Lemons: ${0}", CostOfLemons);
            Console.WriteLine("Sugar: ${0}", CostOfSugar);
            Console.WriteLine("Ice: ${0}", CostOfIce);
        }
    }
}
