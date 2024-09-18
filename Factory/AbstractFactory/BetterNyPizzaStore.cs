using FactoryExamples.SimpleFactory.before;

namespace FactoryExamples.AbstractFactory;

public class BetterNyPizzaStore : IBetterPizzaStore
{
    public BetterPizza CreatePizza(string type)
    {
        BetterPizza pizza = null;
        IPizzaIngredientFactory ingredientFactory = new NyPizzaIngredientFactory();
        if (type == "cheese") 
        {
            pizza = new BetterCheesePizza(ingredientFactory);
            pizza.Name = "New York Style Cheese Pizza";
        } 
        // else if (type == "veggie") 
        // {
        //     pizza = new BetterVeggiePizza(ingredientFactory);
        //     pizza.Name = "New York Style Veggie Pizza";
        // } 
        // else if (type == "pepperoni")
        // {
        //     pizza = new BetterPepperoniPizza(ingredientFactory);
        //     pizza.Name = "New York Style Pepperoni Pizza";
        // }
        return pizza;
    }
}