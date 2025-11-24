using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProjectC6.InputSanitisers;

namespace TeamProjectC6.Menu_s
{
    public abstract class Menu
    {
        protected List<MenuItem> _items = new List<MenuItem>();
        protected InptegerSanitiser _sanitizer = new InptegerSanitiser();

        public void AddItem(string description, Action action)
        {
            _items.Add(new MenuItem(description, action));
            _sanitizer.UpdateBounds(1, _items.Count + 1);
        }


        public virtual void Display()//
        {
            Console.WriteLine("\n=== Menu ===");
            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_items[i].Description}");
            }
            Console.WriteLine($"Enter {_items.Count + 1} to exit.");
        }


        public void Run()
        {
            int choice;
            do
            {
                Display();
                choice = _sanitizer.GetValidInput("Select an option: ");

                if (choice == _items.Count + 1)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                if (choice > 0 && choice <= _items.Count)
                {
                    _items[choice - 1].Action.Invoke();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }

            } while (true);
        }

    }

}
