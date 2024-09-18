namespace FactoryExamples.SimpleFactory.before;

public class NyStyleVeggiePizza : Pizza {
    public NyStyleVeggiePizza() {
        Name = "NY Style Sauce and veggie Pizza";
        dough = "Thin Crust Dough";
        sauce = "Marinara Sauce";
        toppings.Add("Selected veggies");
    }
}