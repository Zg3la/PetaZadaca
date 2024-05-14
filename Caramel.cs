using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca5
{
    public class Caramel : CoffeeDecorator
    {
        public Caramel(Coffee coffee) : base(coffee) { }

        public override double GetCost()
        {
            return base.GetCost() +0.15;
        }
        public override string GetDescription() 
        {
            return base.GetDescription() + "\nWith Caramal";
        }
    }
}
