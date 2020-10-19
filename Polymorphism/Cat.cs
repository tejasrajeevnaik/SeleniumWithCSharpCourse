using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Cat : Animal
    {
        // Private variables

        // Constructor
        public Cat() : base()
        {
            CatType = "CatType1";
        }

        public Cat(string catType_C) : base()
        {
            CatType = catType_C;
        }

        public Cat(string catType_C, string animalGroup_C, string animalType_C) : base(animalGroup_C, animalType_C)
        {
            CatType = catType_C;
        }

        // Properties
        public string CatType
        {
            get;
            set;
        }

        // Methods
        public override string ToString()
        {
            return base.ToString() + " and I am a Cat";
        }

        public override string TestMethod()
        {
            return "Test from Cat";
        }
    }
}
