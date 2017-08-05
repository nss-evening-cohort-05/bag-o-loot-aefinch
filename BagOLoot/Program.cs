using System;
using System.Collections.Generic;
using System.Linq;
using BagOLoot.Actions;

namespace BagOLoot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            ChildRegister book = new ChildRegister();
            ToyRegister bag = new ToyRegister();

            // Choice will hold the number entered by the user
            // after main menu ws displayed
            int choice;

            do
            {
                // Show the main menu
                choice = menu.Show();

                switch (choice)
                {
                    // Menu option 1: Adding fish
                    case 1:
                        CreateChild.DoAction(book);
                        break;

                    // Menu option 2: Removing fish
                    case 2:
                        AddToy.DoAction(bag, book);
                        break;
                    
                    case 3:
                        RemoveToy.DoAction(bag, book);
                        break;

                    case 4:
                        ViewToyList.DoAction(bag, book);
                        break;
                    case 5:
                        MarkAsDelivered.DoAction(bag, book);
                        break;
                    case 6:
                        PrintDeliveryReport.DoAction(bag, book);
                        break;
                }
            } while (choice < 7);
        }
    }
}
