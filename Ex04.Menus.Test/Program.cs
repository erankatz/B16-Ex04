using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Menus.Interface.MenuItemList mainMenu1 = new Menus.Interface.MenuItemList();
            mainMenu1.Title = "B16 Ex04";

            Menus.Interface.MenuItemList subMenu1List = new Menus.Interface.MenuItemList();
            Menus.Interface.SubMenu subMenu1 = new Menus.Interface.SubMenu("Version and action", subMenu1List);


            Menus.Interface.MenuItem op1 = new Menus.Interface.MenuItem("Show Version", new ShowVersion());
            Menus.Interface.MenuItem op2 = new Menus.Interface.MenuItem("Chars counter", new CharsCount());

            subMenu1List.AddItem(op1);
            subMenu1List.AddItem(op2);

            mainMenu1.AddItem(subMenu1);
            mainMenu1.Run();
        }
    }
}
