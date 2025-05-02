// See https://aka.ms/new-console-template for more information


//control statement

/*public class Program
{
    public static void Main(string[] args)
    {
       Console.Write("Enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        if(a>b)
        {
            Console.WriteLine("first number is greater than second number");
        }
        else{
            Console.WriteLine("second number is greater than first one");
        }
    }
}


//Wap to display current day?
public class Program
{
    public static void Main(string[] args)
    {
       Console.Write("Enter the day of the week from 1 to 7: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        if(a==1)
        {
            Console.WriteLine("Sunday");
        }
        else if(a==2){
            Console.WriteLine("Monday");
        }
        else if(a==3){
            Console.WriteLine("Tuesday");
        }
        else if(a==4){
            Console.WriteLine("Wednesday");
        }
        else if(a==5){
            Console.WriteLine("Thrusday");
        }
        else if(a==6){
            Console.WriteLine("Friday");
        }
        else{
            Console.WriteLine("Saturday");
        }
    }
}
*/
//Wap to display if student is above 18 amd check their gender and display their gender and weather they are verified or not.
/*
public class Program
{
    public static void Main(string[] args)
    {
       Console.Write("Enter your age");
        int a = Convert.ToInt32(Console.ReadLine());
        
       Console.Write("Enter your gender: ");
        string gender = Console.ReadLine();

        if(a>=18){
            if(gender == "male"){
                Console.WriteLine("He is Male and over 18");

            }
            else{
                Console.WriteLine("she is over 18 and is female");
            }
        }
        else{
            if(gender =="Male"){
                Console.WriteLine("He is male and is under 18");
            }
            else{
                Console.WriteLine("She is under 18 and is Female");
            }
        }


    }
}




// using switch case
public class Program
{
    public static void Main(string[] args)
    {
       Console.Write("Enter the day of the week from 1 to 7: ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch(day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("You Entered Invalid input");
                break;
            


        }
    }
}

        */

/* HomeWork
Write a c# console program that asks the user for their age and eduaction level
,then determine their job eligibility using nested if statement, an else if ladder,
and a switch case. The program should classify the user int Entry-Level,MId_level 
or senior jobs based on age and assign a specific job role based on education.*/


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
