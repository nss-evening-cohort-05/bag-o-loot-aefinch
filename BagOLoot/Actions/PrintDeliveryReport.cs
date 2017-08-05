using System;
using System.Collections.Generic;
namespace BagOLoot.Actions
{
    public class PrintDeliveryReport
    {
        public static void DoAction(ToyRegister bag, ChildRegister book)
        {
            Console.Clear();
            Console.WriteLine("Yuletime Delivery Report");
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%");
            var children = book.GetChildren().ToArray();
            foreach (var kid in children)
            {
                Console.WriteLine($"{kid.name}    delivered? {kid.delivered}");
                var thisChildsToys = bag.GetToysForChild(kid).ToArray();
                foreach (Toy toy in thisChildsToys)
                {
                    Console.WriteLine($"{Array.IndexOf(thisChildsToys,toy)+1}. {toy.name}");

                }
                Console.WriteLine($"{Environment.NewLine}");
            }
            Console.WriteLine("Press Enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}