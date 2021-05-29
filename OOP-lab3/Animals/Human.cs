using System;
using System.Collections.Generic;
using OOP_lab3.Devices;

namespace OOP_lab3.Animals
{
    public class Human : Animal
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Phone Phone { get; set; }
        public Car Car { get; set; }
        public decimal Cash { get; set; }
        public string[] FingerNames { get; set; }
        public decimal Salary {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0.0m)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("NOBODY WILL PAY FOR WORKING");
                    salary = 0.0m;
                }
            }
        }

        private List<Animal> pets;
        private decimal salary;
        private readonly int FINGER_COUNT = 10;
        private readonly static string HUMAN_SPECIE = "homo sapiens";
        

        public Human(decimal salary) : base(HUMAN_SPECIE)
        {
            Salary = salary;
            FingerNames = new string[FINGER_COUNT];
        }

        public void AddPet(Animal pet)
        {
            if (pets == null)
            {
                pets = new List<Animal>();
            }
            pets.Add(pet);
        }

        public List<Animal> getPets()
        {
            return pets;
        }
    }
}
