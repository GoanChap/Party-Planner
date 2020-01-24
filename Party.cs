using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Planner
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecor { get; set; }

        private decimal CostOfDecor()
        {
            decimal CostOfDecor;
            if (FancyDecor)
                CostOfDecor = (NumberOfPeople * 15M) + 50M;
            else
                CostOfDecor = (NumberOfPeople * 7.5M) + 30M;

            return CostOfDecor;
        }

        virtual public decimal Cost
        {
            get {
                decimal totalCost = CostOfDecor();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;

                if (NumberOfPeople > 12)
                    totalCost += 100;

                return totalCost;

            }
        }

    }
}
