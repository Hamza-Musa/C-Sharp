using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter an amount to convert to coins:");
      string amount = Console.ReadLine();
      double price = Convert.ToDouble(amount);
      Console.WriteLine($"{price} is equal to...");
      int goldValue = 10;
      int silverValue = 5;
      double howMany10sIn21 = Math.Floor(21 / 10); 
    }
  }
}
