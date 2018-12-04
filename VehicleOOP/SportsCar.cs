using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    class SportsCar : Car
    {

        public SportsCar() : base()
        {
        }

        public SportsCar(float fuel) : base(fuel)
        {
            _fuelConsumtiom = 23.4f;
        }

        public override void StartSound()
        {
            Console.WriteLine("VVVVROOOOOMMMM!!!!!");
        }
    }
}
