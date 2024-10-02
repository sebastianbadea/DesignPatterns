
namespace Singleton
{
    public class Boiler
    {
        public int Load { get; set; }

        public bool IsBoiled { get; set; }
        
        public bool IsEmpty { get; set; }

        internal void LoadBoiler()
        {
            Load += 500;
        }
    }
}
