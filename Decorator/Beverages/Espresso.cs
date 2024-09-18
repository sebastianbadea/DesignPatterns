namespace Decorator.Beverages
{
    public class Espresso : Beverage
    {
        public override string GetDescription()
        {
            return "Expresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
