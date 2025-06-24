using System;

namespace Try_catch
{
    class Program
    {
        public class MyCustomExpression : Exception
        {
            public MyCustomException(string message) : base(message)
            {

            }
        }

        static void ProcessData(int divisor)
        {
            try
            {
                Console.WriteLine(" Processing data ....");

                if (divisor == 0)
                {
                    throw new DivideByZeroException(" Divisor cannot be Zero");
                }

                else if (divisor < 0)
                {
                    throw new MyCustomExpression("divisor cannot be negative ");
                }

                int result = 10 / divisor;

                Console.WriteLine($"Result is {result}");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught MyCustomException: " + ex.Message);

                throw;
            }
            finally
            {
                Console.WriteLine("Finally block is executed. Performing cleaningup");
            }
        }


        static void Main(string[] args)
        {
            try
            {
                ProcessData(0);
            }
            catch (Exception ex)
            {

                Console.WriteLine(" Exception caught in Main:" + ex.Message);
            }

            try
            {
                ProcessData(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Exception caught in Main:" + ex.Message);
            }
            try
            {
                ProvessData(2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Exception caught in Main:" + ex.Message);
            }
            

        }
    }
}