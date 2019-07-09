using System;
using vending_machine.Models;

namespace vending_machine
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Clear();
      #region Create Data
      The_machine V420 = new The_machine("Boise, Idaho", "Snacking inc.");



      #endregion

      bool usingMachine = true;
      string menu = "available";
      //building menu for available foods(only has chips)
      //building menu for available drinks

      while (usingMachine)
      {
        switch (menu)
        {
          case "available":
            Console.Write("The chip your choosen is available");
            break;

          case "return"
            Console.Write("Returning money");
            break;

        }
        string selection = Console.ReadLine().ToLower();



      }





    }
  }
}
