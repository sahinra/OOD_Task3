using System;
using System.Collections.Generic;
using System.Text;
using Task3.Subjects;

namespace Task3.Vaccines
{
    class ReverseVaccine : IVaccine
    {
        public string Immunity => "ACTGAGACAT";

        public double DeathRate => 0.05f;

        private Random randomElement = new Random(0);

        static int time = 1;

        public override string ToString()
        {
            return "ReverseVaccine";
        }
        public void InjectDog(Dog dog)
        {
            string reverseImmunity = "";
            int length = dog.Immunity.Length - 1;

            while (length >= 0)
            {
                reverseImmunity = reverseImmunity + dog.Immunity[length];
                length--;
            }

            dog.Immunity = reverseImmunity;
            Console.WriteLine($"Dog {dog.ID} is injected by reverse vaccine..");
        }

        public void InjectCat(Cat cat)
        {
            cat.Alive = false;
            Console.WriteLine($"Cat {cat.ID} is dead after injecting reverse vaccine..");
        }

        public void InjectPig(Pig pig)
        {
            string reverseImmunity = "";
            int length = pig.Immunity.Length - 1;

            while (length >= 0)
            {
                reverseImmunity = reverseImmunity + pig.Immunity[length];
                length--;
            }

            if (randomElement.NextDouble() > time*DeathRate)
            {
                pig.Immunity = Immunity + reverseImmunity;
                Console.WriteLine($"Pig {pig.ID} is injected by reverse vaccine..");
            }
            else
            {
                pig.Alive = false;
                Console.WriteLine($"Pig {pig.ID} is dead after injecting reverse vaccine..");
                time++;
            }
        }
    }
}
