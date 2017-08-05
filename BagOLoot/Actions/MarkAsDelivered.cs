using System;
using System.Collections.Generic;
namespace BagOLoot.Actions
{
    public class MarkAsDelivered
    {
        public static void DoAction(ToyRegister bag, ChildRegister book)
        {
            Console.Clear();
            Console.WriteLine("Choose child");
            var children = book.GetChildren().ToArray();
            foreach (Child child in children)
            {
                Console.WriteLine($"{Array.IndexOf(children, child)+1}. {child.name}");
            }
            Console.Write("> ");
            string childName = Console.ReadLine();
            Child kid = book.GetChild(children[int.Parse(childName)-1].name);
            var deliveryStatus = book.ChildHasReceivedToys(kid);
            Console.WriteLine($"Toys have been deliverd to {deliveryStatus.name}: {deliveryStatus.delivered}");
            Console.ReadLine();
        }
    }
}