using Singleton;
var boilerFactory = new BoilerFactory();

while (true)
{

    Console.WriteLine("Chose type of boiler [ChocolateBoiler/C]/[SingletonChocolateBoiler/S]");

    var option = Console.ReadKey().KeyChar;
    Console.WriteLine();

    var firstChocolateBoiler = boilerFactory.GetChocolateBoiler(option);

    Console.WriteLine("----First Instance Fill-----");
    Console.ReadKey();
    firstChocolateBoiler.Fill();

    Console.WriteLine("----First Instance Boil-----");
    Console.ReadKey();
    firstChocolateBoiler.Boil();

    var secondChocolateBoiler = boilerFactory.GetChocolateBoiler(option);

    Console.WriteLine("----Second Instance Fill-----");
    Console.ReadKey();
    var filled = secondChocolateBoiler.Fill();
    if (!filled)
    {
        continue;
    }

    Console.WriteLine("----Second Instance Boil-----");
    Console.ReadKey();
    secondChocolateBoiler.Boil();

    Console.WriteLine("----Second Instance Drain");
    secondChocolateBoiler.Drain();
    Console.ReadKey();

}


public class BoilerFactory
{
    public IChocolateBoiler GetChocolateBoiler(char option)
    {
        if (option == 'c')
        {
            return new ChocolateBoiler();
        }

        return SingletonChocolateBoiler.GetInstance();
    }
}