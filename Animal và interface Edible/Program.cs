using System;
namespace AnimalAndInterfaceEdible
{
    public abstract class Animal {
        public abstract string MakeSound();
    }
    public interface Edible
    {
        public string HowToEat();
    }
    public abstract class Fruit : Edible {
        public abstract string HowToEat();
    }
    public class Tiger : Animal {
        public override string MakeSound() {
            return "Tiger: roarrrrr!";
        }
    }
    public class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }
        public string HowToEat() {
            return "could be fried";
        }
    }
    public class Apple : Fruit {
        public override string HowToEat()
        {
            return "Apple could be slided";
        }
    }
    public class Orange : Fruit
    {
        public override string HowToEat()
        {
            return "Orange could be juiced";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
            }
        }
    }
}
