namespace Singleton
{

    public class ChocolateBoiler :IChocolateBoiler
    {
        private static Boiler Boiler = new();

        public ChocolateBoiler()
        {
            Boiler.IsEmpty = true;
            Boiler.IsBoiled = true;
        }

        public bool Fill()
        {
            if (IsEmpty())
            {
                Boiler.LoadBoiler();
                if(Boiler.Load >500)
                {
                    Console.WriteLine("============Chocolate boiler overloaded===============");
                    return false;
                }
                Boiler.IsEmpty = false;
                Boiler.IsBoiled = false;
                Console.WriteLine("Chocolate boiler filled");
                // fill the boiler with a milk/chocolate mixture
            }
            else
            {
                Console.WriteLine("Chocolate boiler allready filled");                
            }
            return true;
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                // drain the boiled milk and chocolate
                Boiler.IsEmpty = true;                
                Console.WriteLine("Chocolate boiler drained");
            }
            else
            {
                Console.WriteLine("Chocolate boiler drained already");
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                // bring the contents to a boil
                Boiler.IsBoiled = true;
                Console.WriteLine("Chocolate boiled");
            }
            else
            {
                Console.WriteLine("Chocolate already boiled");
            }
        }

        public bool IsEmpty()
        {
            return Boiler.IsEmpty;
        }

        public bool IsBoiled()
        {
            return Boiler.IsBoiled;
        }
    }
}