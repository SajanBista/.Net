//1. Demonstrate the Constructor and its types

// 2. You are designing a simple class hierarchy in C# for a software system. Your task is to create two classes: Animal (base class) and Dog (derived class). You need to implement properties and inheritance, ensuring the following:
// Create a property Name in the Animal class.
// Create a property Breed in the Dog class.
//   Demonstrate the use of both auto-implemented properties and properties with backing fields.
// Implement by deriving the Dog class from the Animal class.
// Explain how you would apply it in C# (the concept, not the implementation, since C# does not support it directly).
// The Name property in the Animal class should have a private backing field.
// The Breed property in the Dog class should be auto-implemented.
// Demonstrate how the Dog class can inherit and access the Name property from the Animal class.
// Provide a brief explanation of why C# supports single inheritance but not multiple inheritance, and how it can be used to achieve a similar effect.
// 3. Demonstrate Polymorphism, method overload, and overriding.
// 4. Demonstrate binary and unary operator overloading
// 5.  WAP to demonstrate a 2*2 matrix array and a jagged array.
// 6. Create a C# inventory system that includes: Define Category (e.g., Electronics, Groceries). Create a sealed Item class with Name, Price, and Category properties. Implement a generic Inventory<T> class for Item, with methods to:
// Add items.
// Get items by category.
// Return a Dictionary<Category, List<Item>>.
// Use List<T> to store items. Organize items by category using a dictionary.
//  7. Demonstrate Struct in C #


//1. Demonstrate the Constructor and its types
/*
using System;
namespace constructor_and_its_types
{
    class Student
    {
        public Student()
        {
            Console.WriteLine("This is the default constructor\n");
        }
        public Student(string name, int semester)
        {
            Console.WriteLine("this is the parameterized constructor\n");
        }

        public Student(string name, string College_name)
        {
            Console.WriteLine("This is the constuctor which is same as parameterized constructor but here i am using it for the purpose of constructor overloading.\n");
        }
        public Student(string name, string Course, string father_name)
        {
            Console.WriteLine("This is also the constructor overloading with 3 parameters\n");
        }

        static Student()
        {
            Console.WriteLine("this is the static constructor which is called directly before any instance is created and is always parameter less\n");
        }

        static void Main(string[] args)
        {

            Student s1 = new Student();

            Student s2 = new Student("Sajan", 5);
            Student s3 = new Student("Sajan", "New Summit College");
            Student s4 = new Student(" Sajan", "BCA", "Ramesh Bisat");
        }

    }
}
*/

/*
2. You are designing a simple class hierarchy in C# for a software system. Your task is to create two classes: Animal (base class) and Dog (derived class). You need to implement properties and inheritance, ensuring the following:
Create a property Name in the Animal class.
Create a property Breed in the Dog class.
Demonstrate the use of both auto-implemented properties and properties with backing fields.
Implement by deriving the Dog class from the Animal class.
*/

/*
using System;

namespace InheritanceExample
{
    // Base class
    class Animal
    {
        // Auto-implemented property
        public string Name { get; set; }
    }

    // Derived class
    class Dog : Animal
    {
        // Property with backing field
        private string _breed;

        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();

            // Set properties
            myDog.Name = "Buddy";      // Inherited from Animal
            myDog.Breed = "Golden Retriever";

            // Display
            Console.WriteLine("Dog Name: " + myDog.Name);
            Console.WriteLine("Dog Breed: " + myDog.Breed);
        }
    }
}

*/

//3. Demonstrate Polymorphism, method overload, and overriding.
/*
using System;

namespace Polymorphism
{
    // Base class
    class MethodOverloading
    {
        public void MyInfo()
        {
            Console.WriteLine("I am a student.");
        }

        public void MyInfo(string name)
        {
            Console.WriteLine("My name is: " + name);
        }

        public void MyInfo(string name, int age)
        {
            Console.WriteLine("My name is: " + name + ", Age: " + age);
        }

        public virtual void Show()
        {
            Console.WriteLine("Show method in base class (MethodOverloading)");
        }
    }

    // Derived class
    class MethodOverriding : MethodOverloading
    {
        public override void Show()
        {
            Console.WriteLine("Overridden Show method in derived class (MethodOverriding)");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Overloading  Output=");
            MethodOverloading overloadObj = new MethodOverloading();
            overloadObj.MyInfo();
            overloadObj.MyInfo("Sajan");
            overloadObj.MyInfo("Sajan", 21);

            Console.WriteLine("\nMethod Overriding Output =");
            MethodOverriding overrideObj = new MethodOverriding();
            overrideObj.Show(); // Calls the overridden method
        }
    }
}
*/
/*

//4. Demonstrate binary and unary operator overloading

using System;

class Number
{
    public int value;

    public Number(int v)
    {
        value = v;
    }

    // Binary operator +
    public static Number operator +(Number a, Number b)
    {
        return new Number(a.value + b.value);
    }

    // Unary operator -
    public static Number operator -(Number a)
    {
        return new Number(-a.value);
    }

    public void Show()
    {
        Console.WriteLine("Value: " + value);
    }
}

class Program
{
    static void Main()
    {
        Number a = new Number(5);
        Number b = new Number(3);

        Number sum = a + b;   // Binary +
        Number neg = -a;      // Unary -

        sum.Show();  // Output: Value: 8
        neg.Show();  // Output: Value: -5
    }
}
*/

// 5.  WAP to demonstrate a 2*2 matrix array and a jagged array.
// 6. Create a C# inventory system that includes: Define Category (e.g., Electronics, Groceries). Create a sealed Item class with Name, Price, and Category properties. Implement a generic Inventory<T> class for Item, with methods to:
// Add items.
// Get items by category.
// Return a Dictionary<Category, List<Item>>.
// Use List<T> to store items. Organize items by category using a dictionary.
//  7. Demonstrate Struct in C 

/*
using System;

class Program
{
    static void Main()
    {
        // 2x2 Matrix (Rectangular Array)
        int[,] matrix = { { 1, 2 }, { 3, 4 } };

        Console.WriteLine("2x2 Matrix:");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(matrix[i, 0] + " " + matrix[i, 1]);
        }

        // Jagged Array
        int[][] jagged = {
            new int[] { 10, 20 },
            new int[] { 30, 40, 50 }
        };

        Console.WriteLine("\nJagged Array:");
        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write(jagged[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/


//6. Create a C# inventory system that includes: Define Category (e.g., Electronics, Groceries). Create a sealed Item class with Name, Price, and Category properties. Implement a generic Inventory<T> class for Item, with methods to:
// Add items.
// Get items by category.
// Return a Dictionary<Category, List<Item>>.
// Use List<T> to store items. Organize items by category using a dictionary.


using System;
using System.Collections.Generic;
using System.Linq;

namespace InventorySystem
{
    enum Category
    {
        Electronics,
        Groceries,
        Clothing,
        Stationery
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Item(string name, double price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Name} - Rs. {Price} ({Category})";
        }
    }

    class Inventory
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public List<Item> GetItemsByCategory(Category category)
        {
            return items.Where(i => i.Category == category).ToList();
        }

        public Dictionary<Category, List<Item>> GetAllItemsByCategory()
        {
            return items.GroupBy(i => i.Category)
                        .ToDictionary(g => g.Key, g => g.ToList());
        }
    }

    class Program
    {
        // ✅ Make sure Main method is exactly like this
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            inventory.AddItem(new Item("Laptop", 75000, Category.Electronics));
            inventory.AddItem(new Item("TV", 50000, Category.Electronics));
            inventory.AddItem(new Item("Rice", 1200, Category.Groceries));
            inventory.AddItem(new Item("Shirt", 1500, Category.Clothing));
            inventory.AddItem(new Item("Notebook", 80, Category.Stationery));

            Console.WriteLine("Electronics Items:");
            foreach (var item in inventory.GetItemsByCategory(Category.Electronics))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAll Items by Category:");
            var groupedItems = inventory.GetAllItemsByCategory();
            foreach (var group in groupedItems)
            {
                Console.WriteLine($"\nCategory: {group.Key}");
                foreach (var item in group.Value)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
/* 7. Demonstrate Struct in C */