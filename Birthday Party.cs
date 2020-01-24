using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class Birthday_Party : Party
    {

        public int NumberOfLetters { get; set; }

        public Birthday_Party(int numberOfPeople, bool fancyDecor, int numberOfLetters)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecor = fancyDecor;
            NumberOfLetters = numberOfLetters;
        }

        public bool CakeWritingTooLong {
            get {
                if (NumberOfLetters <= 40 && NumberOfPeople > 4)
                    return false;
                else if (NumberOfLetters <= 16 && NumberOfPeople < 5)
                    return false;
                else
                    return true;
            }
        }
        private decimal CostOfCake()
        {
            decimal costOfCake;
            if (NumberOfPeople <= 4)
                costOfCake = 40 + NumberOfLetters * 0.25M;
            else
                costOfCake = 75 + NumberOfLetters * 0.25M;

            return costOfCake;
        }

        override public decimal Cost
        {
            get {
                decimal totalCost = base.Cost;
                totalCost += CostOfCake();

                return totalCost;

            }
        }
    }
}
