using FactoryExamples.AbstractFactory;

namespace FactoryExamples.SimpleFactory.before;

public abstract class BetterPizza 
{
    public string Name { get; set; }
    protected Dough dough;
    protected Sauce sauce;
    protected Veggie[] veggies;
    protected Cheese cheese;
    protected Pepperoni pepperoni;
    protected Clams clam;

    public abstract void Prepare();
    
    public virtual void Bake() 
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }
    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }
    public virtual void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }
}