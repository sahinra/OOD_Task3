using System;
using System.Collections.Generic;
using System.Text;
using Task3.Subjects;

namespace Task3.Vaccines
{
    class Vaccinator3000 : IVaccine
    {
        public string Immunity => "ACTG";
        public double DeathRate => 0.1f;

        private Random randomElement = new Random(0);

        public override string ToString()
        {
            return "Vaccinator3000";
        }

        public void InjectDog(Dog dog)
        {
            if (randomElement.NextDouble() > 3 * DeathRate)
            {
                dog.Immunity = Immunity;
                Console.WriteLine($"Dog {dog.ID} is injected by vaccinator 3000..");
            }
            else
            {
                dog.Alive = false;
                Console.WriteLine($"Dog {dog.ID} is dead after injecting vaccinator 3000..");
            }
        }

        public void InjectCat(Cat cat)
        {
            if (randomElement.NextDouble() > 3 * DeathRate)
            {
                cat.Immunity = Immunity;
                Console.WriteLine($"Cat {cat.ID} is injected by vaccinator 3000..");
            }
            else
            {
                cat.Alive = false;
                Console.WriteLine($"Cat {cat.ID} is dead after injecting vaccinator 3000..");
            }
        }

        public void InjectPig(Pig pig)
        {
            if (randomElement.NextDouble() > 3 * DeathRate)
            {
                pig.Immunity = Immunity;
                Console.WriteLine($"Pig {pig.ID} is injected by vaccinator 3000..");
            }
            else
            {
                pig.Alive = false;
                Console.WriteLine($"Pig {pig.ID} is dead after injecting vaccinator 3000..");
            }
        }
    }
}
