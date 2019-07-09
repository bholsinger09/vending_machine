namespace vending_machine.Models
{

  abstract class Drink
  {
    public string Name { get; set; }
    public string Cost { get; set; }

    public bool Healthy { get; set; }

    public Drink(string name, string cost)

    {
      Name = name;
      Cost = cost;

    }




  }











}