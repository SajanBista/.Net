using System;
namespace ConsloeApp2
{
public class Program
{   Test test = new Test();
	public static void Main()
	{   
		int result;
		Test test = new Test();
		test.Add(1,2);
		Test test2 = new Test();
		result=test2.Add(11,12);
		Console.WriteLine(result);
		result = test.Add(1,2);
		
		Console.WriteLine(result);
		
		Sajan sajan = new Sajan();
		result = sajan.Subtract(5,3);
		Console.WriteLine(result);
		Sajan bista = new Sajan();
		result = bista.Subtract(10,8);
		Console.WriteLine(result);
	}
}

public class Test
{
	public int Add(int a, int b)
	{
		return a+b;
	}
}
public class Sajan
	{ public int Subtract(int a, int b)
	{
		return a-b;
		
}
}
}
	