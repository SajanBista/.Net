Write a c# console program that asks the user for their age and eduaction level
,then determine their job eligibility using nested if statement, an else if ladder,
and a switch case. The program should classify the user int Entry-Level,MId_level 
or senior jobs based on age and assign a specific job role based on education

solution of the above code in dotnet.


using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your education level (HighSchool, Diploma, Bachelor, Master, PhD): ");
        string education = Console.ReadLine();

        Console.Write("Enter what you want to perform: \n 1. Nested if \n 2. If-Else Ladder \n 3. Switch Case \nEnter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        string jobCategory = "Not Assigned";
        string jobRole = "Not Assigned";

        switch (choice)
        {
            case 1:
                Console.WriteLine("\nUsing Nested If:");

                if (age >= 18)
                {
                    if (age < 25)
                    {
                        jobCategory = "Entry-Level";
                    }
                    else if (age < 40)
                    {
                        jobCategory = "Mid-Level";
                    }
                    else
                    {
                        jobCategory = "Senior-Level";
                    }

                    Console.WriteLine($"Job Category: {jobCategory}");
                }
                else
                {
                    Console.WriteLine("You are not eligible for a job yet.");
                }
                break;

            case 2:
                Console.WriteLine("\nUsing If-Else Ladder:");

                if (age < 18)
                {
                    Console.WriteLine("You are not eligible for a job.");
                }
                else if (age < 25)
                {
                    jobCategory = "Entry-Level";
                }
                else if (age < 40)
                {
                    jobCategory = "Mid-Level";
                }
                else
                {
                    jobCategory = "Senior-Level";
                }

                Console.WriteLine($"Job Category: {jobCategory}");
                break;

            case 3:
                Console.WriteLine("\nUsing Switch Case:");

                switch (education.ToLower())
                {
                    case "highschool":
                        jobRole = "Driver";
                        break;
                    case "diploma":
                        jobRole = "Khalasi";
                        break;
                    case "bachelor":
                        jobRole = "Piun";
                        break;
                    case "master":
                        jobRole = "Gate Guard";
                        break;
                    case "phd":
                        jobRole = "singer";
                        break;
                    default:
                        jobRole = "Clerk";
                        break;
                }

                Console.WriteLine($"Your assigned job role is: {jobRole}");
                break;

            default:
                Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
                break;
        }
    }
}
