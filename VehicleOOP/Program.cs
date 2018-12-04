using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleOOP
{
    class Program
    {
        static void State(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {

            var pointer = new StateChangedDelegate(State);
            
            Console.WriteLine("Ferrari:");
            Car c = new SportsCar()
            {
                StateChanged = pointer
            };
            c.Start();
            while (c.Drive(1)) { }
            
            Console.WriteLine("Honda");
            Car cheapCar = new Car()
            {
                StateChanged = pointer
            };

            cheapCar.Start();
            while (cheapCar.Drive(10)) { } ;

        }
    }
}
