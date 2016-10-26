using System;

namespace TestCSharp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			long mem1 = GC.GetTotalMemory(false);
			    // Allocate an array and make it unreachable.
		    int[] values = new int[50000];
		    values = null;
			long mem2 = GC.GetTotalMemory(false);
			    // Collect garbage.
		    GC.Collect();
			long mem3 = GC.GetTotalMemory(false);
		    Console.WriteLine(mem1);
		    Console.WriteLine(mem2);
		    Console.WriteLine(mem3);
		}

		public void doSomething(int num, int size)
		{
			int temp = num ;
			size = temp ;
			num = temp + 1;
		}
	}
}
