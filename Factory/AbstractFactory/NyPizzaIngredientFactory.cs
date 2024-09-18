using FactoryExamples.AbstractFactory.Ingredients;

namespace FactoryExamples.AbstractFactory;

public class NyPizzaIngredientFactory : IPizzaIngredientFactory
{
    public Dough CreateDough() {
        return new ThinCrustDough();
    }
    public Sauce CreateSauce() {
        return new MarinaraSauce();
    }
    public Cheese CreateCheese() {
        return new ReggianoCheese();
    }
    public Veggie[] CreateVeggies() {
        Veggie[] veggies = [new Garlic(), new Onion(), new Mushroom(), new RedPepper()];
        return veggies;
    }
    public Pepperoni CreatePepperoni() {
        return new SlicedPepperoni();
    }
    public Clams CreateClam() {
        return new FreshClams();
    }
}