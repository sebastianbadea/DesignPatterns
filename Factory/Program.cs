using FactoryExamples.AbstractFactory;
using FactoryExamples.SimpleFactory.after;
using FactoryExamples.SimpleFactory.before;

Console.WriteLine("---   BEFORE Simple Factory    ---");
Pizza pizza = null;
var type = "cheese";

if (type == "cheese")
{
    pizza = new CheesePizza();
}
else if (type == "pepperoni")
{
    pizza = new PepperoniPizza();
}
else
{
    pizza = new VeggiePizza();
}
pizza.Prepare();

Console.WriteLine("---   AFTER Simple Factory    ---");
PizzaStore pizzaStore = new PizzaStore(new SimplePizzaFactory());
pizzaStore.OrderPizza("veggie");

Console.WriteLine("---   Factory Method    ---");
AbstractPizzaStore abstractPizzaStore = new ChicagoPizzaStore();
abstractPizzaStore.OrderPizza("cheese");

Console.WriteLine("---   Abstract Factory    ---");
IBetterPizzaStore betterPizzaStore = new BetterNyPizzaStore();
BetterPizza betterPizza = betterPizzaStore.CreatePizza("cheese");
betterPizza.Prepare();