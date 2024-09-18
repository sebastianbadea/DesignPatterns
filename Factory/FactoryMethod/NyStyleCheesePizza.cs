namespace FactoryExamples.SimpleFactory.before;

public class NyStyleCheesePizza : Pizza {
    public NyStyleCheesePizza() {
        Name = "NY Style Sauce and Cheese Pizza";
        dough = "Thin Crust Dough";
        sauce = "Marinara Sauce";
        toppings.Add("Grated Reggiano Cheese");
    }
}