using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{

    class Car : Vehicle
    {

        public Car() : this(100)
        {
        }

        public Car(float fuel)
        {
            this.Fuel = fuel;
        }

        private float GetMaxDistance()
        {
            float maxDistance = Fuel / _fuelConsumtiom;
            return maxDistance;
        }

        private void FuelConsumption(float distanceInKm)
        {
            Fuel = Fuel - (distanceInKm * _fuelConsumtiom);
        }

        public override void Start()
        {
            _started = true;
            StartSound();
        }

        public virtual void StartSound()
        {
            Console.WriteLine("Vrom");
        }

        public override bool Drive(float distanceInKm)
        {
            bool drove = false;

            if(_started && distanceInKm <= GetMaxDistance())
            {

                //Console.WriteLine($"The car is driving x {distanceInKm}");
                StateChanged($"The car is driving x {distanceInKm}");

                FuelConsumption(distanceInKm);

                //Console.WriteLine("Fuel after drive = {0}", Fuel);
                StateChanged($"Fuel after drive = {Fuel}");

                drove = true;
            }
            else
            {
                Console.WriteLine("....");
            }

            return drove;
        }
    }
}
