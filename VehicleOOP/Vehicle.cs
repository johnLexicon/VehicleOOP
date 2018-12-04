using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    abstract class Vehicle
    {
        protected bool _started;
        protected float _fuelConsumtiom = 4.3f; //litre / km
        private float _fuel;

        public StateChangedDelegate StateChanged;

        public float Fuel
        {
            get
            {
                return _fuel;
            }
            protected set
            {
                if (value < 0)
                {
                    _fuel = 0;
                }
                else
                {
                    _fuel = (float)Math.Round(value, 1);
                }
            }
        }

        public abstract bool Drive(float distanceInKm);
        public abstract void Start(); 
    }
}
