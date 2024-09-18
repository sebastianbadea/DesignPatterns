using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverages
{
    public abstract class Beverage
    {
        public abstract string GetDescription();

        public abstract double Cost();
    }
}
