namespace FactoryExamples.SimpleFactory.before;

public class NyPizzaStore : AbstractPizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        if (type == "cheese")
        {
            pizza = new NyStyleCheesePizza();
        }
        else if (type == "veggie")
        {
            pizza = new NyStyleVeggiePizza();
        }

        return pizza;
    }
}