namespace FactoryExamples.SimpleFactory.before;

public abstract class AbstractPizzaStore
{
    public Pizza OrderPizza(string type) {
        Pizza pizza;
        
        pizza = CreatePizza(type);
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }
    protected abstract Pizza CreatePizza(string type);
}