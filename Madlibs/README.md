# Madlibs

## Description

`Madlibs` is a C# console application that generates a fun and interactive story based on user input. This project demonstrates the use of variables, user input, and string interpolation in C#.

## Usage

1. Clone the repository.
2. Navigate to the `Madlibs` directory.
3. Open the `Madlibs.cs` file in your preferred C# IDE.
4. Run the program and follow the prompts to enter words, which will be used to fill in the blanks of a story.

## Code Example

```csharp
using System;

namespace Madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a noun:");
            string noun = Console.ReadLine();
            Console.WriteLine("Enter an adjective:");
            string adjective = Console.ReadLine();

            Console.WriteLine($"Once upon a time, there was a {adjective} {noun} named {name}.");
        }
    }
}


```

## Conclusion

I hope you enjoyed the Madlibs project. This interactive application demonstrates my skills in handling user input and string manipulation in C#. If you have any feedback or questions, please get in touch.
