using System;

namespace SharpMd
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"Received {args.Length} args.");
			foreach (string arg in args) {
				Console.WriteLine("Arg: " + arg);
			}
		}
	}
}
