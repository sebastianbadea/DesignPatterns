using Decorator.Beverages;

namespace Decorator.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        protected readonly Beverage Beverage;

        public CondimentDecorator(Beverage beverage)
        {
            this.Beverage = beverage;
        }
    }
}
