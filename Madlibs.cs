using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is MadLibs
      Author: Hamza Musa
      */


      // Let the user know that the program is starting:


      // Give the Mad Lib a title:
      string title = "Mad Lad Libs";

      Console.WriteLine(title);
      // Define user input and variables:


      // The template for the story:
      Console.WriteLine("Mad Libs is starting!");
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();

      //adjectives
      Console.Write("Will need 3 adjective. First adjective: ");
      string adjectiveOne = Console.ReadLine();

      Console.Write("Second adjective: ");
      string adjectiveTwo = Console.ReadLine();

      Console.Write("Third and Last adjective: ");
      string adjectiveThree = Console.ReadLine();
      //verb
      Console.Write("Will need one verb: ");
      string verb = Console.ReadLine();

      //nouns
      Console.Write("Will need two nouns. First noun: ");
      string nounOne = Console.ReadLine();
      Console.Write("Second noun: ");
      string nounTwo = Console.ReadLine();

      //multiple choice
      Console.Write("Give me an animal of your choosing: ");
      string animal = Console.ReadLine();
      Console.Write("Give me a food of your choosing: ");
      string food = Console.ReadLine();
      Console.Write("Give me a fruit of your choosing: ");
      string fruit = Console.ReadLine();
      Console.Write("Give me a superhero of your choosing: ");
      string superhero = Console.ReadLine();
      Console.Write("Give me a country of your choosing: ");
      string country = Console.ReadLine();
      Console.Write("Give me a dessert of your choosing: ");
      string dessert = Console.ReadLine();
      Console.Write("Give me a year of your choosing: ");
      string year = Console.ReadLine();
      

      string story = $"This morning {name} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
