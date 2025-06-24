//1. Lambda Expression 
/*
using System;
namespace Lambda_Expression
{
    class Program
    {
        static int test1() => 5;
        static int test2(int x) => x + 10;

        static string stringFun(string a, string b) => a + b;

        static bool test(int m, int n) => m > n;

        static void Main()
        {
            string a = "sajan";
            string b = "bista";
            string fullname = stringFun(a, b);
            int x = test1();
            int res = test2(x);
            int m = 5;
            int n = 7;

            bool result = test(m, n);

            Console.WriteLine($" this is the result : {result}");

            Console.WriteLine($"the result is : {res}");
            Console.WriteLine($" My  name is :{fullname}");
        }
    }
}
*/
//2. Statement lambda

using System;
namespace Statement_Lambda
{
    class Program
    {
        static void Main()
        {
            Func<int, int> square = x =>
            {
                if (x < 0)
                {
                    Console.WriteLine(" Input is negative, converting to positive");

                    x = Math.Abs(x);
                }
                int result = x * x;
                return result;
            };
            


            int result = square(-5);
       

            Console.WriteLine($"The square of -5 is : {result}");// output The square of -5 is 25
        }
    }
}

using System;

namespace Try_catch
{
    class Program
    {
        public class MyCustomExpression : Exception
        {

        }
    }
}