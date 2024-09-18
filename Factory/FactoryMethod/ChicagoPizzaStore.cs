namespace FactoryExamples.SimpleFactory.before;

public class ChicagoPizzaStore : AbstractPizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        if (type == "cheese")
        {
            pizza = new ChicagoStyleCheesePizza();
        }
        else if (type == "veggie")
        {
            pizza = new ChicagoStyleVeggiePizza();
        }

        return pizza;
    }
}