namespace Calculator
{
	using System;

	public static class Calculator
	{
		internal static Random Random { get; } = new Random();

		public static int Add(int x, int y) => x + y;
	}
}
