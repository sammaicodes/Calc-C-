using System;
using System.Collections.Generic;
using Calc.Models;

namespace Calc {
  public class Program{
    public static void Main()
    {
      Console.WriteLine("Enter a number:");
      string numberSring = Console.ReadLine();
      // int number = int.Parse(numberSring);

      Console.WriteLine("Enter another number: ");
      string numberString2 = Console.ReadLine();
      // int number2 = int.Parse(numberString2);

      Calculator calcOne = new Calculator();

      int i = 0;
      int j = 0;
      bool isNumber = int.TryParse(numberSring, out i);
      bool isNumber2 = int.TryParse(numberString2, out j);
      if (isNumber == true || isNumber2 == true)
      {
        Console.WriteLine(calcOne.Addition(i, j));
        Console.WriteLine($"{i} - {j} = {calcOne.Subtraction(i, j)}");
      }
      else 
      {
        Console.WriteLine("You did not enter a valid number. ----Exiting----");
      }
    }
  }
}