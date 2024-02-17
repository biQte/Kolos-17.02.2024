using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Samochod
    {
        public abstract string Color { get; }
        public abstract string Brand { get; }
        public abstract string EngineCapacity { get; }

        public abstract void GetColor();
        public abstract void GetBrand();
        public abstract void GetEngineCapacity();
    }
}
