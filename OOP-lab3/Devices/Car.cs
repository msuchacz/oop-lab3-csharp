using System;
using OOP_lab3.Animals;

namespace OOP_lab3.Devices
{
    public class Car : Device
    {
        public double EngineSize { get; set; }
        public string FuelType { get; set; }
        public double CurrentFuel { get; set; }

        readonly double MAX_FUEL = 1.0;

        public Car()
        {
        }

        public override void Sell(Human seller, Human buyer, decimal price)
        {
            if (seller.Car == this)
            {
                if (buyer.Cash >= price)
                {
                    buyer.Cash -= price;
                    seller.Cash += price;
                    buyer.Car = this;
                    seller.Car = null;
                    Console.WriteLine("Car has been sold");
                }
                else
                {
                    throw new Exception("Buyer does not have enough money");
                }
            }
            else
            {
                throw new Exception("Seller does not own the car");
            }
        }

        public override void TurnOn()
        {
            Console.WriteLine("Car is turned on");
        }

        public void Refuel()
        {
            CurrentFuel = MAX_FUEL;
        }
    }
}
