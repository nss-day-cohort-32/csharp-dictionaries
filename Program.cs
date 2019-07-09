using System;
using System.Collections.Generic;

namespace dictionaries
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, int> toysSold = new Dictionary<string, int>() {
                {"Hot Wheels", 344},
                {"Legos", 763},
                {"Gaming Consoles", 551},
                {"Board Games", 298}
            };

      foreach (KeyValuePair<string, int> toy in toysSold)
      {
        Console.WriteLine($"We sold {toy.Value} units of {toy.Key}");
      }

      toysSold.Add("Bicycles", 87);
      Console.WriteLine(toysSold.ContainsValue(1));
      Console.WriteLine("After adding bicycles: ");
      foreach (KeyValuePair<string, int> toy in toysSold)
      {
        Console.WriteLine($"We sold {toy.Value} units of {toy.Key}");
      }

      Dictionary<string, int> christmasToys = new Dictionary<string, int>() {
                {"Nutcracker", 523},
                {"Christmas Shoes", 111}
            };

    
        foreach(KeyValuePair<string, int> ctoy in christmasToys)
        {
            toysSold.Add(ctoy.Key, ctoy.Value);
        }

        Console.WriteLine("After adding christmas toys: ");
      foreach (KeyValuePair<string, int> toy in toysSold)
      {
        Console.WriteLine($"We sold {toy.Value} units of {toy.Key}");
      }

      Console.WriteLine(toysSold["Hot Wheels"]);
    }
  }
}
