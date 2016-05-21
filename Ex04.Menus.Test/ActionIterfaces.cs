using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    class ShowVersion : Ex04.Menus.Interface.IAction
    {
        public void DoAction()
        {
            System.Console.WriteLine("Version: 16.2.4.0");
        }
    }

    class CharsCount : Ex04.Menus.Interface.IAction
    {
        public void DoAction()
        {
            System.Console.WriteLine("Write your scentence");
            string scentence = System.Console.ReadLine();
            System.Console.WriteLine("You entered {0} letters ", scentence.Length);
        }
    }

    class CountSpaces : Ex04.Menus.Interface.IAction
    {
        public void DoAction()
        {
            System.Console.WriteLine("Version: 16.2.4.0");
        }
    }

    class ShowTime : Ex04.Menus.Interface.IAction
    {
        public void DoAction()
        {
            System.Console.WriteLine("Version: 16.2.4.0");
        }
    }

    class ShowDate : Ex04.Menus.Interface.IAction
    {
        public void DoAction()
        {
            System.Console.WriteLine("Version: 16.2.4.0");
        }
    }
}
