using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class Dinner_Party : Party
    {
        public bool HealthyOption { get; set; }

        public Dinner_Party(int numberOfPeople, bool fancyDecor, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecor = fancyDecor;
            HealthyOption = healthyOption;
        }

        private decimal CalcCostOfDrinks()
        {
            decimal costOfDrinks;
            if (HealthyOption)
                costOfDrinks = NumberOfPeople * 5;
            else
                costOfDrinks = NumberOfPeople * 20;

            return costOfDrinks;
        }

        public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CalcCostOfDrinks() * NumberOfPeople;
                if (HealthyOption)
                    totalCost *= 0.95M;
                return totalCost;
            }
        }
    }
}
