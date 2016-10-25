using System;

namespace TestCSharp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		public void doSomething(int num, int size)
		{
			int temp = num ;
			size = temp ;
			num = temp + 1;
		}
	}
}
