using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Tests
{
    [TestClass()]
    public class AnimalTests
    {
        [TestMethod()]
        public void GenerateDogTest()//проверка, что все данные о собаке генерируются и не равны первоначальным
        {
            Dog dog = Dog.Generate();
            Assert.AreNotEqual(dog.Weight,0);
            Assert.AreNotEqual(dog.tailLength, 0);
            Assert.AreNotEqual(dog.ignoreDistances, 0);
        }
        [TestMethod()]
        public void GenerateCatTest()//проверка, что все данные о кошке генерируются и не равны первоначальным
        {
            Cat cat = Cat.Generate();
            Assert.AreNotEqual(cat.Weight, 0);
            Assert.AreNotEqual(cat.MicePerDay, 0);
        }
        [TestMethod()]
        public void GenerateCowTest()//проверка, что все данные о корове генерируются и не равны первоначальным
        {
            Cow  cow= Cow.Generate();
            Assert.AreNotEqual(cow.Weight, 0);
            Assert.AreNotEqual(cow.milkPerDay, 0);
            Assert.AreNotEqual(cow.hornsLength, 0);
        }
        [TestMethod()]
        public void GetInfoTest()//проверка, что данные записываются в строку
        {
            Cat cat = Cat.Generate();
            Assert.IsNotNull(cat.GetInfo());
        }
    }
}