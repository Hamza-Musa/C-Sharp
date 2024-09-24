# Money Maker

## Description

`Money Maker` is a C# console application that converts an amount of money into the least number of coins. This project demonstrates arithmetic operations, conditionals, and loops in C#.

## Usage

1. Clone the repository.
2. Navigate to the MoneyMaker directory.
3. Open the `MoneyMaker.cs` file in your preferred C# IDE.
4. Run the program and enter an amount of money when prompted to see the breakdown into coins.

## Code Example

```csharp
using System;

namespace MoneyMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an amount of money:");
            double amount = Convert.ToDouble(Console.ReadLine());

            int goldCoins = (int)(amount / 1.0);
            int silverCoins = (int)((amount - goldCoins) / 0.5);
            int bronzeCoins = (int)((amount - goldCoins - silverCoins * 0.5) / 0.1);

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {bronzeCoins}");
        }
    }
}

```

## Conclusion

Thank you for exploring the Money Maker project. This application showcases my ability to perform arithmetic operations and manage conditionals and loops in C#. If you have any comments or questions, please let me know.
