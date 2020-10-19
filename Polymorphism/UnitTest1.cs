using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Polymorphism
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("Cool Dog"));
            animals.Add(new Cat("Cool Cat"));

            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine(animal.TestMethod());
            }

            Console.WriteLine();

            ArrayList animalList = new ArrayList();
            animalList.Add(new Dog("Cool Dog"));
            animalList.Add(new Cat("Cool Cat"));

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine(animal.TestMethod());
            }
        }
    }
}
