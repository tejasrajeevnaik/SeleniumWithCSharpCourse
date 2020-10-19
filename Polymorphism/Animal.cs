using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal
    {
        // Private variables

        // Constructor
        public Animal()
        {
            AnimalGroup = "Group1";
            AnimalType = "Type1";
        }

        public Animal(string animalGroup_C, string animalType_C)
        {
            AnimalGroup = animalGroup_C;
            AnimalType = animalType_C;
        }

        // Properties
        public string AnimalGroup
        {
            get;
            set;
        }

        public string AnimalType
        {
            get;
            set;
        }

        // Methods
        public override string ToString()
        {
            return "I am an Animal";
        }

        public virtual string TestMethod()
        {
            return "Test from Animal";
        }
    }
}
