using System;
using System.Collections.Generic;
using System.Text;
using Task3.Subjects;

namespace Task3.Vaccines
{
    class AvadaVaccine : IVaccine
    {
        public string Immunity => "ACTAGAACTAGGAGACCA";

        public double DeathRate => 0.2f;

        private Random randomElement = new Random(0);

        static int time = 1;

        public override string ToString()
        {
            return "AvadaVaccine";
        }

        public void InjectDog(Dog dog)
        {
            dog.Immunity = dog.Immunity;
            Console.WriteLine($"Dog {dog.ID} is injected by avada vaccine..");
        }

        public void InjectCat(Cat cat)
        {
            if (randomElement.NextDouble() > time * DeathRate)
            {
                cat.Immunity = cat.Immunity.Remove(1, 3);
                Console.WriteLine($"Cat {cat.ID} is injected by avada vaccine..");
            }
            else
            {
                cat.Alive = false;
                Console.WriteLine($"Cat {cat.ID} is dead after injecting reverse vaccine..");
                time++;
            }
        }

        public void InjectPig(Pig pig)
        {
            pig.Alive = false;
            Console.WriteLine($"Pig {pig.ID} is dead after injecting avada vaccine..");
        }
    }
}
