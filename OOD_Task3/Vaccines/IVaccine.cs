using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Vaccines
{
    using Task3.Subjects;
    interface IVaccine
    {
        public string Immunity { get; }
        public double DeathRate { get; }
        public void InjectDog(Dog dog);
        public void InjectCat(Cat cat);
        public void InjectPig(Pig pig);
    }
}
