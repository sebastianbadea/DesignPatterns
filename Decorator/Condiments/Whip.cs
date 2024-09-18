using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return 0.5 + Beverage.Cost();
        }
    }
}
