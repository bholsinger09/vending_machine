namespace vending_machine.Models
{

  abstract class ChipBag
  {

    public string Name { get; set; }
    public int Cost { get; set; }

    public ChipBag(string name, int cost)
    {
      Name = name;
      Cost = cost;
    }




  }










}