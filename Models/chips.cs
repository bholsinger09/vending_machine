namespace vending_machine.Models
{

  abstract class ChipBag
  {

    public string Name { get; set; }
    public float Cost { get; set; }

    public ChipBag(string name, float cost)
    {
      Name = name;
      Cost = cost;
    }




  }










}