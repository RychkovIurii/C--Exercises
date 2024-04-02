using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string firstName = "Jussi";
      string lastName = "Koskinen";
      string name = $"My full name is: {firstName} {lastName}";
      Console.WriteLine(name);

	  // Full name
      string name2 = "Juri Smith";
      // Location of the letter D
      int charPos = name2.IndexOf("S");
      // Get last name
      string lastName2 = name2.Substring(charPos);
      // Print the result
      Console.WriteLine(lastName2);
    }
  }
}