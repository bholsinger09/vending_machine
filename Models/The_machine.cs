using System;
using System.Collections.Generic;
using vending_machine.Interfaces;

namespace vending_machine.Models
{

  class The_machine
  {

    public string Location { get; private set; }
    public string Name { get; private set; }


    public List<IPurchaseable> VendableChips { get; private set; }
    public List<IPurchaseable> VendableDrinks { get; private set; }
    public List<IPurchaseable> Vended { get; private set; }

    //Add chips to available chips

    public void addChip(IPurchaseable chip)
    {
      VendableChips.Add(chip);
    }

    //add drinks to available drinks

    public void addDrink(IPurchaseable drink)
    {
      VendableDrinks.Add(drink);
    }



    #region Print Console

    public void Print(bool available)
    {
      List<IPurchaseable> chips = VendableChips;
      System.Console.WriteLine("Chips:  ");
      if (!available)
      {
        chips = Vended;
      }
      int counter = 1;

      foreach (var chip in chips)
      {
        Console.WriteLine($"{ counter}.  {chip.Name}");
        counter++;
      }






    }



    #endregion


    public The_machine(string location, string name)
    {
      Location = location;
      Name = name;

    }











  }


}