﻿

using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principle , Time, Rate");
            int p = Convert.ToInt32(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());
            double t = Convert.ToDouble(Console.ReadLine());

            double S_I = (p * t * r) / 100;
            Console.WriteLine($"Your Simple interest is {S_I}");
        }
    }
}
//             Profit and loss
//             Console.WriteLine("Enter Your Cost Price(CP) and Selling Price(SP)");
//             double CP = Convert.ToDouble(Console.ReadLine());
//             double SP = Convert.ToDouble(Console.ReadLine());
//             if (CP > SP)
//             {
//                Console.WriteLine($"You are in loss \nYour Loss Amount is {CP - SP}");
//             }
//             else
//             {
//                Console.WriteLine($"You are in Profit \nYour Profit Amount is {SP - CP}");

//             }

//             Ternery Operator
//             Console.WriteLine("Use of Ternery Operator\n");
//             Console.WriteLine("Enter the value of X and Y:");
//             int X = Convert.ToInt32(Console.ReadLine());
//             int Y = Convert.ToInt32(Console.ReadLine());
//             String result = (X > Y) ? "X is greater" : "Y is Greater";
//             Console.WriteLine(result);


//             Console.WriteLine("\nSwitch Operation\n");
//             Console.WriteLine($"Select Operation:\n\n1.Addition\n2.Subtraction\n3.Division\n4.Product");
//             int select = Convert.ToInt32(Console.ReadLine());
//             switch (select)
//             {
//                case 1:
//                    Console.WriteLine(X + Y);
//                    break;

//                case 2:
//                    Console.WriteLine(X - Y);
//                    break;

//                case 3:
//                    Console.WriteLine(X / Y);
//                    break;

//                case 4:
//                    Console.WriteLine(X * Y);
//                    break;

//                default:
//                    Console.WriteLine("Invalid Operation");
//                    break;
//             }


//             String Concatination and String Interpolation.
//             Console.WriteLine("Enter Your FirstName and LastName:");
//             String firstname = Console.ReadLine();
//             String lastname = Console.ReadLine();

//             String Result = String.Concat(firstname, lastname);
//             Console.WriteLine("Result from Concatination = " + Result);

//             Console.WriteLine($"String Interpolation Makes: {firstname} {lastname}");


//             //Demonstrate 2D Array And Jagged Array

//             Console.WriteLine("Demonstration of 2D Array");
//             int[,] TwoDimension = new int[2, 3];

//             for (int i = 0; i < 2; i++)
//             {
//                 for (int j = 0; j < 3; j++)
//                 {
//                     TwoDimension[i, j] = i + j;
//                 }
//             }

//             Console.WriteLine("2D Array Output:");
//             for (int i = 0; i < 2; i++)
//             {
//                 for (int j = 0; j < 3; j++)
//                 {
//                     Console.Write(TwoDimension[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }

//             // Jagged Array demonstration
//             Console.WriteLine("\nDemonstration of Jagged Array");
//             int[][] JaggedArray = new int[2][];
//             JaggedArray[0] = new int[2]; // 2 columns in first row
//             JaggedArray[1] = new int[3]; // 3 columns in second row

//             for (int i = 0; i < JaggedArray.Length; i++)
//             {
//                 for (int j = 0; j < JaggedArray[i].Length; j++)
//                 {
//                     JaggedArray[i][j] = i + j;
//                 }
//             }

//             Console.WriteLine("Jagged Array Output:");
//             for (int i = 0; i < JaggedArray.Length; i++)
//             {
//                 for (int j = 0; j < JaggedArray[i].Length; j++)
//                 {
//                     Console.Write(JaggedArray[i][j] + " ");
//                 }
//                 Console.WriteLine();
//             }


//             //Value  Type and refrence Type

//             //    Program p = new Program();
//             //    int num = 10;
//             //    p.Add(num);

//             //    Console.WriteLine("Outside: " + num);

//             //    int numRef = 10;
//             //    p.AddRef(ref numRef);

//             //    Console.WriteLine(numRef);



//             //}

//             //void Add(int a)
//             //{
//             //    a += 5;
//             //    Console.WriteLine("Inside Method: " + a);
//             //}

//             //void AddRef(ref int a)
//             //{
//             //    a += 5;



//         }
//         }
// }
