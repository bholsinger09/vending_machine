using System.Collections.Generic;

namespace vending_machine.Models
{

  class Dorito_bag : ChipBag
  {

    public List<Flavors> Flavors { get; set; }
    public bool Available { get; set; }

    public Dorito_bag(string name, int cost, List<Flavors> flavor) : base(name, cost)
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