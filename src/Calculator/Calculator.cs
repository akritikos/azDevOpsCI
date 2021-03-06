namespace Kritikos.Calculator
{
  using System;

  public static class Calculator
  {
    internal static Random Random { get; } = new Random();

    public static int Add(int x, int y) => x + y;

    public static int Subtract(int x, int y) => x - y;

    public static bool IsAdult(this Person person)
      => person?.Age >= 18;
  }

  public record Person(string Name, int Age)
  {
  }
}
