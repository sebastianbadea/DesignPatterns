namespace Decorator.Beverages
{
    public class HouseBlend : Beverage
    {
        public override string GetDescription()
        {
            return "House Blend Coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
