using System;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Name1","Owner1",4, Gender.Male);
            int numOfBarks;
            Console.WriteLine("How many barks?");
            numOfBarks = int.Parse(Console.ReadLine());
            dog.Bark(numOfBarks);
            Console.WriteLine(dog.GetTag());

            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
            myDog.Bark(1);
            Console.WriteLine(myDog.GetTag());
        }
    }
    enum Gender
    {
        Male, 
        Female
    }
    class Dog
    {
        public String name;
        public String owner;
        public int age;
        public Gender gender;
        public Dog (string name, String owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }
        public void Bark (int num)
        {
            while(num > 0)
            {
                Console.WriteLine("Bark");
                num--;
            }
        }
        public String GetTag()
        {
            String returnString;
            if(gender == Gender.Male)
            {
                if (age == 1)
                {
                    returnString = "If lost, call " + owner + ". His name is " + name + " and he is " + age + " year old.";
                }
                else
                {
                    returnString = "If lost, call " + owner + ". His name is " + name + " and he is " + age + " years old.";
                }
            }
            else
            {
                if (age == 1)
                {
                    returnString = "If lost, call " + owner + ". Her name is " + name + " and she is " + age + " year old.";
                }
                else
                {
                    returnString = "If lost, call " + owner + ". Her name is " + name + " and she is " + age + " years old.";
                }
            }
            return returnString;
        }
    }
}
