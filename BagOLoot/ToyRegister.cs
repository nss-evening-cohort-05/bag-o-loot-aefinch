using System;
using System.Linq;
using System.Collections.Generic;

namespace BagOLoot
{
  public class ToyRegister
  {
    private List<Toy> _toys = new List<Toy>();

    public Toy Add(string toy, Child child)
    {
      // Create new toy instance
      Toy newToy = new Toy(){
        name = toy,
        child = child
      };

      // Add to private collection
      _toys.Add(newToy);

      return newToy;
    }

    public void RevokeToy(Toy toy)
    {
      _toys.Remove(toy);
    }

    public List<Toy> GetToysForChild(Child kid)
    {
      List<Toy> toyList = new List<Toy>();
      // foreach (var toy in _toys)
      // {
      //     if (toy.child == kid)
      //     {
      //       toyList.Add(toy);
      //     }
      // }
      var theseToys = 
      from toy in _toys
      where toy.child == kid
      select toy;
      toyList = theseToys.ToList();
      return toyList;
    }
    public Toy GetSingleToy (string toyName, Child kid)
    {
      foreach (var item in _toys)
      {
          if (item.name == toyName && item.child == kid)
          {
            return item;
          }
      }
      throw new Exception();
    }
  }
}
