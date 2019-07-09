using System.Collections.Generic;
using vending_machine.Interfaces;

namespace vending_machine.Models
{

  class Dorito_bag : ChipBag, IPurchaseable
  {

    public List<Flavors> Flavors { get; set; }
    public bool Available { get; set; }

    public Dorito_bag(string name, float cost, List<Flavors> flavor) : base(name, cost)
    {
      Flavors = flavor;
    }





  }

  enum Flavors
  {
    cheesy,
    spicy,
    normal


  }











}