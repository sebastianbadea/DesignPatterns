using FactoryExamples.SimpleFactory.before;

namespace FactoryExamples.SimpleFactory.after;

public class SimplePizzaFactory 
{
    public Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        
        if (type == "cheese")
        {
            pizza = new CheesePizza();
        } else if (type == "pepperoni")
        {
            pizza = new PepperoniPizza();
        } else if (type == "veggie")
        {
            pizza = new VeggiePizza();
        }

        return pizza;
    }
}