/* foreach (type variableName in arrayName) 
{
  // code block to be executed
} */
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
      foreach (string i in cars) 
      {
        Console.WriteLine(i);
      }   
    }
  }
}	