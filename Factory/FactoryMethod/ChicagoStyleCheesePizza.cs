namespace FactoryExamples.SimpleFactory.before;

public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza() {
        Name = "Chicago Style Deep Dish Cheese Pizza";
        dough = "Extra Thick Crust Dough";
        sauce = "Plum Tomato Sauce";
        toppings.Add("Shredded Mozzarella Cheese");
    }
    
    public override void Cut() {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}