using System;

namespace VariableDemo
{
    // This class demonstrates different types of variables
    public class Account
    {
        // Constant variable (value cannot be changed)
        public const string BankName = "CodeBank";

        // Static variable (shared among all instances)
        public static int TotalAccount = 0;

        // Instance variables (unique to each object)
        public string accountHolder;
        public double balance;

        // Readonly variable (can be assigned only in constructor)
        public readonly string AccountId;

        // Constructor to initialize instance and readonly variables
        public Account(string holder, string id, double initialBalance)
        {
            accountHolder = holder;
            AccountId = id; // assigning readonly value here is valid
            balance = initialBalance;
            TotalAccount++; // increment total accounts when a new one is created
        }

        // Method demonstrating local variable and accessing class variables
        public void DisplayAccountInfo()
        {
            string infoHeader = "Account Info"; // local variable
            Console.WriteLine(infoHeader);
            Console.WriteLine($"Bank: {BankName}"); // constant
            Console.WriteLine($"Account Holder: {accountHolder}");
            Console.WriteLine($"Account ID: {AccountId}"); // readonly
            Console.WriteLine($"Balance: {balance}");
            Console.WriteLine($"Total Accounts: {TotalAccount}"); // static
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test()
            test.TestMethod=
            Account acc1 = new Account("Sita", "ACC123", 1500.75);
            Account acc2 = new Account("Gita", "ACC124", 2500.00);

            acc1.DisplayAccountInfo();
            Console.WriteLine("------------------------------");
            acc2.DisplayAccountInfo();

            Console.WriteLine($"Total accounts created: {Account.TotalAccount}");
        }

        public class Test
        {
            
            public static int a =10;
            public void TestMethod();
            {
                int b =50;
                int a = 20;
                Console.WriteLine($"value of a :{a}");
                Console.WriteLine($"\nvalue of a :{b}");

            }
            public void TestMethod1(){
                int a =40;
                int b = 100;
                Console.WriteLine($"value of a :{a}");
                Console.WriteLine($"\nvalue of a :{b}");


            }

        }
    }
}

