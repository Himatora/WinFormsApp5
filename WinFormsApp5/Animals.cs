using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Animal
    {
        protected static Random rnd = new Random();//добавляем для генерации разных рандомных значений
        public int Weight;
        public virtual String GetInfo()
        {
            var str = String.Format("\nВес: {0}", this.Weight);
            return str;
        }
        
    }
    public class Cat : Animal
    {
        public int MicePerDay = 0; // улов мышей в день
        public bool Wool = false; // наличие шерсти
        public override String GetInfo()
        {
            var str = "Я кошка";
            str += base.GetInfo();
            str += String.Format("\nКоличество пойманных мышей в день: {0}", this.MicePerDay);
            str += String.Format("\nНаличие шерсти: {0}", this.Wool);
            return str;
        }
        public static Cat Generate()
        {
            return new Cat
            {
                Weight = rnd.Next() % 9 + 2,
                MicePerDay = rnd.Next() % 21,
                Wool = rnd.Next() % 2 == 0

            };
        }
    }
    public enum DogBreed { dachshund, rottweiler, toy_terrier };//список с породами
    public class Dog : Animal
    {
        public DogBreed breed = DogBreed.toy_terrier;//порода собак
        public int ignoreDistances = 0; // дистанция игнорирования команд
        public int tailLength = 0; // длина хвоста
        public override String GetInfo()
        {
            var str = "Я собака";
            str += base.GetInfo();
            str += String.Format("\nПорода: {0}", this.breed);
            str += String.Format("\nРасстояние игнорирования команд: {0}", this.ignoreDistances);
            str += String.Format("\nДлина хвоста: {0}", this.tailLength);
            return str;
        }
        public static Dog Generate()
        {
            return new Dog
            {
                Weight = rnd.Next() % 98 + 3,
                breed = (DogBreed)rnd.Next(3),
                ignoreDistances = rnd.Next() % 11 + 40,
                tailLength = rnd.Next() % 38 + 3

            };
        }
    }
    public class Cow : Animal
    {
        public int milkPerDay = 0; // молока в день
        public int hornsLength = 0; // длина рогов
        public override String GetInfo()
        {
            var str = "Я корова";
            str += base.GetInfo();
            str += String.Format("\nЛитров молока в сутки: {0}", this.milkPerDay);
            str += String.Format("\nДлина рогов: {0}", this.hornsLength);
            return str;
        }
        public static Cow Generate()
        {
            return new Cow
            {
                Weight = rnd.Next() % 701 + 200,
                milkPerDay = rnd.Next() % 9+12,
                hornsLength = rnd.Next() % 11+5
            };
        }
    }
}