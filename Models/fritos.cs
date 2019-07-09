using System.Collections.Generic;

namespace vending_machine.Models
{

  class Frito_bag : ChipBag, IPurchaseable
  {

    public List<Flavors> Flavors { get; set; }
    public bool Available { get; set; }

    public Frito_bag(string name, float cost, List<Flavors> flavor) : base(name, cost)
    {
      Flavors = flavor;
    }





  }

  enum Flavors
  {
    salty,
    spicy,

    cheesy,
    normal


  }











}