using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ciezarowy : Samochod
    {
        private string color = "biały";
        private string brand = "DAF";
        private string engineCapacity = "11000^3";

        public override string Color => color;

        public override string Brand => brand;

        public override string EngineCapacity => engineCapacity;

        public void GetMaxLoad()
        {
            Console.WriteLine("Maksymalna waga zestawu to 40Ton");
        }

        public override void GetColor()
        {
            Console.WriteLine($"Kolor: {Color}");
        }

        public override void GetBrand()
        {
            Console.WriteLine($"Marka: {Brand} węzłów");
        }

        public override void GetEngineCapacity()
        {
            Console.WriteLine($"Pojemność silnika: {EngineCapacity} kg");
        }
    }
}
