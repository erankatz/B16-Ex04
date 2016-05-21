using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interface
{
    public class MenuItemList
    {
        protected List<MenuItem> m_menuItems = new List<MenuItem>();
        protected string m_exitMessage = "To Exit";
        protected string m_title = "Menu";

        public void AddItem(MenuItem item)
        {
            m_menuItems.Add(item);
        }

        public string ExitMessage
        {
            get { return m_exitMessage; }
            set { m_exitMessage = value; }
        }

        public string Title
        {
            get { return m_title; }
            set { m_title = value; }
        }

        public void Show()
        {
            Console.WriteLine(m_title + "\n");
            int i = 0;
            foreach (MenuItem menuItem in m_menuItems)
            {
                Console.WriteLine("Press [{0}] For {1}", (i + 1), menuItem.Name);
                i++;
            }
            Console.WriteLine("Press [0] " + m_exitMessage);

        }

        // if null, exit is selected
        public MenuItem SelectItem()
        {
            MenuItem item = null;
            while (item == null)
            {
                int choice = -1;
                try { choice = Int32.Parse(Console.ReadLine()); } catch { System.Console.WriteLine("Must Enter a number of the choice");  }
                if (choice == 0) { break; }
                choice--;
                if (choice < 0 || choice >= m_menuItems.Count)
                {
                    Console.WriteLine("Invalid Choice");
                }
                else
                {
                    item = m_menuItems[choice];
                }
            }
            return item;
        }

        public void Run()
        {
            MenuItem item = null;
            do
            {
                Show();
                item = SelectItem();
                if (item != null) { item.DoAction(); }               
            } while (item != null);
        }
    }
}