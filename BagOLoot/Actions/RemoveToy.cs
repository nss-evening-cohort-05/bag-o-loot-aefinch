using System;
using System.Collections.Generic;

namespace  BagOLoot.Actions
{
    public class RemoveToy
    {
        public static void DoAction(ToyRegister bag, ChildRegister book)
        {
            Console.Clear();
            Console.WriteLine("Choose child");

            var children = book.GetChildren().ToArray();
            foreach (Child child in children)
            {
                Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
            }

            Console.Write ("> ");
            string childName = Console.ReadLine();
            Child kid = book.GetChild(children[int.Parse(childName)-1].name);
      
            Console.WriteLine("Choose toy");
            var thisChildsToys = bag.GetToysForChild(kid).ToArray();
            foreach (Toy toy in thisChildsToys)
            {
                Console.WriteLine($"{Array.IndexOf(thisChildsToys,toy)+1}. {toy.name}");
            }
            string toyChoice = Console.ReadLine();
            // Toy specificToy = bag.GetSingleToy(thisChildsToys[int.Parse(toyName)-1].name, kid);
            Toy specificToy = thisChildsToys[int.Parse(toyChoice)-1];
            bag.RevokeToy(specificToy);
        }
    }
}