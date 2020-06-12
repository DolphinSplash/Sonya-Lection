using System;

namespace Sonya_Lection
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Press any key to start");
			Console.ReadLine();
			int[] j = m();
			int[] u = m();
			var sum = ArrayPlusArray(j, u);
			Console.WriteLine(sum);
			Console.WriteLine("Press any key to end");
			Console.ReadLine();
		}
		public static int ArrayPlusArray(int[] arr1, int[] arr2)
		{
			int n = 0;
			foreach (var i in arr1)
			{
				n += i;
			}

			int y = 0;
			foreach (var g in arr2)
			{
				y += g;
			}
			return n+y;
		}

		public static int[] m()
		{
			Console.WriteLine("Напиши количество");
			int c = Convert.ToInt32(Console.ReadLine());
			int[] Rubbish = new int[c];
			for (int i = 0; i < c; i++)
			{
				Console.WriteLine("Write a number");
				Rubbish[i] = Convert.ToInt32(Console.ReadLine());
			}

			return Rubbish;
		}
	}
}
