using Decorator.Beverages;

namespace Decorator.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return 0.35 + Beverage.Cost();
        }
    }
}
