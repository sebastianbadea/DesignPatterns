using FactoryExamples.SimpleFactory.before;

namespace FactoryExamples.AbstractFactory;

public class BetterCheesePizza : BetterPizza
{
    IPizzaIngredientFactory ingredientFactory;
    
    public BetterCheesePizza(IPizzaIngredientFactory ingredientFactory) {
        this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        dough = ingredientFactory.CreateDough();
        sauce = ingredientFactory.CreateSauce();
        cheese = ingredientFactory.CreateCheese();
    }
}