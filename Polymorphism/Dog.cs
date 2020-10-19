using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Dog : Animal
    {
        // Private variables

        // Constructor
        public Dog() : base()
        {
            DogType = "DogType1";
        }

        public Dog(string dogType_C) : base()
        {
            DogType = dogType_C;
        }

        public Dog(string dogType_C, string animalGroup_C, string animalType_C) : base(animalGroup_C, animalType_C)
        {
            DogType = dogType_C;
        }

        // Properties
        public string DogType
        {
            get;
            set;
        }

        // Methods
        public override string ToString()
        {
            return base.ToString() + " and I am a Dog";
        }

        public override string TestMethod()
        {
            return "Test from Dog";
        }
    }
}
