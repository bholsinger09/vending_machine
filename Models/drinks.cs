namespace vending_machine.Models
{

  abstract class Drink
  {
    public string Name { get; set; }
    public float Cost { get; set; }

    public bool Healthy { get; set; }

    public Drink(string name, float cost)

    {
      Name = name;
      Cost = cost;

    }




  }











}