namespace Kritikos.Calculator.Tests
{
	using Kritikos.Calculator;

	using Xunit;

	public class AdditionTests
	{
		[Fact]
		public void AddTwoNumbers()
		{
			var x = Calculator.Random.Next();
			var y = Calculator.Random.Next();

			Assert.Equal(x + y, Calculator.Add(x, y));
		}
	}
}
