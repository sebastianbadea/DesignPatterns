using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Milk";
        }

        public override double Cost()
        {
            return 0.2 + Beverage.Cost();
        }
    }
}
