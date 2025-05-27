using System;

namespace ThisReference
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($" Name: {this.name}, Age: {this.age}");
        }
    }

    public class People
    {
        private string name;
        private int age;
        public People() : this("Unknown", 0)
        {

        }

        public People(string name) : this(name, 0)
        {

        }
        public People(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayPeopleInfo()
        {
            Console.WriteLine($"Name: {this.name}, Age: {this.age}");
        }
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Ram", 20);
            person.DisplayPersonInfo();

            People people = new People();
            people.DisplayPeopleInfo();
            people = new People("Shyam");
            people.DisplayPeopleInfo();

        }
    }

}