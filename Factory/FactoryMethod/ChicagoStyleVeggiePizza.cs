namespace FactoryExamples.SimpleFactory.before;

public class ChicagoStyleVeggiePizza : Pizza
{
    public ChicagoStyleVeggiePizza() {
        Name = "Chicago Style Deep Dish Veggie Pizza";
        dough = "Extra Thick Crust Dough";
        sauce = "Plum Tomato Sauce";
        toppings.Add("Shredded vegetables");
    }
    
    public override void Cut() {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}