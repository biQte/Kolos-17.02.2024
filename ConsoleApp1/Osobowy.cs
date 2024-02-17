using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Osobowy : Samochod
    {
        private string color = "czerwony";
        private string brand = "BMW";
        private string engineCapacity = "3500cm^3";

        public override string Color => color;

        public override string Brand => brand;

        public override string EngineCapacity => engineCapacity;

        public void GetName()
        {
            Console.WriteLine("Samochód osobowy");
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
