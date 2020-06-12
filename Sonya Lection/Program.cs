using System;

namespace Sonya_Lection
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Press any key to start");
			Console.ReadLine();
			char[] k = new[] {'H', 'e', 'l', 'l', 'o'};
			Loca(k);


			Console.WriteLine("Press any key to end");
			Console.ReadLine();
		}

		public static void Loca(char[] Cool)
		{
			int i = 0;
			while (i < Cool.Length)
			{
				Console.WriteLine($"{Cool[i]}");
				i++;
			}
		}
	}
}
